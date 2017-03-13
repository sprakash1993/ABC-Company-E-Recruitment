using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BOFactory;
using System.Data;
using System.Data.SqlClient;

namespace DB
{
    public class CandidateProfileDB :ICandidateProfileDB
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<int, ICandidateProfile> GetCandidateProfileList()
        {
          SortedList<int, ICandidateProfile> candidates = new SortedList<int, ICandidateProfile>();
          SqlConnection conn = DBUtility.getConnection();
          conn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_getcandidateprofile";
          cmd.Connection = conn;
          SqlDataReader reader = cmd.ExecuteReader();
          while (reader.Read())
          {
              int cpid = Convert.ToInt32(reader["CandidateProfileID"]);
              bool bgcteststatus = Convert.ToBoolean(reader["BGCTestStatus"]);
              ICandidateProfile cp = new CandidateProfileFactory().CreateCandidateProfile(cpid,bgcteststatus);
              candidates.Add(cp.CandidateProfileID,cp);
          }
          conn.Close();
          return candidates;
      }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateprofileId"></param>
        /// <param name="bgcteststatus"></param>
        /// <returns></returns>
      public int UpdateCandidateProfile(int candidateprofileId,bool bgcteststatus)
      {
          SqlConnection conn = DBUtility.getConnection();
          conn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_updatedetails";
          cmd.Connection = conn;
          cmd.Parameters.AddWithValue("@CandidateProfileID", candidateprofileId);
          cmd.Parameters.AddWithValue("@BGCTestStatus", bgcteststatus);
          int row = cmd.ExecuteNonQuery();
          conn.Close();
          return row;
      }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
      public SortedList<int, ICandidateProfile> GetCandidateProfileList_VacancyId()
      {
          SortedList<int, ICandidateProfile> candidates = new SortedList<int, ICandidateProfile>();
          SqlConnection conn = DBUtility.getConnection();
          conn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_getcandidateprofile";
          cmd.Connection = conn;
          SqlDataReader reader = cmd.ExecuteReader();
          while (reader.Read())
          {
              int cpid = Convert.ToInt32(reader["CandidateProfileID"]);
             int vacancyId = Convert.ToInt32(reader["VacancyID"]);
              ICandidateProfile cp = new CandidateProfileFactory().CreateCandidateProfile(cpid, vacancyId);
              candidates.Add(cp.CandidateProfileID, cp);
          }
          conn.Close();
          return candidates;
      }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
      public SortedList<int, ICandidateProfile> GetCandidateProfileList_TestStatus()
      {
          SortedList<int, ICandidateProfile> candidates = new SortedList<int, ICandidateProfile>();
          SqlConnection conn = DBUtility.getConnection();
          conn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_getcandidateprofile";
          cmd.Connection = conn;
          SqlDataReader reader = cmd.ExecuteReader();
          while (reader.Read())
          {
              int cpid = Convert.ToInt32(reader["CandidateProfileID"]);
              int teststatus = Convert.ToInt32(reader["TestStatus"]);
              ICandidateProfile cp = new CandidateProfileFactory().CreateCandidateProfile1(cpid, teststatus);
              candidates.Add(cp.CandidateProfileID, cp);
          }
          conn.Close();
          return candidates;
      }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateprofileId"></param>
        /// <param name="teststatus"></param>
        /// <returns></returns>
      public int UpdateCandidateProfile1(int candidateprofileId, int teststatus)
      {
          SqlConnection conn = DBUtility.getConnection();
          conn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.CommandText = "sp_updateteststatus";
          cmd.Connection = conn;
          cmd.Parameters.AddWithValue("@CandidateProfileID", candidateprofileId);
          cmd.Parameters.AddWithValue("@TestStatus", teststatus);
          int row = cmd.ExecuteNonQuery();
          conn.Close();
          return row;
      }
    }
}
