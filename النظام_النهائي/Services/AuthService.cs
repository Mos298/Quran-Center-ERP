using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي.Services
{
    public class AuthService
    {
        private readonly string _connectionString;

        public AuthService()
        {
            try
            {
                var connSetting = ConfigurationManager.ConnectionStrings["DefaultConnection"];
                if (connSetting != null)
                    _connectionString = connSetting.ConnectionString;
            }
            catch { _connectionString = ""; }
        }

        public AuthService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // لاحظ: حذفنا دالة التشفير لأن قاعدة البيانات تقوم بذلك نيابة عنا
        public bool ValidateUser(string registrationNumber, string plainPassword)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("خطأ: سلسلة الاتصال غير موجودة.");

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                // اسم الإجراء المخزن الصحيح حسب ملفك
                SqlCommand cmd = new SqlCommand("sp_LoginUser", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                // إضافة رقم القيد
                cmd.Parameters.Add("@RegistrationNumber", SqlDbType.NVarChar).Value = registrationNumber;

                // ⚠️ التغيير الجوهري هنا:
                // 1. اسم الباراميتر أصبح @RawPassword ليطابق الإجراء المخزن الذي أرسلته
                // 2. نرسل كلمة المرور العادية (plainPassword) دون أي تشفير من جهة السي شارب
                cmd.Parameters.Add("@RawPassword", SqlDbType.NVarChar).Value = plainPassword;

                try
                {
                    sqlConnection.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        // إذا رجع صف واحد على الأقل، فهذا يعني نجاح الدخول
                        return rd.Read();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("SQL Error: " + ex.Message);
                }
            }
        }
    }
}