using CACS.Framework.Data;
using CACS.Framework.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CACS.Plugin.Enterprise
{
    public class AddIn : CACSWebPlugin
    { 
        public const string SYSTEM_ID = "企业信息管理";

        IDataSettingsManager _dbSettingManager;

        public AddIn(IDataSettingsManager dbSettingManager)
        {
            _dbSettingManager = dbSettingManager;
        }

        public override void Install()
        {
            base.Install();
            InstallData();
        }

        public override void Uninstall()
        {
            base.Uninstall();
            UnInstallData();
        }

        private void InstallData()
        {
            var setting = _dbSettingManager.LoadSettings();
            if (!setting.EntityMapAssmbly.Contains("CACS.Plugin.Enterprise"))
                setting.EntityMapAssmbly.Add("CACS.Plugin.Enterprise");
            _dbSettingManager.SaveSettings(setting);
        }

        private void UnInstallData()
        {
            var setting = _dbSettingManager.LoadSettings();
            setting.EntityMapAssmbly.Remove("CACS.Plugin.Enterprise");
            _dbSettingManager.SaveSettings(setting);
        }
    }
}