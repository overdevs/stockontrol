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
    }
    public class UsuarioDBContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }

}