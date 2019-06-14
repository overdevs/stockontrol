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

namespace Timoja.Controllers
{
    public class HomeController : Controller
    {
        private StockontrolContext db = new StockontrolContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Produtos.ToList());
        }

        public ActionResult Pesquisa()
        {
            return View(db.Produtos.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pesquisa([Bind(Include = "Nome")] Produto produto)
        {
            List<Produto> produtos = db.Produtos.ToList();
            List<Produto> results = produtos.FindAll(p => p.Nome.Contains(produto.Nome));
            return View(results);
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