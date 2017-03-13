using DBFactory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BLLFactory 
{
    public class UserManager : IUsermanager
    {
        SortedList<string, IUser> users = new SortedList<string, IUser>();

      

        public SortedList<string, IUser> UserList
        {
            get { return users; }
            set { users = value; }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public int CheckUser(string uname, string pass)
        {
            IUserDB udb = new UserDBFactory().CreateUserDB();

            SortedList<string, IUser> uList = udb.GetList();
            int flag = udb.CheckUser(uname, pass, uList);

            return flag;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int ChangePwd(string userName, string password)
        {
            IUserDB udb = new UserDBFactory().CreateUserDB();

            int row = udb.ChangePwd(userName, password);
            return row;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public int AddUser(string userName, string password, int status)
        {
            IUserDB udb = new UserDBFactory().CreateUserDB();
            return(udb.AddUser(userName, password, status));
            

        }
    }
}
