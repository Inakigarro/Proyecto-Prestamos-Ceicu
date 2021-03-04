namespace ProyectoPrestamosCEICU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        Legajo = c.String(nullable: false, maxLength: 128),
                        Carrera = c.String(),
                        Habilitado = c.Boolean(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Ciudad = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Correo = c.String(),
                        Secretario_IdSecretario = c.Int(),
                    })
                .PrimaryKey(t => t.Legajo)
                .ForeignKey("dbo.Secretarios", t => t.Secretario_IdSecretario)
                .Index(t => t.Secretario_IdSecretario);
            
            CreateTable(
                "dbo.Secretarios",
                c => new
                    {
                        IdSecretario = c.Int(nullable: false, identity: true),
                        Secretaria = c.String(),
                    })
                .PrimaryKey(t => t.IdSecretario);
            
            CreateTable(
                "dbo.Materiales",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Observacion = c.String(),
                        Modelo = c.String(),
                        Color = c.String(),
                        CapacidaddeCarga = c.Double(name: "Capacidad de Carga"),
                        PuertodeSalida = c.String(name: "Puerto de Salida"),
                        CantidaddeEnchufes = c.Int(name: "Cantidad de Enchufes"),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MaterialId);
            
            CreateTable(
                "dbo.Profesores",
                c => new
                    {
                        Legajo = c.String(nullable: false, maxLength: 128),
                        Materia = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Ciudad = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Legajo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnos", "Secretario_IdSecretario", "dbo.Secretarios");
            DropIndex("dbo.Alumnos", new[] { "Secretario_IdSecretario" });
            DropTable("dbo.Profesores");
            DropTable("dbo.Materiales");
            DropTable("dbo.Secretarios");
            DropTable("dbo.Alumnos");
        }
    }
}
