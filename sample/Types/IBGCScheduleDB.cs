using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCScheduleDB
    {
        int AddBGCSchedule(IBGCTestSchedule schedule);
        SortedList<int, IBGCTestSchedule> GetScheduleList();
    }
}
