namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Store1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Stores1", newName: "Stores");
            RenameTable(name: "dbo.Stores", newName: "StoreCategories");
            RenameColumn(table: "dbo.StoreCategories", name: "CategoryId", newName: "Category_CategoryId");
            RenameColumn(table: "dbo.StoreCategories", name: "StoreId", newName: "Store_StoreId");
            RenameIndex(table: "dbo.StoreCategories", name: "IX_StoreId", newName: "IX_Store_StoreId");
            RenameIndex(table: "dbo.StoreCategories", name: "IX_CategoryId", newName: "IX_Category_CategoryId");
            DropPrimaryKey("dbo.StoreCategories");
            AddPrimaryKey("dbo.StoreCategories", new[] { "Store_StoreId", "Category_CategoryId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.StoreCategories");
            AddPrimaryKey("dbo.StoreCategories", new[] { "CategoryId", "StoreId" });
            RenameIndex(table: "dbo.StoreCategories", name: "IX_Category_CategoryId", newName: "IX_CategoryId");
            RenameIndex(table: "dbo.StoreCategories", name: "IX_Store_StoreId", newName: "IX_StoreId");
            RenameColumn(table: "dbo.StoreCategories", name: "Store_StoreId", newName: "StoreId");
            RenameColumn(table: "dbo.StoreCategories", name: "Category_CategoryId", newName: "CategoryId");
            RenameTable(name: "dbo.StoreCategories", newName: "Stores");
            RenameTable(name: "dbo.Stores", newName: "Stores1");
        }
    }
}
