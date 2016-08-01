using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CACS.Plugin.Enterprise.Domain.Mapping
{
    public class PersonalMap : EntityTypeConfiguration<Personal>
    {
        public PersonalMap()
        {
            this.HasKey(c => c.Id);
            this.HasRequired(m => m.User)
                .WithRequiredDependent()
                .WillCascadeOnDelete(true);
        }
    }
}
