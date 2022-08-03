using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemLoggerAPI.Brokers.Datetimes
{
   public interface IDatetimeBroker
    {
        DateTimeOffset GetCurrentDateTime();
    }
}
