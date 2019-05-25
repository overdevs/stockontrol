using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockontrol.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public enum Tipo { Admin, Funcionario };
    }
}