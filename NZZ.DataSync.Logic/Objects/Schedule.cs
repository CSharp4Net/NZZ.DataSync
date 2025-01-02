using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic.Objects
{
    public class Schedule
    {
        public Schedule()
        {
            WeekdaysToSync = new List<DayOfWeek>();
        }

        public DateTime TimeToSync = DateTime.MinValue;

        public List<DayOfWeek> WeekdaysToSync = null;
    }
}