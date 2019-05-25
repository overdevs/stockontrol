using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stockontrol.Models
{
    public class Administrador
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public long UsuarioID { get; set; }
    }
}