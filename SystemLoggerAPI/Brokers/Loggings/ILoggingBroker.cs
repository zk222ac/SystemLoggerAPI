﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemLoggerAPI.Brokers.Loggings
{
   public interface ILoggingBroker
    {
        public void LogInformation(string message);
        public void LogTrace(string message);
        public void LogDebug(string message);
        public void LogWarning(string message);
        public void LogError(Exception exception);
        public void LogCritical(Exception exception);

    }
}
