namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newfieldsPlanilla15022022 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planillas", "TipoSeguro", c => c.String());
            AddColumn("dbo.Planillas", "TipoBeneficiario", c => c.String());
            AddColumn("dbo.Planillas", "CedulaTitular", c => c.String());
            AddColumn("dbo.Planillas", "NombresTitular", c => c.String());
            AddColumn("dbo.Planillas", "Parentezco", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planillas", "Parentezco");
            DropColumn("dbo.Planillas", "NombresTitular");
            DropColumn("dbo.Planillas", "CedulaTitular");
            DropColumn("dbo.Planillas", "TipoBeneficiario");
            DropColumn("dbo.Planillas", "TipoSeguro");
        }
    }
}
