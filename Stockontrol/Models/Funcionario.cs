using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockontrol.Models
{
    public class Funcionario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime dataNascimento { get; set; }
        

        public long UsuarioID { get; set; }
        public long nVendas { get; set; }
    }
}