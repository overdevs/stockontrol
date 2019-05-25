using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockontrol.Models
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