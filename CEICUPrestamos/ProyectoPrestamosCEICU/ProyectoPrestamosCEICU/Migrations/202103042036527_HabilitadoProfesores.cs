namespace ProyectoPrestamosCEICU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HabilitadoProfesores : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Alumnos", name: "Habilitado", newName: "HabilitadoAlumno");
            AddColumn("dbo.Profesores", "HabilitadoProfesor", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesores", "HabilitadoProfesor");
            RenameColumn(table: "dbo.Alumnos", name: "HabilitadoAlumno", newName: "Habilitado");
        }
    }
}
