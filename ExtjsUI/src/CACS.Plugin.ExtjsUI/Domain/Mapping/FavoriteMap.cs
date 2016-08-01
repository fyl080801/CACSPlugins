using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CACS.Plugin.ExtjsUI.Domain.Mapping
{
    public class FavoriteMap : EntityTypeConfiguration<Favorite>
    {
        public FavoriteMap()
        {
            HasKey(e => e.Id);
        }
    }
}