using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IUsermanager
    {
        SortedList<string, IUser> UserList { get; set; }
        int CheckUser(string uname, string pass);
        int ChangePwd(string userName, string password);
        int AddUser(string userName, string password, int status);
    }
}
