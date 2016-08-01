using CACS.Framework.Domain;
using CACSLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CACS.Plugin.ExtjsUI.Domain
{
    [Table("extui_Favorite")]
    public class Favorite : BaseEntity
    {
        [Required, MaxLength(50), DefaultValue("新链接")]
        public virtual string LinkName { get; set; }

        [MaxLength(255), Required]
        public virtual string Path { get; set; }

        [Required]
        public virtual string Icon { get; set; }

        [MaxLength(50)]
        public virtual string Group { get; set; }

        [Required]
        public virtual string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}