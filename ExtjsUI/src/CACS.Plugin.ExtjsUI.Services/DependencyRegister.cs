using CACS.Plugin.ExtjsUI.Interfaces;
using CACSLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.ExtjsUI.Services
{
    public class DependencyRegister : IDependencyRegister
    {
        public EngineLevels Level
        {
            get { return EngineLevels.Normal; }
        }

        public void Register(IContainerManager containerManager, ITypeFinder typeFinder)
        {
            containerManager.RegisterComponent<IUIService, UIService>(typeof(UIService).FullName, ComponentLifeStyle.LifetimeScope);
        }
    }
}
