using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Web
{
    public class CustomActionAutentication : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            string actionName = filterContext.RouteData.Values["action"].ToString();
            string verb = filterContext.HttpContext.Request.HttpMethod;
            //if (ApplicationMember.LoggedUserId > 0)
            //{
            //    var authenticationData = AuthenticationBusinessLogic.GetMemberAuthentication(ApplicationMember.LoggedUserId).Where(auth => string.Compare(auth.ControllerName, controllerName, StringComparison.CurrentCultureIgnoreCase) == 0 && string.Compare(auth.ActionName, actionName, StringComparison.CurrentCultureIgnoreCase) == 0);
            //    if (authenticationData.Count() == 0)
            //    {
            //        System.Web.HttpContext.Current.Session.Abandon();
            //        filterContext.Result = new HttpUnauthorizedResult();
            //    }
            //}
            //else
            //{
            //    System.Web.HttpContext.Current.Session.Abandon();
            //    filterContext.Result = new HttpUnauthorizedResult();
            //}
        }
    }

    public class CustomActionAutenticationMember : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            string actionName = filterContext.RouteData.Values["action"].ToString();
            string verb = filterContext.HttpContext.Request.HttpMethod;
            if (ApplicationMember.LoggedUserId == 0)
            {
                System.Web.HttpContext.Current.Session.Abandon();
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}