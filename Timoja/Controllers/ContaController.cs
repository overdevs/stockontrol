
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Stockontroll.DAO;
using Stockontroll.Models;

namespace Timoja.Controllers
{
    public class ContaController : Controller
    {

        private StockontrolContext db = new StockontrolContext();

        public ActionResult MinhaConta()
        {
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Sair()
        {
            Session["usuario"] = null;
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro([Bind(Include = "Id,Nome,Sobrenome,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // Configurando como Usuário Cmomum
                usuario.Tipo = 0;
                
                if (db.Usuarios.ToList().FindAll(f => f.Email.Equals(usuario.Email, StringComparison.OrdinalIgnoreCase)).Count == 0)
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Cadastro");
                }

                
            }

            return View(usuario);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Email, Senha")] Usuario usuario)
        {
            // Se o formato do objeto estiver correto.
            if (ModelState.IsValid)
            {
                // Pegando o resultado do login.
                List<Usuario> resultQuery = db.Usuarios.ToList().FindAll(u => (u.Email == usuario.Email) && (u.Senha == usuario.Senha));
                
                if (resultQuery.Count == 1)
                {
                    /// ILL UPDATE FROM HERE.
                    Session["usuario"] = resultQuery[0];

                    Console.WriteLine("User comum!");

                    // Criando o carrinho.
                    List<Item> listaCarrinho = new List<Item>();
                    Session["carrinho"] = listaCarrinho;

                    return RedirectToAction("Index", "Home");
                    
                }
                else
                {
                    TempData["error"] = "Ocorreu um erro ao entrar! Verifique se seus dados estão corretos.";
                }
            }
            return View(usuario);
        }
    }
}