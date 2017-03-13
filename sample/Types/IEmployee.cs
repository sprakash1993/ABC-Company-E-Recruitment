using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployee
    {
         int EmployeeId { get; set; }
         int UnitHeadID{ get; set; } 
         int ProjectID{ get; set; }
         string EmployeeName{ get; set; }
         string Gender{ get; set; }
         string Division{ get; set; }
         string Designation { get; set; }
         float CTC{ get; set; }
         DateTime DOB{ get; set; }
         DateTime DOJ{ get; set; }
         bool IsHR{ get; set; }
         bool IsNew { get; set; }
        
    }
}
