using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;


namespace Stockontroll.Models
{
    public class Fornecedor
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
    public class FornecedorDBContext : DbContext
    {
        DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Stockontroll.Models.Fornecedor> Fornecedors { get; set; }
    }
}