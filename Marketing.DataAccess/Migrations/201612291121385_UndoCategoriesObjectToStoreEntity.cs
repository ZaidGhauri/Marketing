namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UndoCategoriesObjectToStoreEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StoreCategories", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.StoreCategories", "Category_Id", "dbo.Categories");
            DropIndex("dbo.StoreCategories", new[] { "Store_Id" });
            DropIndex("dbo.StoreCategories", new[] { "Category_Id" });
            DropTable("dbo.StoreCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StoreCategories",
                c => new
                    {
                        Store_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.Category_Id });
            
            CreateIndex("dbo.StoreCategories", "Category_Id");
            CreateIndex("dbo.StoreCategories", "Store_Id");
            AddForeignKey("dbo.StoreCategories", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StoreCategories", "Store_Id", "dbo.Stores", "Id", cascadeDelete: true);
        }
    }
}
