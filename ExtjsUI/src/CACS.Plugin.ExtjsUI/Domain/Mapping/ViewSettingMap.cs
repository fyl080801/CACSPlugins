using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.ExtjsUI.Domain.Mapping
{
    public class ViewSettingMap : EntityTypeConfiguration<ViewSetting>
    {
        public ViewSettingMap()
        {
            HasKey(e => e.Id);
        }
    }
}
