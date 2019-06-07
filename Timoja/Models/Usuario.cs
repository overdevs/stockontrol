using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace Stockontroll.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public int Tipo { get; set; }
    }
}