namespace Stockontroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Cor", c => c.String());
            AddColumn("dbo.Produto", "Tamanho", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "Tamanho");
            DropColumn("dbo.Produto", "Cor");
        }
    }
}
