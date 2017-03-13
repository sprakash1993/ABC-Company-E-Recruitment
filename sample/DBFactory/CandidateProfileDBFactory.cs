using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DB;

namespace DBFactory
{
    public class CandidateProfileDBFactory
    {
        ICandidateProfileDB cpdb = null;
        public ICandidateProfileDB CreateCandidateProfileDB()
        {
            if (cpdb == null)
            {
                cpdb = new CandidateProfileDB();
            }
            return cpdb;
        }
    }
}
