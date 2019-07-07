namespace Invetario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.transaccion", "tipo_transaccion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.transaccion", "tipo_transaccion", c => c.String());
        }
    }
}
