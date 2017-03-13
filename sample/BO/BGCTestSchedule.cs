using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class BGCTestSchedule : IBGCTestSchedule
    {
        int bgcId, administratorId;
        DateTime fromDate, toDate;

        public int BGCId
        {
            get { return bgcId; }
            set { bgcId = value; }
        }

        public int AdministratorId
        {
            get { return administratorId; }
            set { administratorId = value; }
        }

        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
    }
}
