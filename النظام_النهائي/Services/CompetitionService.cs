using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي.Services
{
    // 👇 التعديل هنا: أضفنا public لتتمكن الاختبارات من رؤية هذا الكلاس
    public class CompetitionService
    {
        private readonly string _connectionString;

        // الكونستركتور الافتراضي للبرنامج
        public CompetitionService()
        {
            try
            {
                var connSetting = ConfigurationManager.ConnectionStrings["DefaultConnection"];
                if (connSetting != null)
                    _connectionString = connSetting.ConnectionString;
            }
            catch { _connectionString = ""; }
        }

        // كونستركتور مخصص للاختبارات (لنمرر جملة الاتصال يدوياً)
        public CompetitionService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // دالة إضافة المسابقة
        public bool AddCompetition(string name, string location, DateTime startDate, DateTime endDate,
                                   string committeeInfo, string type, string sponsor, string criteria)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("خطأ: سلسلة الاتصال غير موجودة.");

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                // اسم الإجراء المخزن كما هو في كودك الأصلي
                using (SqlCommand cmd = new SqlCommand("sp_AddCompetition", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // تمرير الباراميترات
                    cmd.Parameters.AddWithValue("@CompetitionName", name);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@SupervisionCommittee", committeeInfo);
                    cmd.Parameters.AddWithValue("@CompetitionType", type);
                    cmd.Parameters.AddWithValue("@Sponsor", sponsor);
                    cmd.Parameters.AddWithValue("@Criteria", criteria);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        // إذا تم التأثير في صف واحد أو أكثر، فالعملية ناجحة
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        // في حالة الخطأ، نرمي استثناء ليظهر في الاختبار
                        throw new Exception("SQL Error: " + ex.Message);
                    }
                }
            }
        }
    }
}