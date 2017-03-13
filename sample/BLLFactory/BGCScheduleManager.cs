using BOFactory;
using DBFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BLLFactory
{
    public class BGCScheduleManager : IBGCScheduleManager
    {
        SortedList<int, IBGCTestSchedule> schedules = new SortedList<int, IBGCTestSchedule>();
        
        public SortedList<int, IBGCTestSchedule> BGCScheduleList
        {
            get { return schedules; }
            set { schedules = value; }
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="toDate"></param>
        /// <param name="adminID"></param>
        /// <returns></returns>
        public int AddBGCSchedule(DateTime fromdate, DateTime toDate, int adminID)
        {
            IBGCTestSchedule sch = new BGCTestScheduleFactory().CreateSchedule(fromdate, toDate, adminID);

            IBGCScheduleDB sdb = new BGCScheduleDBFactory().CreateBGCScheduleDB();
            return(sdb.AddBGCSchedule(sch));
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<int, IBGCTestSchedule> GetScheduleList()
        {
            IBGCScheduleDB sdb = new BGCScheduleDBFactory().CreateBGCScheduleDB();
            return(sdb.GetScheduleList());
        }
    }
}
