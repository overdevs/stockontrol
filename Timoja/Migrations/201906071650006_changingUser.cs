namespace Stockontroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Nome", c => c.String());
            AddColumn("dbo.Usuario", "Sobrenome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "Sobrenome");
            DropColumn("dbo.Usuario", "Nome");
        }
    }
}
