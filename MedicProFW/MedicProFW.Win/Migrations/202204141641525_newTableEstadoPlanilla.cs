namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTableEstadoPlanilla : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EstadoPlanillas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Estado = c.String(),
                        Final = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EstadoPlanillas");
        }
    }
}
