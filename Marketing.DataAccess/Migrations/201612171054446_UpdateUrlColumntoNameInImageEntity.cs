namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUrlColumntoNameInImageEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "Name", c => c.String(nullable: false, maxLength: 400));
            DropColumn("dbo.Images", "Url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Url", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Images", "Name");
        }
    }
}
