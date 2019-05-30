using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockontroll.Models
{
    public class Endereco
    {
        public long Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
    }
}