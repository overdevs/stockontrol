using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockontrol.Models
{
    public class Produto
    {
        // id, Nome, Categoria, Preço, Quantidade, {idFornecedor}.
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        
        public long idFornecedor { get; set; }
    }
}