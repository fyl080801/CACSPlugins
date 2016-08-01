using CACS.Framework.Mvc.Controllers;
using CACS.Framework.Mvc.Filters;
using CACS.Plugin.Enterprise.Interfaces;
using CACS.Plugin.Enterprise.WebSite.Models;
using CACSLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CACS.Plugin.Enterprise.WebSite.Controllers
{
    public class DepartmentController : CACSController
    {
        IDepartmentService _departmentService;

        public DepartmentController()
        {
            _departmentService = EngineContext.Current.Resolve<IDepartmentService>();
        }

        [AccountTicket]
        public ActionResult List()
        {
            var list = _departmentService.GetAllDepartment(false);
            return JsonList<DepartmentModel>(list.Select(DepartmentModel.Prepare).ToArray());
        }

        public ActionResult ChildList(int? id)
        {
            var list = _departmentService.GetChildDepartments(id);
            return JsonList<DepartmentModel>(list.Select(DepartmentModel.Prepare).ToArray());
        }
    }
}