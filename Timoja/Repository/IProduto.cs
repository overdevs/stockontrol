using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockontroll.Models;


namespace Stockontroll.Repository
{
    public interface IProduto
    {
        List<Produto> findAll();
        Produto find(int id);
        List<Produto> search(String search);
    }
}
