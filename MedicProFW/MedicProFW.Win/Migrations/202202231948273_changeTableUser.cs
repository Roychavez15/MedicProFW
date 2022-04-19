namespace MedicProFW.Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTableUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Usuario", c => c.String());
            AddColumn("dbo.Users", "Clave", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Clave");
            DropColumn("dbo.Users", "Usuario");
        }
    }
}
