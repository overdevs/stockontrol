using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace Stockontroll.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public enum Tipo { Administrador, Funcionario }
    }
}