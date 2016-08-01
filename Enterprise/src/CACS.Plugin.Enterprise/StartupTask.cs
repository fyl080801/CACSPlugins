using CACS.Plugin.ExtjsUI.Framework;
using CACSLibrary.Infrastructure;
using CACSLibrary.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CACS.Plugin.Enterprise
{
    public class StartupTask : IStartupTask
    {
        IPluginFinder _pluginFinder;
        HttpContextBase _httpContext;

        public StartupTask()
        {
            _pluginFinder = EngineContext.Current.Resolve<IPluginFinder>();
            _httpContext = EngineContext.Current.Resolve<HttpContextBase>();
        }

        public EngineLevels Level
        {
            get { return EngineLevels.Normal; }
        }

        public void Execute()
        {
            var pluginDescription = _pluginFinder.GetPluginDescriptorById(AddIn.SYSTEM_ID);
            if (pluginDescription.Installed)
            {
                var pluginPath = pluginDescription.PluginPath.Replace(_httpContext.Server.MapPath("/"), "~/").Replace("\\", "/");
                UITable.Table.Add(new UIPath()
                {
                    Path = pluginPath + "/cacs-plugin-enterprise.js"
                });
                UITable.Table.Add(new UIPath()
                {
                    IsDebug = true,
                    Path = pluginPath + "/cacs-plugin-enterprise-debug.js"
                });
            }
        }
    }
}
