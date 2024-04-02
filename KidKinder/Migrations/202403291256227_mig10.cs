namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Galleries", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Galleries", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Galleries", "Title", c => c.String());
            DropColumn("dbo.Galleries", "Status");
        }
    }
}
