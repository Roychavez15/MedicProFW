namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dependencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Diagnosticoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enfermedads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cedula = c.String(nullable: false, maxLength: 20),
                        Nombres = c.String(nullable: false, maxLength: 20),
                        Apellidos = c.String(nullable: false, maxLength: 20),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Genero = c.String(),
                        EstadoCivil = c.String(maxLength: 50),
                        Pais = c.String(maxLength: 100),
                        Provincia = c.String(maxLength: 100),
                        Ciudad = c.String(maxLength: 100),
                        Address = c.String(maxLength: 100),
                        HomePhone = c.String(maxLength: 20),
                        CellularPhone = c.String(maxLength: 20),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seguroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Servicios");
            DropTable("dbo.Seguroes");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Enfermedads");
            DropTable("dbo.Diagnosticoes");
            DropTable("dbo.Dependencias");
        }
    }
}
