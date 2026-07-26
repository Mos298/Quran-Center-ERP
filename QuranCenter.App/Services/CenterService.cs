using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي.Services
{
    // لا تنسَ كلمة public
    public class CenterService
    {
        private readonly string _connectionString;

        public CenterService()
        {
            try
            {
                var connSetting = ConfigurationManager.ConnectionStrings["DefaultConnection"];
                if (connSetting != null)
                    _connectionString = connSetting.ConnectionString;
            }
            catch { _connectionString = ""; }
        }

        public CenterService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // دالة إضافة مركز جديد
        public bool AddCenter(string centerName, string city, string neighborhood, TimeSpan timeFrom, TimeSpan timeTo)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("خطأ: سلسلة الاتصال غير موجودة.");

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddCenter", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // إضافة الباراميترات حسب الكود الذي أرسلته
                    cmd.Parameters.AddWithValue("@CenterName", centerName);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Neighborhood", neighborhood);

                    // تمرير الأوقات
                    cmd.Parameters.AddWithValue("@WorkingHoursFrom", timeFrom);
                    cmd.Parameters.AddWithValue("@WorkingHoursTo", timeTo);

                    try
                    {
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        // نعتبر الإضافة ناجحة إذا لم يحدث خطأ
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