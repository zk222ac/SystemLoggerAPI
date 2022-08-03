using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemLoggerAPI.Brokers.Datetimes
{
    public class DateTimeBroker : IDatetimeBroker
    {
        public DateTimeOffset GetCurrentDateTime() => DateTimeOffset.UtcNow;
            
    }
}
