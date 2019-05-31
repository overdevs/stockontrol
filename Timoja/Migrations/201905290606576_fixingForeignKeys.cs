namespace Stockontroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fornecedor", "endereco_Id", "dbo.Endereco");
            DropForeignKey("dbo.Produto", "fornecedor_Id", "dbo.Fornecedor");
            DropIndex("dbo.Fornecedor", new[] { "endereco_Id" });
            DropIndex("dbo.Produto", new[] { "fornecedor_Id" });
            AddColumn("dbo.Fornecedor", "enderecoId", c => c.Int(nullable: false));
            AddColumn("dbo.Produto", "fornecedorId", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "Tipo", c => c.Int(nullable: false));
            DropColumn("dbo.Fornecedor", "endereco_Id");
            DropColumn("dbo.Produto", "fornecedor_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "fornecedor_Id", c => c.Long());
            AddColumn("dbo.Fornecedor", "endereco_Id", c => c.Long());
            DropColumn("dbo.Usuario", "Tipo");
            DropColumn("dbo.Produto", "fornecedorId");
            DropColumn("dbo.Fornecedor", "enderecoId");
            CreateIndex("dbo.Produto", "fornecedor_Id");
            CreateIndex("dbo.Fornecedor", "endereco_Id");
            AddForeignKey("dbo.Produto", "fornecedor_Id", "dbo.Fornecedor", "Id");
            AddForeignKey("dbo.Fornecedor", "endereco_Id", "dbo.Endereco", "Id");
        }
    }
}
