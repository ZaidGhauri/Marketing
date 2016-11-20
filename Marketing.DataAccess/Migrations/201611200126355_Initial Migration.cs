namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Collection = c.String(),
                        PictureId = c.Int(nullable: false),
                        ParentCategoryId = c.Int(nullable: false),
                        IsFeatured = c.Boolean(nullable: false),
                        ShowOnHomePage = c.Boolean(nullable: false),
                        IncludeInTopMenu = c.Boolean(nullable: false),
                        Published = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        WebSiteId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WebSites", t => t.WebSiteId, cascadeDelete: true)
                .Index(t => t.WebSiteId);
            
            CreateTable(
                "dbo.WebSites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Name = c.String(nullable: false, maxLength: 60),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShortDescription = c.String(),
                        FullDescription = c.String(),
                        IsFeatured = c.Boolean(nullable: false),
                        ShowOnHomePage = c.Boolean(nullable: false),
                        IncludeInTopMenu = c.Boolean(nullable: false),
                        Published = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        AllowCustomerReviews = c.Boolean(nullable: false),
                        RatingSum = c.Int(nullable: false),
                        TotalReviews = c.Int(nullable: false),
                        ManufacturerNo = c.Int(nullable: false),
                        DisplayOrder = c.String(),
                        CategoryId = c.Int(),
                        StoreId = c.Int(),
                        TagId = c.Int(),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Stores", t => t.StoreId)
                .ForeignKey("dbo.Tags", t => t.TagId)
                .Index(t => t.CategoryId)
                .Index(t => t.StoreId)
                .Index(t => t.TagId);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.String(nullable: false, maxLength: 80),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsPopular = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        Url = c.String(),
                        CompanyId = c.Int(nullable: false),
                        CompanyName = c.String(),
                        CompanyPhoneNo = c.Int(nullable: false),
                        IsFeatured = c.Boolean(nullable: false),
                        ShowOnHomePage = c.Boolean(nullable: false),
                        IncludeInTopMenu = c.Boolean(nullable: false),
                        Published = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        WebSiteId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WebSites", t => t.WebSiteId, cascadeDelete: true)
                .Index(t => t.WebSiteId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Meta = c.String(),
                        Name = c.String(nullable: false, maxLength: 80),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PromotionCoupons",
                c => new
                    {
                        PromotionId = c.Int(name: "PromotionId", nullable: false),
                        StoreId = c.Int(name: "StoreId", nullable: false),
                    })
                .PrimaryKey(t => new { t.PromotionId, t.StoreId })
                .ForeignKey("dbo.Coupons", t => t.PromotionId, cascadeDelete: true)
                .ForeignKey("dbo.Promotions", t => t.StoreId, cascadeDelete: true)
                .Index(t => t.PromotionId)
                .Index(t => t.StoreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coupons", "TagId", "dbo.Tags");
            DropForeignKey("dbo.Coupons", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Stores", "WebSiteId", "dbo.WebSites");
            DropForeignKey("dbo.PromotionCoupons", "Store.Id", "dbo.Promotions");
            DropForeignKey("dbo.PromotionCoupons", "Promotion.Id", "dbo.Coupons");
            DropForeignKey("dbo.Coupons", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "WebSiteId", "dbo.WebSites");
            DropIndex("dbo.PromotionCoupons", new[] { "Store.Id" });
            DropIndex("dbo.PromotionCoupons", new[] { "Promotion.Id" });
            DropIndex("dbo.Stores", new[] { "WebSiteId" });
            DropIndex("dbo.Coupons", new[] { "TagId" });
            DropIndex("dbo.Coupons", new[] { "StoreId" });
            DropIndex("dbo.Coupons", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "WebSiteId" });
            DropTable("dbo.PromotionCoupons");
            DropTable("dbo.Tags");
            DropTable("dbo.Stores");
            DropTable("dbo.Promotions");
            DropTable("dbo.Coupons");
            DropTable("dbo.WebSites");
            DropTable("dbo.Categories");
        }
    }
}
