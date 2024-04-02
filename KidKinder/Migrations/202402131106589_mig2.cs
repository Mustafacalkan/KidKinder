namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Features", "Header", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Features", "Header", c => c.Int(nullable: false));
        }
    }
}
