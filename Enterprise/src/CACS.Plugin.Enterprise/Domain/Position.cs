using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CACSLibrary.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CACS.Plugin.Enterprise.Domain
{
    [Table("ent_Position")]
    public class Position : BaseEntity
    {
        [MaxLength(20), Required]
        public virtual string PositionName { get; set; }

        public virtual string Remark { get; set; }
    }
}