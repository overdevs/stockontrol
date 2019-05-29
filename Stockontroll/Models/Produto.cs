using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;


namespace Stockontroll.Models
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public Fornecedor fornecedor { get; set; }
    }
}