using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCScheduleManager
    {
        SortedList<int, IBGCTestSchedule> BGCScheduleList{get;set;}
        int AddBGCSchedule(DateTime fromdate, DateTime toDate, int adminID);
        SortedList<int, IBGCTestSchedule> GetScheduleList();
    }
}
