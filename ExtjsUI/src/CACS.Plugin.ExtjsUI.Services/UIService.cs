using CACS.Framework.Identity;
using CACS.Framework.Mvc.Controllers;
using CACS.Framework.Profiles;
using CACS.Plugin.ExtjsUI.Domain;
using CACS.Plugin.ExtjsUI.Interfaces;
using CACSLibrary;
using CACSLibrary.Data;
using CACSLibrary.Profile;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CACS.Plugin.ExtjsUI.Services
{
    public class UIService : IUIService
    {
        HttpContextBase _httpContext;
        ApplicationUserManager _userManager;
        IRepository<ViewSetting> _tabRepository;

        public UIService(
            HttpContextBase httpContext,
            IRepository<ViewSetting> tabRepository)
        {
            _httpContext = httpContext;
            _userManager = httpContext.GetOwinContext().Get<ApplicationUserManager>();
            _tabRepository = tabRepository;
        }

        public ICollection<ViewSetting> GetTabs()
        {
            var user = _userManager.Users.FirstOrDefault(e => e.UserName == _httpContext.User.Identity.Name);
            if (user == null)
                return new HashSet<ViewSetting>();
            var usertabs = _tabRepository.Table.Where(e => e.UserId == user.Id).OrderBy(e => e.Order);
            return usertabs.ToArray();
        }

        public void SaveTabs(ViewSetting[] settings)
        {
            var user = _userManager.Users.FirstOrDefault(e => e.UserName == _httpContext.User.Identity.Name);
            if (user == null)
                return;

            var oldtabs = _tabRepository.Table.Where(e => e.UserId == user.Id);
            _tabRepository.Delete(oldtabs.ToArray());
            foreach (var setting in settings)
            {
                setting.UserId = user.Id;
            }
            _tabRepository.Insert(settings);
        }
    }
}
