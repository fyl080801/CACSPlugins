using CACS.Plugin.Enterprise.Domain;
using CACSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.Enterprise.Interfaces
{
    public interface IPersonalService
    {
        IPagedList<Personal> GetAllPersonal(
            DateTime? createFrom,
            DateTime? createTo,
            DateTime? joiningFrom,
            DateTime? joiningTo,
            int? departmentId,
            int? positionId,
            string keyword,
            string personalName,
            PersonalStatus? status,
            int pageIndex,
            int pageSize,
            IDictionary<string, bool> order);

        Personal GetPersonalById(int id);

        void CreatePersonal(Personal domain);

        void UpdatePersonal(Personal domain);

        void DeletePersonal(int id);
    }
}
