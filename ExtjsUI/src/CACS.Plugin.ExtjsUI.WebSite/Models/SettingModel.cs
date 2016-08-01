using CACS.Framework.Mvc;
using CACS.Plugin.ExtjsUI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CACS.Plugin.ExtjsUI.WebSite.Models
{
    public class SettingModel : BaseModel
    {
        public ICollection<ViewSetting> ViewSettings { get; set; } = new HashSet<ViewSetting>();
    }
}