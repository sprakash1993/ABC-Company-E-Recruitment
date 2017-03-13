using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BO;

namespace BOFactory
{
    public class UserFactory
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pass"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public IUser CreateUser(string uname, string pass,int status)
        {
            IUser user = new User();
            user.UserName = uname;
            user.Password = pass;
            user.Status = status;
            return user;
        }
    }
}
