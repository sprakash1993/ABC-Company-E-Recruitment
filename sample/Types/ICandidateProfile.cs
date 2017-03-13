using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface ICandidateProfile
    {
        int CandidateProfileID { get; set; }
        int VacancyID { get; set; }
        DateTime Dob { get; set; }
        string Location { get; set; }
        string Gender { get; set; }
        float Percentage10 { get; set; }
        float Percentage12 { get; set; }
        string GapInEducation { get; set; }
        string GapInExperience { get; set; }
        string ResumeFile { get; set; }
        int TestID { get; set; }
        int TestStatus { get; set; }
        bool MedicalTestStatus { get; set; }
        int BgcID { get; set; }
        bool BgcTestStatus { get; set; }

        string Remarks { get; set; }
        string BgcTestStatus1 { get; }
        string TestStatus1 { get; }

    }
}
