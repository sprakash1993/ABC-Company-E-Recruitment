using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class BGCAdministrator : Employee, IBGCAdministrator
    {
        int administratorID, status;
        DateTime statusChangeTime;

        public int AdministratorID
        {
            get { return administratorID; }
            set { administratorID = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Status1
        {
            get
            {
                if (status == 0) return "Awaiting Approval";
                else if (status == 1) return "Approved";
                else if (status == 2) return "On Leave";
                else return null;
            }
            set
            {
                if (value == "Approved") status = 1;
                else if (value == "Awaiting Approval") status = 0;
                else if (value == "On Leave") status = 2;
            }
        }
      
        public DateTime StatusChangeTime
        {
            get { return statusChangeTime; }
            set { statusChangeTime = value; }
        }

        


   
    }
}
