using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var str = System.Configuration.ConfigurationManager.ConnectionStrings["ProjectManagementEntities1"].ConnectionString;
            str = str.Replace("##CatalogName##", "");
            str = str.Replace("##UserName##", "");
            str = str.Replace("##Password##", "");
            //
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }


        public ActionResult About(int id)
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
