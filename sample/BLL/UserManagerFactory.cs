using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BLL;
using BLLFactory;

namespace BLL
{
    public class UserManagerFactory
    {
        IUsermanager usermng = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IUsermanager CreateUserManager()
        {
            if (usermng == null)
            {
                usermng = new UserManager();
            }
            return usermng;
        }
    }
}
