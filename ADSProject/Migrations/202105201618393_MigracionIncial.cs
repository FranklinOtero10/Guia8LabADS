namespace ADSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionIncial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false, maxLength: 3),
                        nombre = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false, maxLength: 12),
                        email = c.String(nullable: false, maxLength: 254),
                        nombres = c.String(nullable: false, maxLength: 50),
                        apellidos = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        idCarrera = c.Int(nullable: false),
                        idMateria = c.Int(nullable: false),
                        idProfesor = c.Int(nullable: false),
                        Ciclo = c.Int(nullable: false),
                        Anio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 254),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profesor");
            DropTable("dbo.Materia");
            DropTable("dbo.Grupo");
            DropTable("dbo.Estudiante");
            DropTable("dbo.Carrera");
        }
    }
}
