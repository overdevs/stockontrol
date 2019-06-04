namespace Stockontroll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeEndereco : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Endereco");
        }
        
        public override void Down()
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
            
        }
    }
}
