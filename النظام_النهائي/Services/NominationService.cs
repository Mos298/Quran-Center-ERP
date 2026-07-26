using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي.Services
{
    // 👇 التعديل هنا: أضف كلمة public ليتمكن الاختبار من رؤية هذا الكلاس
    public class NominationService
    {
        private readonly string _connectionString;

        public NominationService()
        {
            try
            {
                var connSetting = ConfigurationManager.ConnectionStrings["DefaultConnection"];
                if (connSetting != null)
                    _connectionString = connSetting.ConnectionString;
            }
            catch { _connectionString = ""; }
        }

        public NominationService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool SubmitStudentNomination(int studentId, int competitionId, int teacherId)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("خطأ: سلسلة الاتصال غير موجودة.");

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_SubmitStudentNomination", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@CompetitionId", competitionId);
                    cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("SQL Error: " + ex.Message);
                    }
                }
            }
        }
    }
}