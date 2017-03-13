using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
namespace BO
{
    public class CandidateProfile : ICandidateProfile
    {
        private int candidateProfileId;
        private int vacancyId;
        private DateTime dob;
        private string location;
        private string gender;
        private float percentage10;
        private float percentage12;
        private string gapInEducation;
        private string gapInExperience;
        private string resumeFile;
        private int testId;
        private int testStatus;
        private bool medicalTestStatus;
        private int bgcId;
        private bool bgcTestStatus;
        private string remarks;
        public int CandidateProfileID
        {
            get { return candidateProfileId; }
            set { candidateProfileId = value; }
        }
        public int VacancyID { get { return vacancyId; } set { vacancyId = value; } }
        public DateTime Dob { get { return dob; } set { dob = value; } }
        public string Location { get { return location; } set { location = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public float Percentage10 { get { return percentage10; } set { percentage10 = value; } }
        public float Percentage12 { get { return percentage12; } set { percentage12 = value; } }
        public string GapInEducation { get { return gapInEducation; } set { gapInEducation = value; } }
        public string GapInExperience { get { return gapInExperience; } set { gapInExperience = value; } }
        public string ResumeFile { get { return resumeFile; } set { resumeFile = value; } }
        public int TestID { get { return testId; } set { testId = value; } }
        public int TestStatus { get { return testStatus; } set { testStatus = value; } }
        public bool MedicalTestStatus { get { return medicalTestStatus; } set { medicalTestStatus = value; } }
        public int BgcID { get { return bgcId; } set { bgcId = value; } }
        public bool BgcTestStatus { get { return bgcTestStatus; } set { bgcTestStatus = value; } }
        public string Remarks { get { return remarks; } set { remarks = value; } }
        public string BgcTestStatus1
        {
            get { if (bgcTestStatus == false)return "Pending"; else return "Cleared"; }
        }
        public string TestStatus1
        {
            get
            {
                if (testStatus == 0)
                {
                    return "Applied";
                }
                else if (testStatus == 1)
                {
                    return "Written Test Conducted";
                }
                else if (testStatus == 2) return "Written & Technical Conducted";
                else if (testStatus == 3) return "Written,Technical & HR Conducted";
                else if (testStatus == 4) return "Medical Test Conducted";
                else if (testStatus == 5) return "Awaiting BGC";
                else return "Confirmed";

            }


        }
        
     
    }
}
