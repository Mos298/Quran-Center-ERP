using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي.Services
{
    public class RegistrationService
    {
        private readonly string _connectionString;

        // الكونستركتور يأخذ جملة الاتصال
        public RegistrationService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // 1. دالة جلب رقم القيد التالي من قاعدة البيانات
        public string GetNextRegistrationNumber(string cityCode, string actorCode)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetNextRegistrationNumber", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CityCode", cityCode);
                    cmd.Parameters.AddWithValue("@ActorCode", actorCode);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                            return result.ToString();

                        throw new Exception("فشل في توليد الرقم، القيمة العائدة فارغة.");
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("SQL Error: " + ex.Message);
                    }
                }
            }
        }

        // 2. دالة مساعدة للاختبار: إدخال مستخدم وهمي لحجز الرقم
        // ✅ تم التعديل: إضافة NationalId وباقي الحقول الإلزامية لتجنب الخطأ السابق
        public void InsertDummyUserForTest(string regNum)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Users 
                                (RegistrationNumber, PasswordHash, FullName, UserType, RegistrationDate, NationalId, PhoneNumber, Gender, City) 
                                VALUES 
                                (@RegNum, 'hash_test_123', 'Test User', 'Mentor', GETDATE(), '111222333444', '0910000000', 'ذكر', 'TestCity')";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNum", regNum);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. دالة مساعدة: حذف المستخدم الوهمي بعد الاختبار (تنظيف)
        public void DeleteDummyUserForTest(string regNum)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Users WHERE RegistrationNumber = @RegNum";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RegNum", regNum);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}