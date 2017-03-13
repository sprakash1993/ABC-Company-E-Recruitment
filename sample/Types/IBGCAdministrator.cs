using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCAdministrator:IEmployee
    {
        int AdministratorID { get; set; }
        int Status{ get; set;}
        DateTime StatusChangeTime { get; set; }
   

    }
}
