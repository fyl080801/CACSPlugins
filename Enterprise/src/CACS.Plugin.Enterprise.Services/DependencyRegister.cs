using CACS.Plugin.Enterprise.Interfaces;
using CACS.Plugin.Enterprise.Services;
using CACSLibrary.Infrastructure;
using CACSLibrary.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CACS.Plugin.Enterprise
{
    public class DependencyRegister : PluginDependencyRegister
    {
        public override EngineLevels Level
        {
            get { return EngineLevels.High; }
        }

        public override string PluginId
        {
            get { return AddIn.SYSTEM_ID; }
        }

        protected override void PluginRegister(IContainerManager containerManager, ITypeFinder typeFinder)
        {
            containerManager.RegisterComponent<IPersonalService, PersonalService>(typeof(PersonalService).FullName, ComponentLifeStyle.LifetimeScope);
            containerManager.RegisterComponent<IDepartmentService, DepartmentService>(typeof(DepartmentService).FullName, ComponentLifeStyle.LifetimeScope);
        }
    }
}