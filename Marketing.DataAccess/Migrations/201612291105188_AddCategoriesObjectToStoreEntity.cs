namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesObjectToStoreEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stores", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Stores", new[] { "Category_Id" });
            CreateTable(
                "dbo.StoreCategories",
                c => new
                    {
                        Store_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.Category_Id })
                .ForeignKey("dbo.Stores", t => t.Store_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .Index(t => t.Store_Id)
                .Index(t => t.Category_Id);
            
            DropColumn("dbo.Stores", "Category_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stores", "Category_Id", c => c.Int());
            DropForeignKey("dbo.StoreCategories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.StoreCategories", "Store_Id", "dbo.Stores");
            DropIndex("dbo.StoreCategories", new[] { "Category_Id" });
            DropIndex("dbo.StoreCategories", new[] { "Store_Id" });
            DropTable("dbo.StoreCategories");
            CreateIndex("dbo.Stores", "Category_Id");
            AddForeignKey("dbo.Stores", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
