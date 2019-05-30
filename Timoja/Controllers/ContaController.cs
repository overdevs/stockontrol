using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Timoja.Controllers
{
    public class ContaController : Controller
    {
        
        public ActionResult MinhaConta()
        {
            return View();
        }
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}