using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CACS.Plugin.ExtjsUI.WebSite
{
    public class AddInAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "ExtjsUI"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "CACS.Plugin.ExtjsUI.WebSite",
                "ExtjsUI/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "CACS.Plugin.ExtjsUI.WebSite.Controllers" });
        }
    }
}