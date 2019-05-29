namespace Stockontroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Rua = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        CNPJ = c.String(),
                        Telefone = c.String(),
                        endereco_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Endereco", t => t.endereco_Id)
                .Index(t => t.endereco_Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Categoria = c.String(),
                        Marca = c.String(),
                        Preco = c.Single(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        fornecedor_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.fornecedor_Id)
                .Index(t => t.fornecedor_Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "fornecedor_Id", "dbo.Fornecedor");
            DropForeignKey("dbo.Fornecedor", "endereco_Id", "dbo.Endereco");
            DropIndex("dbo.Produto", new[] { "fornecedor_Id" });
            DropIndex("dbo.Fornecedor", new[] { "endereco_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Produto");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Endereco");
        }
    }
}
