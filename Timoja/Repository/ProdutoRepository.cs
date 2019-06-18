using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stockontroll.Models;
using Stockontroll.DAO;

namespace Stockontroll.Repository
{
    public class ProdutoRepository: IProduto
    {
        private StockontrolContext db = new StockontrolContext();

        public List<Produto> findAll()
        {
            return db.Produtos.ToList();
        }
        public Produto find(int id)
        {
            return db.Produtos.ToList().Find(p => p.Id == id);
        }

        public List<Produto> search(string search)
        {
            return db.Produtos.ToList().FindAll(p => p.Nome.ToLower().Contains(search.ToLower()));
        }
    }
}