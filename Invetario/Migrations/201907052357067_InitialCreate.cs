namespace Invetario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        id_articulo = c.Int(nullable: false, identity: true),
                        descripcion_articulo = c.String(),
                        existencia = c.Int(nullable: false),
                        id_tipo_inventario = c.Int(nullable: false),
                        costo_unitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        estado = c.String(),
                    })
                .PrimaryKey(t => t.id_articulo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articulo");
        }
    }
}
