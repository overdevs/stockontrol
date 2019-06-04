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
}