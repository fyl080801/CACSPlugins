using CACS.Plugin.Enterprise.Domain;
using CACS.Plugin.Enterprise.Interfaces;
using CACSLibrary;
using CACSLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.Enterprise.Services
{
    public class PersonalService : IPersonalService
    {
        //readonly IRepository<Personal> _personalRepository;
        //readonly IRepository<User> _userRepository;
        //readonly IRepository<PersonalSign> _signRepository;
        //readonly IUserService _userService;

        //public PersonalService(
        //    IRepository<Personal> personalRepository,
        //    IRepository<User> userRepository,
        //    IRepository<PersonalSign> signRepository,
        //    IUserService userService)
        //{
        //    _personalRepository = personalRepository;
        //    _userRepository = userRepository;
        //    _signRepository = signRepository;
        //    _userService = userService;
        //}

        //public IPagedList<Personal> GetAllPersonal(
        //    DateTime? createFrom,
        //    DateTime? createTo,
        //    DateTime? joiningFrom,
        //    DateTime? joiningTo,
        //    int? departmentId,
        //    int? positionId,
        //    string keyword,
        //    string personalName,
        //    PersonalStatus? status,
        //    int pageIndex,
        //    int pageSize,
        //    IDictionary<string, bool> order)
        //{
        //    var query = from user in _userRepository.Table
        //                join personal in _personalRepository.Table on user.Id equals personal.Id into temp
        //                from tt in temp.DefaultIfEmpty()
        //                where user.Deleted == false
        //                select new
        //                {
        //                    User = user,
        //                    Birthday = tt != null ? tt.Birthday : new DateTime?(),
        //                    Department = tt != null ? tt.Department : null,
        //                    DepartmentId = tt != null ? tt.DepartmentId : new int?(),
        //                    DepartureDate = tt != null ? tt.DepartureDate : new DateTime?(),
        //                    Id = tt != null ? tt.Id : user.Id,
        //                    JoiningDate = tt != null ? tt.JoiningDate : new DateTime?(),
        //                    PersonalCard = tt != null ? tt.PersonalCard : string.Empty,
        //                    Position = tt != null ? tt.Position : null,
        //                    PositionId = tt != null ? tt.PositionId : new int?(),
        //                    Sex = tt != null ? tt.Sex : new bool?(true),
        //                    Status = tt != null ? tt.Status : PersonalStatus.Incumbency,
        //                };

        //    //query
        //    if (createFrom.HasValue)
        //        query = query.Where(c => createFrom.Value <= c.User.CreateTime);
        //    if (createTo.HasValue)
        //        query = query.Where(c => createTo.Value >= c.User.CreateTime);
        //    if (joiningFrom.HasValue)
        //        query = query.Where(c => joiningFrom.Value <= c.JoiningDate);
        //    if (joiningTo.HasValue)
        //        query = query.Where(c => joiningTo.Value >= c.JoiningDate);
        //    if (departmentId.HasValue)
        //        query = query.Where(c => departmentId == c.DepartmentId);
        //    if (positionId.HasValue)
        //        query = query.Where(c => positionId == c.PositionId);
        //    if (!string.IsNullOrWhiteSpace(personalName))
        //        query = query.Where(c => c.User.PersonalName.Contains(personalName));
        //    if (status.HasValue)
        //        query = query.Where(c => c.Status == status);
        //    if (!string.IsNullOrWhiteSpace(keyword))
        //        query = query.Where(c => c.User.Username.Contains(keyword) || c.User.PersonalName.Contains(keyword) || c.User.Email.Contains(keyword));
        //    //order
        //    if (order == null || order.Count == 0)
        //    {
        //        order = new Dictionary<string, bool>();
        //        order.Add("User.CreateTime", true);
        //    }
        //    foreach (var item in order)
        //    {
        //        string orderKey = item.Key;
        //        if (item.Key == "Username")
        //        {
        //            orderKey = "User.Username";
        //        }
        //        if (item.Key == "PersonalName")
        //        {
        //            orderKey = "User.PersonalName";
        //        }
        //        if (item.Key == "Email")
        //        {
        //            orderKey = "User.Email";
        //        }
        //        if (item.Key == "CreateTime")
        //        {
        //            orderKey = "User.CreateTime";
        //        }
        //        if (item.Key == "UserTypeId")
        //        {
        //            orderKey = "User.UserTypeId";
        //        }
        //        if (item.Key == "DepartmentName")
        //        {
        //            orderKey = "Department.DepartmentName";
        //        }
        //        if (item.Key == "PositionName")
        //        {
        //            orderKey = "Position.PositionName";
        //        }
        //        if (item.Key == "Active")
        //        {
        //            orderKey = "User.Active";
        //        }
        //        query = QueryBuilder.DataSorting(query, orderKey, item.Value);
        //    }
        //    var res = new PagedList<Personal>(query, pageIndex, pageSize);
        //    if (res == null)
        //    {
        //        res = new PagedList<Personal>(new List<Personal>(), pageIndex, pageSize);
        //    }
        //    return res;
        //}

        //public Personal GetPersonalById(int id)
        //{
        //    var personal = _personalRepository.GetById(id);
        //    if (personal == null)
        //    {
        //        var user = _userRepository.GetById(id);
        //        if (user == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return new Personal()
        //            {
        //                User = user,
        //                Id = user.Id,
        //                Status = PersonalStatus.Incumbency
        //            };
        //        }
        //    }
        //    else
        //    {
        //        return personal;
        //    }
        //}

        //public void CreatePersonal(Personal domain)
        //{
        //    var user = _userRepository.GetById(domain.User.Id);
        //    if (user == null)
        //    {
        //        domain.User.Password = domain.User.Username;
        //        domain.User.CreateTime = DateTime.Now;
        //        domain.User.Deleted = false;
        //        domain.User.UserType = UserTypes.Normal;
        //        domain.User.Active = true;
        //        _userService.SaveUser(domain.User);
        //    }
        //    else
        //    {
        //        domain.User = user;
        //    }
        //    _personalRepository.Insert(domain);
        //}

        //public void UpdatePersonal(Personal domain)
        //{
        //    var old = _personalRepository.GetById(domain.Id);
        //    if (old == null)
        //    {
        //        this.CreatePersonal(domain);
        //    }
        //    else
        //    {
        //        if (old.User.UserType == UserTypes.System)
        //            throw new CACSException("系统账户不能编辑");
        //        if (old.User.UserType == UserTypes.Supper && !old.User.Active)
        //            throw new CACSException("超级账户不能锁定");
        //        var query = from c in _userRepository.Table where c.Email == domain.User.Email && c.Id != domain.Id && c.UserType != UserTypes.System select c;
        //        if (query.Count(m => !m.Deleted) > 0)
        //            throw new IndexConstraintException("email");

        //        old.User.Email = domain.User.Email;
        //        old.User.PersonalName = domain.User.PersonalName;
        //        old.Birthday = domain.Birthday;
        //        old.DepartureDate = domain.DepartureDate;
        //        old.JoiningDate = domain.JoiningDate;
        //        old.PersonalCard = domain.PersonalCard;
        //        old.PositionId = domain.PositionId;
        //        old.DepartmentId = domain.DepartmentId;
        //        old.Sex = domain.Sex;

        //        _personalRepository.Update(old);
        //    }
        //}

        //public void DeletePersonal(int id)
        //{
        //    _userService.DeleteUser(_userService.GetUserById(id));
        //}

        public void CreatePersonal(Personal domain)
        {
            throw new NotImplementedException();
        }

        public void DeletePersonal(int id)
        {
            throw new NotImplementedException();
        }

        public IPagedList<Personal> GetAllPersonal(
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
            IDictionary<string, bool> order)
        {
            throw new NotImplementedException();
        }

        public Personal GetPersonalById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonal(Personal domain)
        {
            throw new NotImplementedException();
        }
    }
}
