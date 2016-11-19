namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActiveColumnAddedInContactType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactTypes", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactTypes", "IsActive");
        }
    }
}
