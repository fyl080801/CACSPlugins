using CACS.Framework.Mvc.Controllers;
using CACS.Framework.Profiles;
using CACS.Plugin.ExtjsUI.Framework;
using CACS.Plugin.ExtjsUI.WebSite.Models;
using CACSLibrary.Plugin;
using CACSLibrary.Profile;
using System.Linq;
using System.Web.Mvc;

namespace CACS.Plugin.ExtjsUI.WebSite.Controllers
{
    public class HomeController : CACSController
    {
        IProfileManager _profileManager;
        IPluginFinder _pluginFinder;

        public HomeController(
            IProfileManager profileManager,
            IPluginFinder pluginFinder)
        {
            _profileManager = profileManager;
            _pluginFinder = pluginFinder;
        }

        public ActionResult Index()
        {
            var globalSettings = _profileManager.Get<GlobalSettings>();
            var pluginDescription = _pluginFinder.GetPluginDescriptorById(Plugin.SYSTEM_ID);
            ExtjsUIModel model = new ExtjsUIModel();
            model.Title = globalSettings.SiteTitle;
            model.UIPath = pluginDescription.PluginPath.Replace(Server.MapPath("/"), "~/").Replace("\\", "/");
            var paths = HttpContext.Request.IsLocal ? UITable.Table.Where(e => e.IsDebug == true).ToArray() : UITable.Table.Where(e => e.IsDebug == false).ToArray();
            foreach (UIPath path in paths)
            {
                model.Paths.Add(path.Path);
            }
            return View("CACS.Plugin.ExtjsUI.WebSite.Views.Home.Index", model);
        }
    }
}