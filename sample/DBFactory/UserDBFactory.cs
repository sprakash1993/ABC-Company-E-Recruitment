using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DBFactory
{
    public class UserDBFactory
    {
        IUserDB userdb = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IUserDB CreateUserDB()
        {
            if(userdb == null)
            {
              userdb = new UserDB();
            }
            return userdb;
        }
    }
}
