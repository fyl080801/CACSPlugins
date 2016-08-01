using CACSLibrary;
using CACSLibrary.Component;
using CACSLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CACS.Plugin.ExtjsUI.Framework
{
    public static class UITable
    {
        static readonly ReaderWriterLockSlim _locker = new ReaderWriterLockSlim();

        public static UICollection Table
        {
            get
            {
                if (Singleton<UICollection>.IsInstanceNull)
                {
                    using (new WriteLocker(UITable._locker))
                    {
                        if (Singleton<UICollection>.IsInstanceNull)
                        {
                            Singleton<UICollection>.Instance = new UICollection();
                        }
                    }
                }
                if (Singleton<UICollection>.IsInstanceNull)
                {
                    throw new CACSException("无法初始化脚本注册类");
                }
                return Singleton<UICollection>.Instance;
            }
        }
    }
}
