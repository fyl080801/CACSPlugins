using CACS.Framework.Domain;
using CACS.Framework.Mvc.Controllers;
using CACS.Framework.Mvc.Filters;
using CACS.Plugin.Enterprise.Domain;
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
    public class PersonalController : CACSController
    {
        IPersonalService _personalService;

        public PersonalController()
        {
            _personalService = EngineContext.Current.Resolve<IPersonalService>();
        }

        [AccountTicket(AuthorizeId = "/User/List")]
        public ActionResult List(PersonalListModel model, int limit, int page, string sort, string dir)
        {
            IDictionary<string, bool> dic = new Dictionary<string, bool>();
            if (!string.IsNullOrEmpty(sort) && !string.IsNullOrEmpty(dir))
            {
                dic.Add(sort, dir == "ASC" ? true : false);
            }
            var list = _personalService.GetAllPersonal(
                null,
                null,
                null,
                null,
                null,
                null,
                model.SeachKeyword,
                null,
                null,
                page - 1,
                limit,
                dic);
            return JsonList<PersonalModel>(list.Select(PersonalModel.PrepareModel).ToArray(), list.TotalCount);
        }

        [AccountTicket(AuthorizeId = "/User/Create"), HttpPost]
        public ActionResult Create(PersonalModel model)
        {
            Personal domain = new Personal();
            domain.Birthday = model.Birthday;
            domain.DepartmentId = model.DepartmentId;
            domain.DepartureDate = model.DepartureDate;
            domain.JoiningDate = model.JoiningDate;
            domain.PersonalCard = model.PersonalCard;
            domain.PositionId = model.PositionId;
            domain.Sex = model.Sex;
            domain.Status = (PersonalStatus)model.Status;
            domain.User = new User()
            {
                //Username = model.Username,
                //PersonalName = model.PersonalName,
                Email = model.Email
            };
            _personalService.CreatePersonal(domain);
            return Json(domain.Id);
        }

        [AccountTicket(AuthorizeId = "/User/Update"), HttpPost]
        public ActionResult Update(PersonalModel model)
        {
            var domain = _personalService.GetPersonalById(int.Parse(model.Id.ToString()));
            domain.Birthday = model.Birthday;
            domain.DepartmentId = model.DepartmentId;
            domain.DepartureDate = model.DepartureDate;
            domain.JoiningDate = model.JoiningDate;
            domain.PersonalCard = model.PersonalCard;
            domain.PositionId = model.PositionId;
            domain.Sex = model.Sex;
            domain.Status = (PersonalStatus)model.Status;
            //domain.User.Username = model.Username;
            //domain.User.PersonalName = model.PersonalName;
            domain.User.Email = model.Email;
            _personalService.UpdatePersonal(domain);
            return Json(model.Id);
        }

        [AccountTicket, HttpGet]
        public ActionResult Details(int id)
        {
            var domain = _personalService.GetPersonalById(id);
            return Json(PersonalModel.PrepareModel(domain));
        }
    }
}