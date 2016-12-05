namespace Marketing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEntities : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "Collection");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Collection", c => c.String());
        }
    }
}
