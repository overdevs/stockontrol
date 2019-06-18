using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stockontroll.DAO;
using Stockontroll.Models;
using Stockontroll.Repository;

namespace Timoja.Controllers
{
    public class HomeController : Controller
    {
        private IProduto prod = new ProdutoRepository();
        private StockontrolContext db = new StockontrolContext();
        
        // GET: Home
        public ActionResult Index()
        {
            return View(prod.findAll());
        }

        public ActionResult Pesquisa()
        {
            return View(prod.findAll());
        }

        public ActionResult Produto(int id)
        {
            return View(prod.find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pesquisa([Bind(Include = "Nome")] Produto produto)
        {
            return View(prod.search(produto.Nome));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}