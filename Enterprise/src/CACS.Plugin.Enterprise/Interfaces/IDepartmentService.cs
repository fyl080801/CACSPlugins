using CACS.Plugin.Enterprise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.Enterprise.Interfaces
{
    public interface IDepartmentService
    {
        IList<Department> GetAllDepartment(bool isRoot);

        IList<Department> GetChildDepartments(int? id);

        Department GetDepartmentById(int id);

        void AddDepartment(Department department);

        void UpdateDepartment(Department department);

        void DeleteDepartmentById(int id);
    }
}
