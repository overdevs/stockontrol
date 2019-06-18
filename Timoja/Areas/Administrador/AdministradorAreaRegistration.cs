using System.Web.Mvc;

namespace Timoja.Areas.Administrador
{
    public class AdministradorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administrador";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administrador_default",
                "Administrador/{controller}/{action}/{id}",
                new { controller = "Login", action = "Index", id = UrlParameter.Optional },
                namespaces: new []{ "Timoja.Areas.Administrador.Controllers"}
            );
        }
    }
}