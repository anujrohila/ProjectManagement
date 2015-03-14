using ProjectManagement.Domain;
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
            string id = Convert.ToString(filterContext.RouteData.Values["id"]);
            string verb = filterContext.HttpContext.Request.HttpMethod;
            if (ApplicationMember.LoggedUserId > 0)
            {
                bool isPermitted = true;
                var permission = ApplicationMember.LoggedUserPermission.Where(p => string.Compare(p.ControllerName, controllerName, StringComparison.CurrentCultureIgnoreCase) == 0).FirstOrDefault();
                if (permission == null)
                {
                    isPermitted = false;
                }
                else if (string.Compare("ListAll", actionName, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    if (permission.CanListAll == false)
                    {
                        isPermitted = false;
                    }
                }
                else if (string.Compare("Save", actionName, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    if (Convert.ToInt32(id) == 0)
                    {
                        if (permission.CanInsert == false)
                        {
                            isPermitted = false;
                        }
                    }
                    else
                    {
                        if (permission.CanEdit == false)
                        {
                            isPermitted = false;
                        }
                    }
                }
                else if (string.Compare("Delete", actionName, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    if (permission.CanDelete == false)
                    {
                        isPermitted = false;
                    }
                }
                if (isPermitted == false)
                {
                    System.Web.HttpContext.Current.Session.Abandon();
                    filterContext.Result = new HttpUnauthorizedResult();
                }
            }
            else
            {
                System.Web.HttpContext.Current.Session.Abandon();
                filterContext.Result = new HttpUnauthorizedResult();
            }
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