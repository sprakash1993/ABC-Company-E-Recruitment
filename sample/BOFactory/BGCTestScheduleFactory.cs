using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BOFactory
{
    public class BGCTestScheduleFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="adminId"></param>
        /// <returns></returns>
        public IBGCTestSchedule CreateSchedule(DateTime fromDate, DateTime toDate, int adminId)
        {
            IBGCTestSchedule schedule = new BGCTestSchedule();
            schedule.AdministratorId = adminId;
            schedule.FromDate = fromDate;
            schedule.ToDate = toDate;
            return schedule;

        }
    }
}
