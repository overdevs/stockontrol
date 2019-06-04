namespace Stockontroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixFornecedor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedor", "Endereco", c => c.String());
            DropColumn("dbo.Fornecedor", "enderecoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fornecedor", "enderecoId", c => c.Int(nullable: false));
            DropColumn("dbo.Fornecedor", "Endereco");
        }
    }
}
