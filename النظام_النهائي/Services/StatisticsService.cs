using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي.Services
{
    public class StatisticsService
    {
        private readonly string _connectionString;

        public StatisticsService()
        {
            try
            {
                var connSetting = ConfigurationManager.ConnectionStrings["DefaultConnection"];
                if (connSetting != null)
                    _connectionString = connSetting.ConnectionString;
            }
            catch { _connectionString = ""; }
        }

        public StatisticsService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // دالة عامة لجلب البيانات لأي إجراء مخزن
        public DataTable GetStatisticsData(string procedureName)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new Exception("خطأ: سلسلة الاتصال غير موجودة.");

            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        con.Open();
                        da.Fill(dt);
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception($"SQL Error in {procedureName}: " + ex.Message);
                    }
                }
            }
            return dt;
        }
    }
}