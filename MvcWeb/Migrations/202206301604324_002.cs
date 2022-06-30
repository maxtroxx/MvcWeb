namespace MvcWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productoes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    nombre = c.String(nullable: false),
                    stock = c.Int(nullable: false),
                    precio = c.Int(nullable: false),
                    descripcion = c.String(),
                    imagen = c.String()
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropColumn("dbo.Productoes", "imagen");
        }
    }
}
