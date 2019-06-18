using Stockontroll.DAO;
using Stockontroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Timoja.Areas.Administrador.Controllers
{
    public class LoginController : Controller
    {
        
        private StockontrolContext db = new StockontrolContext();
        
        // GET: Administrador/Login
        public ActionResult Index()
        {
            if (Session["admin"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Email, Senha")] Usuario usuario)
        {
            // Se o formato do objeto estiver correto.
            if (ModelState.IsValid)
            {
                // Pegando o resultado do login.
                List<Usuario> resultQuery = db.Usuarios.ToList().FindAll(u => (u.Email == usuario.Email) && (u.Senha == usuario.Senha));

                if (resultQuery.Count == 1)
                {
                    /// ILL UPDATE FROM HERE.
                    Session["admin"] = resultQuery[0];

                    // Se for um user comum.
                    if (resultQuery[0].Tipo == 1)
                    {

                        Console.WriteLine("Administrador!");
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    TempData["error"] = "Ocorreu um erro ao entrar! Verifique se seus dados estão corretos.";
                }
            }
            return View(usuario);
        }

        public ActionResult Logout()
        {
            if (Session["admin"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            Session["admin"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}