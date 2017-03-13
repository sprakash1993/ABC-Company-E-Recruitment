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
    public class CandidateProfileManagerFactory
    {
        ICandidateProfileManager cpmgr = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICandidateProfileManager CreateCandidateProfileManager()
        {
            if (cpmgr == null)
            {
                cpmgr = new CandidateProfileManager();
            }
            return cpmgr;

        }
    }
}
