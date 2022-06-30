namespace MvcWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "imagen", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "imagen");
        }
    }
}
