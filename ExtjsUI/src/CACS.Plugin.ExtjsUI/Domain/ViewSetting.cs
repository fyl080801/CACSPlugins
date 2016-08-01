using CACS.Framework.Domain;
using CACSLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACS.Plugin.ExtjsUI.Domain
{
    [Table("extui_ViewSetting")]
    public class ViewSetting : BaseEntity, ICloneable
    {
        [MaxLength(128), Required]
        public virtual string Action { get; set; }

        [MaxLength(128), Required]
        public virtual string ViewType { get; set; }

        [MaxLength(128), Required]
        public virtual string Component { get; set; }

        [MaxLength(128), Required]
        public virtual string FrameId { get; set; }

        public virtual int Order { get; set; }

        public virtual string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public object Clone()
        {
            return new ViewSetting()
            {
                Action = Action,
                Component = Component,
                Id = Id,
                FrameId = FrameId,
                Order = Order,
                ViewType = ViewType,
                UserId = UserId
            };
        }
    }
}
