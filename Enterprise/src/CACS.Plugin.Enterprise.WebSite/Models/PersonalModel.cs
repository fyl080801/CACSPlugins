using CACS.Framework.Mvc;
using CACS.Plugin.Enterprise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CACS.Plugin.Enterprise.WebSite.Models
{
    public class PersonalModel : BaseEntityModel
    {
        public Guid UserGuid { get; set; }

        public string Username { get; set; }

        public string PersonalName { get; set; }

        public string Email { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public string LastIpAddress { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public int UserType { get; set; }

        //personal
        public int Status { get; set; }

        public bool? Sex { get; set; }

        public string PersonalCard { get; set; }

        public DateTime? Birthday { get; set; }

        public DateTime? JoiningDate { get; set; }

        public DateTime? DepartureDate { get; set; }

        public int? PositionId { get; set; }

        public string PositionName { get; set; }

        public int? DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public static PersonalModel PrepareModel(Personal domain)
        {
            return new PersonalModel()
            {
                //user
                //Active = domain.User.Active,
                //CreateTime = domain.User.CreateTime,
                //Deleted = domain.User.Deleted,
                //Email = domain.User.Email,
                //LastIpAddress = domain.User.LastIpAddress,
                //LastLoginTime = domain.User.LastLoginTime,
                //PersonalName = domain.User.PersonalName,
                //Username = domain.User.Username,
                //UserType = (int)domain.User.UserType,
                //UserGuid = domain.User.UserGuid,
                //personal
                Birthday = domain.Birthday,
                DepartmentId = domain.DepartmentId,
                DepartmentName = domain.Department == null ? "" : domain.Department.DepartmentName,
                DepartureDate = domain.DepartureDate,
                Id = domain.Id,
                JoiningDate = domain.JoiningDate,
                PersonalCard = domain.PersonalCard,
                PositionId = domain.PositionId,
                PositionName = domain.Position == null ? "" : domain.Position.PositionName,
                Sex = domain.Sex,
                Status = (int)domain.Status
            };
        }
    }
}