using CACS.Framework.Domain;
using CACSLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CACS.Plugin.Enterprise.Domain
{
    [Table("ent_Personal")]
    public class Personal : BaseEntity<String>
    {
        public virtual PersonalStatus Status { get; set; }

        public virtual bool? Sex { get; set; }

        [MaxLength(50)]
        public virtual string PersonalCard { get; set; }

        public virtual DateTime? Birthday { get; set; }

        public virtual DateTime? JoiningDate { get; set; }

        public virtual DateTime? DepartureDate { get; set; }

        public virtual int? PositionId { get; set; }

        public virtual int? DepartmentId { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }

    public enum PersonalStatus
    {
        /// <summary>
        /// 在职
        /// </summary>
        Incumbency = 0,

        /// <summary>
        /// 休假
        /// </summary>
        Furlough = 1,

        /// <summary>
        /// 离职
        /// </summary>
        Dimission = 2
    }
}
