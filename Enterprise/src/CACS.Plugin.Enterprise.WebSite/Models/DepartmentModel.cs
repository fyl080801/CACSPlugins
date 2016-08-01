using CACS.Framework.Mvc;
using CACS.Plugin.Enterprise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CACS.Plugin.Enterprise.WebSite.Models
{
    public class DepartmentModel : BaseEntityModel
    {
        public string DepartmentName { get; set; }

        public int? ParentId { get; set; }

        public string SortName { get; set; }

        public string Remark { get; set; }

        public bool HaveChildren { get; set; }

        public static DepartmentModel Prepare(Department arg)
        {
            return new DepartmentModel()
            {
                DepartmentName = arg.DepartmentName,
                Id = arg.Id,
                ParentId = arg.ParentId,
                Remark = arg.Remark,
                HaveChildren = arg.HaveChildren
            };
        }
    }
}