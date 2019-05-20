using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stockontrol.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Estoque()
        {
            ViewBag.Message = "Estoque page";

            return View();
        }

        public ActionResult Funcionarios()
        {
            ViewBag.Message = "Funcionarios page";

            return View();
        }

        public ActionResult Fornecedores()
        {
            ViewBag.Message = "Fornecedores page";

            return View();
        }
    }
}