using CACS.Plugin.Enterprise.Domain;
using CACS.Plugin.Enterprise.Interfaces;
using CACSLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.Enterprise.Services
{
    public class DepartmentService : IDepartmentService
    {
        IRepository<Department> _departmentRepository;

        public DepartmentService(IRepository<Department> departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IList<Department> GetAllDepartment(bool isRoot)
        {
            var query = _departmentRepository.Table;
            if (isRoot)
                query = query.Where(m => !m.ParentId.HasValue);
            return query.ToList();
        }

        public IList<Department> GetChildDepartments(int? id)
        {
            var query = _departmentRepository.Table
                .Where(e => e.ParentId == id)
                .Select(e => new
                {
                    DepartmentName = e.DepartmentName,
                    HaveChildren = e.Children.Count > 0,
                    Id = e.Id,
                    ParentId = e.ParentId,
                    Remark = e.Remark,
                    SortName = e.SortName
                });
            return query.ToList().Select(e => new Department()
            {
                DepartmentName = e.DepartmentName,
                HaveChildren = e.HaveChildren,
                Id = e.Id,
                ParentId = e.ParentId,
                Remark = e.Remark,
                SortName = e.SortName
            }).ToList();
        }

        public Department GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddDepartment(Department department)
        {
            _departmentRepository.Insert(department);
        }

        public void UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartmentById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
