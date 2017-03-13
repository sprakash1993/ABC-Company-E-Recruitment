using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface ICandidateProfileDB
    {
        SortedList<int, ICandidateProfile> GetCandidateProfileList();
        SortedList<int, ICandidateProfile> GetCandidateProfileList_VacancyId();
        SortedList<int, ICandidateProfile> GetCandidateProfileList_TestStatus();
        int UpdateCandidateProfile(int candidateprofileId, bool bgctests);
        int UpdateCandidateProfile1(int candidateprofileId, int teststatus);
    }
}
