using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Common.IocUtil
{
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class ServiceTagAttribute : Attribute
    {
        public Type IocType { get; set; }
    }
}
