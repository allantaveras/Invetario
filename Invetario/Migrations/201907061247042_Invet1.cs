namespace Invetario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Invet1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.almacen", "descripcion_almacen", c => c.String(nullable: false));
            AlterColumn("dbo.almacen", "estado", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.almacen", "estado", c => c.String());
            AlterColumn("dbo.almacen", "descripcion_almacen", c => c.String());
        }
    }
}
