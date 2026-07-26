using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي.Services
{
    // تأكد من كلمة public
    public class TeacherVisitService
    {
        private readonly string _connectionString;

        public TeacherVisitService()
        {
            try
            {
                var connSetting = ConfigurationManager.ConnectionStrings["DefaultConnection"];
                if (connSetting != null)
                    _connectionString = connSetting.ConnectionString;
            }
            catch { _connectionString = ""; }
        }

        public TeacherVisitService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // دالة إضافة الزيارة (تأخذ كل البيانات كباراميترات)
        public bool AddSupervisorVisit(int supervisorId, int centerId, int teacherId, DateTime visitDate,
                                       string hasIjazah, string assignmentType, string phone, string commitment,
                                       int teachingHours, int mornStuds, string mornAtt, int evenStuds, string evenAtt)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("خطأ: سلسلة الاتصال غير موجودة.");

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddSupervisorVisit", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // تعبئة البيانات
                    cmd.Parameters.AddWithValue("@SupervisorId", supervisorId);
                    cmd.Parameters.AddWithValue("@CenterId", centerId);
                    cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                    cmd.Parameters.AddWithValue("@VisitDate", visitDate);

                    cmd.Parameters.AddWithValue("@HasIjazah", hasIjazah);
                    cmd.Parameters.AddWithValue("@AssignmentType", assignmentType);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@CommitmentLevel", commitment);
                    cmd.Parameters.AddWithValue("@TeachingHours", teachingHours);

                    cmd.Parameters.AddWithValue("@MorningStudents", mornStuds);
                    cmd.Parameters.AddWithValue("@MorningAttendance", mornAtt);

                    cmd.Parameters.AddWithValue("@EveningStudents", evenStuds);
                    cmd.Parameters.AddWithValue("@EveningAttendance", evenAtt);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true; // نعتبر العملية ناجحة إذا لم يحدث استثناء
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