﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.Log
{
    public static class Logger
    {
        public static NLog.Logger Servicelog = LogManager.GetCurrentClassLogger();
    }
}
