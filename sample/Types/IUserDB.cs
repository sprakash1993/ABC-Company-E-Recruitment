using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IUserDB
    {
        int CheckUser(string uname, string pass,SortedList<string, IUser> userList);
        SortedList<string, IUser> GetList();
        int ChangePwd(string username, string password);
        int AddUser(string userName, string password, int status);
    }
}
