using CACS.Framework.Mvc.Controllers;
using CACS.Framework.Mvc.Filters;
using CACS.Plugin.ExtjsUI.Domain;
using CACS.Plugin.ExtjsUI.Interfaces;
using CACS.Plugin.ExtjsUI.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CACS.Plugin.ExtjsUI.WebSite.Controllers
{
    public class UIController : CACSController
    {
        IUIService _uiService;

        public UIController(IUIService uiService)
        {
            _uiService = uiService;
        }

        public ActionResult Logo()
        {
            return File(new byte[0], "image/jpg");
        }

        [AccountTicket]
        public ActionResult Settings()
        {
            SettingModel model = new SettingModel();
            model.ViewSettings = _uiService.GetTabs().Select(e => (ViewSetting)e.Clone()).ToArray();
            return Json(model);
        }

        [AccountTicket, HttpPost]
        public ActionResult SaveTabSettings(IList<ViewSetting> settings)
        {
            if (settings == null)
                settings = new ViewSetting[0];
            _uiService.SaveTabs(settings.ToArray());
            return Json(true);
        }
    }
}