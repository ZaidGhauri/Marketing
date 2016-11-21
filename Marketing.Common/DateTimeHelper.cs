using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marketing.Common
{
    public static class DateTimeHelper
    {
        public static DateTime Now()
        {
            return DateTime.UtcNow.Date;
        }
    }
}
