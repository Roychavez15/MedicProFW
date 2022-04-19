namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtable13042022 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlanillaDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TIPO_PROCEDIMIENTO = c.String(),
                        Cantidad = c.Int(nullable: false),
                        Medico = c.String(),
                        Observacion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Planilla_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planillas", t => t.Planilla_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Planilla_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Planillas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha_Inicio = c.DateTime(nullable: false),
                        Fecha_Fin = c.DateTime(nullable: false),
                        Diagnostico1 = c.String(),
                        Diagnostico2 = c.String(),
                        Diagnostico3 = c.String(),
                        Diagnostico4 = c.String(),
                        CIE1 = c.String(),
                        CIE2 = c.String(),
                        CIE3 = c.String(),
                        CIE4 = c.String(),
                        DiagTipo1 = c.String(),
                        DiagTipo2 = c.String(),
                        DiagTipo3 = c.String(),
                        DiagTipo4 = c.String(),
                        CodigoDerivacion = c.String(),
                        Secuencial = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Contigencia_Id = c.Int(),
                        Dependencia_Id = c.Int(),
                        Habitacion_Id = c.Int(),
                        Paciente_Id = c.Int(),
                        Tipo_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enfermedads", t => t.Contigencia_Id)
                .ForeignKey("dbo.Dependencias", t => t.Dependencia_Id)
                .ForeignKey("dbo.Habitacions", t => t.Habitacion_Id)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id)
                .ForeignKey("dbo.Servicios", t => t.Tipo_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Contigencia_Id)
                .Index(t => t.Dependencia_Id)
                .Index(t => t.Habitacion_Id)
                .Index(t => t.Paciente_Id)
                .Index(t => t.Tipo_Id)
                .Index(t => t.User_Id);
            
            //CreateTable(
            //    "dbo.Tarifarios",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Codigo = c.String(),
            //            Nombre = c.String(),
            //            Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            TIPO_PROCEDIMIENTO = c.String(),
            //            Estado = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlanillaDetails", "User_Id", "dbo.Users");
            DropForeignKey("dbo.PlanillaDetails", "Planilla_Id", "dbo.Planillas");
            DropForeignKey("dbo.Planillas", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Planillas", "Tipo_Id", "dbo.Servicios");
            DropForeignKey("dbo.Planillas", "Paciente_Id", "dbo.Pacientes");
            DropForeignKey("dbo.Planillas", "Habitacion_Id", "dbo.Habitacions");
            DropForeignKey("dbo.Planillas", "Dependencia_Id", "dbo.Dependencias");
            DropForeignKey("dbo.Planillas", "Contigencia_Id", "dbo.Enfermedads");
            DropIndex("dbo.Planillas", new[] { "User_Id" });
            DropIndex("dbo.Planillas", new[] { "Tipo_Id" });
            DropIndex("dbo.Planillas", new[] { "Paciente_Id" });
            DropIndex("dbo.Planillas", new[] { "Habitacion_Id" });
            DropIndex("dbo.Planillas", new[] { "Dependencia_Id" });
            DropIndex("dbo.Planillas", new[] { "Contigencia_Id" });
            DropIndex("dbo.PlanillaDetails", new[] { "User_Id" });
            DropIndex("dbo.PlanillaDetails", new[] { "Planilla_Id" });
            //DropTable("dbo.Tarifarios");
            DropTable("dbo.Planillas");
            DropTable("dbo.PlanillaDetails");
        }
    }
}
