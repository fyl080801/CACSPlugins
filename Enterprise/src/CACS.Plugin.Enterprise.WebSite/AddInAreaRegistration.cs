using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CACS.Plugin.Enterprise.WebSite
{
    public class AddInAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Enterprise"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "CACS.Plugin.Enterprise.WebSite",
                "Enterprise/{controller}/{action}/{id}",
                new { action = "List", id = UrlParameter.Optional },
                new[] { "CACS.Plugin.Enterprise.WebSite.Controllers" });
        }
    }
}