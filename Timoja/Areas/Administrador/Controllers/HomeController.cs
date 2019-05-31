using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Timoja.Areas.Administrador.Controllers
{
    public class HomeController : Controller
    {
        // GET: Administrador/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}