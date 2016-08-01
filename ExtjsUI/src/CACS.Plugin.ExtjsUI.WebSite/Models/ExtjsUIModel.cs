using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CACS.Plugin.ExtjsUI.WebSite.Models
{
    public class ExtjsUIModel
    {
        public string Title { get; internal set; }

        public string UIPath { get; internal set; }

        public ICollection<string> Paths { get; internal set; } = new HashSet<string>();
    }
}