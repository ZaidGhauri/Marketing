using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketing.Models
{
    public class SessionExpireAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            // check  sessions here
            if (HttpContext.Current.Session["UName"] == null)
            {
                filterContext.Result = new RedirectResult("~/User/Login");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}