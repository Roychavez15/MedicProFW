namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtableHabitacion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habitacions",
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
            DropTable("dbo.Habitacions");
        }
    }
}
