using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCTestSchedule
    {
        int BGCId { get; set; }
        int AdministratorId { get; set; }
        DateTime FromDate { get; set; }
        DateTime ToDate { get; set; }

    }
}
