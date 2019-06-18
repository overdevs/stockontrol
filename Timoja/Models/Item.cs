using Stockontroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace Stockontroll.Models
{
    public class Item
    {
        public Produto produto { get; set; }

        public int quantidade { get; set; }
    }
}