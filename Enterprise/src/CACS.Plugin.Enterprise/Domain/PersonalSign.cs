using CACS.Framework.Domain;
using CACSLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.Enterprise.Domain
{
    [Table("ent_PersonalSign")]
    public class PersonalSign : BaseEntity<string>
    {
        [Column(TypeName = "image")]
        public virtual byte[] SignImage { get; set; }

        public virtual User User { get; set; }
    }
}
