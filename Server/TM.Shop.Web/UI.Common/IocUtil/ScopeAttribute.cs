﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Common.IocUtil
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ScopeAttribute : ServiceTagAttribute
    {
        public ScopeAttribute()
        {
        }
    }
}
