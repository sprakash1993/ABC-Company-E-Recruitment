using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BO;

namespace BOFactory
{
    public class CandidateProfileFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICandidateProfile CreateCandidateProfile()
        {
            ICandidateProfile candidateprofile = new CandidateProfile();
            return candidateprofile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateprofileId"></param>
        /// <param name="bgcteststatus"></param>
        /// <returns></returns>

        public ICandidateProfile CreateCandidateProfile(int candidateprofileId, bool bgcteststatus)
        {
            ICandidateProfile candidateprofile = new CandidateProfile();
            candidateprofile.CandidateProfileID = candidateprofileId;
            candidateprofile.BgcTestStatus = bgcteststatus;
            return candidateprofile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateprofileId"></param>
        /// <param name="vacancyId"></param>
        /// <returns></returns>
        public ICandidateProfile CreateCandidateProfile(int candidateprofileId, int vacancyId)
        {
            ICandidateProfile candidateprofile = new CandidateProfile();
            candidateprofile.CandidateProfileID = candidateprofileId;
            candidateprofile.VacancyID = vacancyId;
            return candidateprofile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateprofileId"></param>
        /// <param name="teststatus"></param>
        /// <returns></returns>
        public ICandidateProfile CreateCandidateProfile1(int candidateprofileId, int teststatus)
        {
            ICandidateProfile candidateprofile = new CandidateProfile();
            candidateprofile.CandidateProfileID = candidateprofileId;
            candidateprofile.TestStatus = teststatus;
            return candidateprofile;
        }
    }
}
