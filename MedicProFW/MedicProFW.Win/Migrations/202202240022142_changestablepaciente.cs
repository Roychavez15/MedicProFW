namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestablepaciente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pacientes", "TipoBeneficiario", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pacientes", "TipoBeneficiario");
        }
    }
}
