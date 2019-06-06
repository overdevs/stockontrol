
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro([Bind(Include = "Id,Email,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // Configurando como Usuário Cmomum
                usuario.Tipo = 0;
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
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
            if (ModelState.IsValid)
            {
                List<Usuario> resultQuery = db.Usuarios.ToList().FindAll(u => (u.Email == usuario.Email) && (u.Senha == usuario.Senha));
                if (resultQuery.Count == 1)
                {
                    Session["id"] = resultQuery[0].Id;
                    Session["email"] = resultQuery[0].Email;
                    Session["senha"] = resultQuery[0].Senha;
                    Session["tipo"] = resultQuery[0].Tipo;
                    Session["usuario"] = resultQuery[0];

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(usuario);
        }
    }
}