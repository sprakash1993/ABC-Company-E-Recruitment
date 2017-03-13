using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface ICandidateProfileManager
    {
        SortedList<int, ICandidateProfile> GetCandidateProfileList();
        int UpdateCandidateProfile(int candidateprofileId, bool teststatus);
        SortedList<int, ICandidateProfile> GetCandidateProfileList_VacancyId();
        SortedList<int, ICandidateProfile> GetCandidateProfileList_TestStatus();
        int UpdateCandidateProfile1(int candidateprofileId, int teststatus);
    }
}
