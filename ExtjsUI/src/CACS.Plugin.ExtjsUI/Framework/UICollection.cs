using CACSLibrary;
using CACSLibrary.Component;
using CACSLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Web;

namespace CACS.Plugin.ExtjsUI.Framework
{
    public sealed class UICollection : IEnumerable<UIPath>
    {
        ICollection<UIPath> _paths;

        public UICollection()
        {
            _paths = new HashSet<UIPath>();
        }

        public IEnumerator<UIPath> GetEnumerator()
        {
            return _paths.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _paths.GetEnumerator();
        }

        public void Add(UIPath path)
        {
            _paths.Add(path);
        }
    }
}
