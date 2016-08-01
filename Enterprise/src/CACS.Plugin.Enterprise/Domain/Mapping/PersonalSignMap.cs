using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.Enterprise.Domain.Mapping
{
    public class PersonalSignMap : EntityTypeConfiguration<PersonalSign>
    {
        public PersonalSignMap()
        {
            this.HasKey(e => e.Id);
            this.HasRequired(m => m.User)
                .WithRequiredDependent()
                .WillCascadeOnDelete(true);
        }
    }
}
