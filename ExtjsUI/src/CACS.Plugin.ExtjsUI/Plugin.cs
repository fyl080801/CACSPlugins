using CACS.Framework.Data;
using CACS.Framework.Plugin;
using CACS.Framework.Profiles;
using CACS.Plugin.ExtjsUI.Domain;
using CACSLibrary.Data;
using CACSLibrary.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.ExtjsUI
{
    public class Plugin : CACSWebPlugin
    {
        public const string SYSTEM_ID = "ExtjsUI";

        IDataSettingsManager _dbSettingManager;
        IProfileManager _profileManager;

        public Plugin(
            IDataSettingsManager dbSettingManager,
            IProfileManager profileManager)
        {
            _dbSettingManager = dbSettingManager;
            _profileManager = profileManager;
        }

        public override void Install()
        {
            base.Install();

            var globalSettings = _profileManager.Get<GlobalSettings>();
            globalSettings.IndexUrl = "~/ExtjsUI/Home/Index";
            _profileManager.Save(globalSettings);

            var setting = _dbSettingManager.LoadSettings();
            if (!setting.EntityMapAssmbly.Contains("CACS.Plugin.ExtjsUI"))
                setting.EntityMapAssmbly.Add("CACS.Plugin.ExtjsUI");
            _dbSettingManager.SaveSettings(setting);
        }

        public override void Uninstall()
        {
            base.Uninstall();

            var globalSettings = _profileManager.Get<GlobalSettings>();
            var defaultSettings = globalSettings.GetDefault() as GlobalSettings;

            globalSettings.IndexUrl = defaultSettings.IndexUrl;
            _profileManager.Save(globalSettings);

            var setting = _dbSettingManager.LoadSettings();
            setting.EntityMapAssmbly.Remove("CACS.Plugin.ExtjsUI");
            _dbSettingManager.SaveSettings(setting);
        }
    }
}
