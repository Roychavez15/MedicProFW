namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtbalemedico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Especialidad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicos");
        }
    }
}
