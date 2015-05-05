using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Threading;
using System.Globalization;

namespace ProjectManagement.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Account/Login.cshtml"
            };
            filterContext.ExceptionHandled = true;
            base.OnException(filterContext);
        }

    }
}
