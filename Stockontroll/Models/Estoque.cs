using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;


namespace Stockontroll.Models
{
    public class Estoque
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public long idFornecedor { get; set; }
    }

    public class EstoqueDBContext : DbContext
    {
        DbSet<Estoque> Estoque { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
        
    }
}