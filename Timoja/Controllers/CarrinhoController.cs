using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stockontroll.Models;
using Stockontroll.DAO;
using System.Data.Entity;

namespace Timoja.Controllers
{
    public class CarrinhoController : Controller
    {
       StockontrolContext db = new StockontrolContext();
        // GET: Carrinho


        private int isExits(int id)
        {
            int retorno = -1;
            List<Item> carrinho = (List<Item>) Session["carrinho"];
            for (int i = 0; i < carrinho.Count; i++)
            {
                if (carrinho[i].produto.Id == id)
                {
                    retorno = i;
                }
            }
            return retorno;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar(int id)
        {
            if(Session["carrinho"] == null)
            {
                List<Item> carrinho = new List<Item>();
                carrinho.Add(new Item()
                {
                    produto = db.Produtos.ToList().Find(f => f.Id == id),
                    quantidade = 1
                });
                Session["carrinho"] = carrinho;
            }
            else
            {
                List<Item> carrinho = (List<Item>)Session["carrinho"];
                Produto prod = db.Produtos.ToList().Find(f => f.Id == id);

                int index = isExits(id);
                if(index == -1)
                {
                    carrinho.Add(new Item()
                    {
                        produto = prod,
                        quantidade = 1
                    });
                }
                else
                {
                    carrinho[index].quantidade += 1;
                }
                Session["carrinho"] = carrinho;
            }

            return RedirectToAction("Index","Carrinho");
        }

        public ActionResult Excluir(int id)
        {
            List<Item> carrinho = (List<Item>)Session["carrinho"];
            carrinho.RemoveAt(id);
            Session["carrinho"] = carrinho;

            return RedirectToAction("Index", "Carrinho");
        }
        public ActionResult Checkout()
        {
            List<Item> carrinho = (List<Item>)Session["carrinho"];

            foreach (var item in carrinho)
            {
                Produto p = db.Produtos.Find(item.produto.Id);
                if (p.Quantidade == item.quantidade)
                {
                    db.Produtos.Remove(p);
                    db.SaveChanges();
                }
                else if (p.Quantidade > item.quantidade)
                {
                    p.Quantidade -= item.quantidade;
                    db.Entry(p).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Session["carrinho"] = null;
            }

            return RedirectToAction("Index", "Home");
        }
    }
}