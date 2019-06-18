namespace Stockontroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixAgain : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
