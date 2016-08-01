using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CACSLibrary.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CACS.Plugin.Enterprise.Domain
{
    [Table("ent_Department")]
    public class Department : BaseEntity
    {
        public Department()
        {
            this.Children = new HashSet<Department>();
        }

        [MaxLength(20)]
        public virtual string DepartmentName { get; set; }

        [MaxLength(20)]
        public virtual string SortName { get; set; }

        public virtual string Remark { get; set; }

        public virtual ICollection<Department> Children { get; set; }

        public int? ParentId { get; set; }

        public virtual Department Parent { get; set; }

        [NotMapped]
        public virtual bool HaveChildren { get; set; }
    }
}
