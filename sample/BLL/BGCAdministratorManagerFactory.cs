using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Types;
using BLLFactory;

namespace BLL
{
    public class BGCAdministratorManagerFactory
    {
        IBGCAdministratorManager adnmngr = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IBGCAdministratorManager CreateBGCAdministratorManager()
        {
            if (adnmngr == null)
            {
                adnmngr = new BGCAdministratorManager();
            }

            return adnmngr;
        }
    }
}
