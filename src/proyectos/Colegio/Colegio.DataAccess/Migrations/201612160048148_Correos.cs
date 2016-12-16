namespace Colegio.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estudiantes", "Correo", c => c.String(maxLength: 80));
            AddColumn("dbo.Profesores", "Correo", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesores", "Correo");
            DropColumn("dbo.Estudiantes", "Correo");
        }
    }
}
