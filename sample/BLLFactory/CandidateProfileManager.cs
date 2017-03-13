using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BOFactory;
using DBFactory;

namespace BLLFactory
{
    public class CandidateProfileManager : ICandidateProfileManager
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<int, ICandidateProfile> GetCandidateProfileList()
        {
            ICandidateProfileDB edb = new CandidateProfileDBFactory().CreateCandidateProfileDB();
            return (edb.GetCandidateProfileList());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateprofileId"></param>
        /// <param name="teststatus"></param>
        /// <returns></returns>
        public int UpdateCandidateProfile(int candidateprofileId, bool teststatus)
        {
            ICandidateProfileDB edb = new CandidateProfileDBFactory().CreateCandidateProfileDB();
            return (edb.UpdateCandidateProfile(candidateprofileId, teststatus));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<int, ICandidateProfile> GetCandidateProfileList_VacancyId()
        {
            ICandidateProfileDB edb = new CandidateProfileDBFactory().CreateCandidateProfileDB();
            return (edb.GetCandidateProfileList_VacancyId());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<int, ICandidateProfile> GetCandidateProfileList_TestStatus()
        {
            ICandidateProfileDB edb = new CandidateProfileDBFactory().CreateCandidateProfileDB();
            return (edb.GetCandidateProfileList_TestStatus());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateprofileId"></param>
        /// <param name="teststatus"></param>
        /// <returns></returns>
        public int UpdateCandidateProfile1(int candidateprofileId, int teststatus)
        {
            ICandidateProfileDB edb = new CandidateProfileDBFactory().CreateCandidateProfileDB();
            return (edb.UpdateCandidateProfile1(candidateprofileId, teststatus));
        }
    }
}
