namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTablePlanillaEstado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planillas", "Estado", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planillas", "Estado");
        }
    }
}
