using CACS.Plugin.ExtjsUI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.ExtjsUI.Interfaces
{
    public interface IUIService
    {
        ICollection<ViewSetting> GetTabs();

        void SaveTabs(ViewSetting[] settings);
    }
}
