namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageEntityAdded : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Pictures",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Url = c.String(nullable: false, maxLength: 200),
                    IsActive = c.Boolean(nullable: false),
                    Created = c.DateTime(nullable: false),
                    CreatedBy = c.String(),
                    Modified = c.DateTime(nullable: false),
                    ModifiedBy = c.String(),
                })
                .PrimaryKey(t => t.Id);

            RenameTable(name: "dbo.Pictures", newName: "Images");
            DropForeignKey("dbo.Categories", "WebSiteId", "dbo.WebSites");
            DropForeignKey("dbo.Stores", "WebSiteId", "dbo.WebSites");
            AddColumn("dbo.Categories", "ImageId", c => c.Int(nullable: false));
            AddColumn("dbo.Coupons", "ImageId", c => c.Int(nullable: false));
            AddColumn("dbo.Stores", "ImageId", c => c.Int(nullable: false));
            AlterColumn("dbo.Images", "Url", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.Categories", "ImageId");
            CreateIndex("dbo.Coupons", "ImageId");
            CreateIndex("dbo.Stores", "ImageId");
            AddForeignKey("dbo.Categories", "ImageId", "dbo.Images", "Id");
            AddForeignKey("dbo.Coupons", "ImageId", "dbo.Images", "Id");
            AddForeignKey("dbo.Stores", "ImageId", "dbo.Images", "Id");
            AddForeignKey("dbo.Categories", "WebSiteId", "dbo.WebSites", "Id");
            AddForeignKey("dbo.Stores", "WebSiteId", "dbo.WebSites", "Id");
            DropColumn("dbo.Categories", "PictureId");
        }
        
        public override void Down()
        {
            DropTable("dbo.Pictures");
            AddColumn("dbo.Categories", "PictureId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Stores", "WebSiteId", "dbo.WebSites");
            DropForeignKey("dbo.Categories", "WebSiteId", "dbo.WebSites");
            DropForeignKey("dbo.Stores", "ImageId", "dbo.Images");
            DropForeignKey("dbo.Coupons", "ImageId", "dbo.Images");
            DropForeignKey("dbo.Categories", "ImageId", "dbo.Images");
            DropIndex("dbo.Stores", new[] { "ImageId" });
            DropIndex("dbo.Coupons", new[] { "ImageId" });
            DropIndex("dbo.Categories", new[] { "ImageId" });
            AlterColumn("dbo.Images", "Url", c => c.String());
            DropColumn("dbo.Stores", "ImageId");
            DropColumn("dbo.Coupons", "ImageId");
            DropColumn("dbo.Categories", "ImageId");
            AddForeignKey("dbo.Stores", "WebSiteId", "dbo.WebSites", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Categories", "WebSiteId", "dbo.WebSites", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Images", newName: "Pictures");
        }
    }
}
