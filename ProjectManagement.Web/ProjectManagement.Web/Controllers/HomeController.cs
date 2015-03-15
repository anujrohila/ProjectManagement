using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ProjectManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var strConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ProjectManagementEntities1"].ConnectionString;
            strConnectionString = strConnectionString.Insert(strConnectionString.IndexOf("catalog=") + 8, "123456");
            strConnectionString = strConnectionString.Insert(strConnectionString.IndexOf("user id=") + 8, "98745612");
            strConnectionString = strConnectionString.Insert(strConnectionString.IndexOf("password=") + 9, "pass");
            System.Web.HttpContext.Current.Session["LoggedProjectConnectionString"] = strConnectionString;

            //var configuration = WebConfigurationManager.OpenWebConfiguration("~");
            //var section = (ConnectionStringsSection)configuration.GetSection("connectionStrings");
            //section.ConnectionStrings["ProjectManagementEntities1"].ConnectionString = strConnectionString;
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
