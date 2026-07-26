using System;
using System.Data.SqlClient;
using Xunit;
using Xunit.Abstractions;
using النظام_النهائي.Services;

namespace FinalSystem.Tests
{
    public class TeacherVisitTests
    {
        private readonly ITestOutputHelper _output;
        // جملة الاتصال
        private string connectionString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";

        public TeacherVisitTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void AddVisit_ShouldSucceed()
        {
            // --- 1. Arrange (تجهيز البيانات) ---
            TeacherVisitService service = new TeacherVisitService(connectionString);

            // نطلب من الدوال المساعدة إيجاد المعرفات الصحيحة بناءً على هيكل قاعدة البيانات لديك
            int supervisorId = GetOrCreateSupervisor();
            int centerId = GetOrCreateCenter();
            int teacherId = GetOrCreateTeacher(centerId); // نربط المعلم بالمركز لضمان التناسق

            // طباعة المعرفات للتأكد
            _output.WriteLine($"Using SupervisorID (UserId): {supervisorId}");
            _output.WriteLine($"Using CenterID: {centerId}");
            _output.WriteLine($"Using TeacherID (UserId): {teacherId}");

            // بيانات الزيارة
            DateTime visitDate = DateTime.Now;
            string hasIjazah = "نعم";
            string assignmentType = "رسمي";
            string phone = "0910000000";
            string commitment = "ممتاز";
            int teachingHours = 4;
            int mornStuds = 15;
            string mornAtt = "جيد جداً";
            int evenStuds = 20;
            string evenAtt = "ممتاز";

            // --- 2. Act (التنفيذ) ---
            bool isSuccess = false;
            string errorMessage = "";

            try
            {
                isSuccess = service.AddSupervisorVisit(supervisorId, centerId, teacherId, visitDate,
                                                       hasIjazah, assignmentType, phone, commitment,
                                                       teachingHours, mornStuds, mornAtt, evenStuds, evenAtt);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            // --- 3. Assert & Output (التحقق والتوثيق) ---
            if (isSuccess)
            {
                _output.WriteLine("");
                _output.WriteLine("**********************************************");
                _output.WriteLine("      ✅ نجاح إضافة الزيارة (Visit Added)      ");
                _output.WriteLine("**********************************************");
            }
            else
            {
                _output.WriteLine("❌ فشل إضافة الزيارة");
                _output.WriteLine($"السبب: {errorMessage}");
            }

            Assert.True(isSuccess, "يجب أن يتم حفظ الزيارة بنجاح");
        }

        // ==========================================================
        //  دوال مساعدة (Helpers) - تم تعديلها لتطابق الإجراءات المخزنة
        // ==========================================================

        private int GetOrCreateSupervisor()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // التعديل: استخدام UserId لأنه المفتاح في جدول المشرفين
                SqlCommand cmdCheck = new SqlCommand("SELECT TOP 1 UserId FROM Supervisors", con);
                object result = cmdCheck.ExecuteScalar();

                if (result != null) return Convert.ToInt32(result);

                // إنشاء مستخدم جديد
                string userSql = "INSERT INTO Users (Username, Password, Role, FullName, PhoneNumber) VALUES (@Name, '123', 'Supervisor', 'Test Supervisor', '0910000000'); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdUser = new SqlCommand(userSql, con);
                cmdUser.Parameters.AddWithValue("@Name", "TestSuper_" + Guid.NewGuid().ToString().Substring(0, 8));
                int newUserId = Convert.ToInt32(cmdUser.ExecuteScalar());

                // إضافة للمشرفين (باستخدام UserId)
                string superSql = "INSERT INTO Supervisors (UserId, FullName, PhoneNumber) VALUES (@UserId, 'Test Supervisor', '0910000000');";
                SqlCommand cmdSuper = new SqlCommand(superSql, con);
                cmdSuper.Parameters.AddWithValue("@UserId", newUserId);
                cmdSuper.ExecuteNonQuery();

                return newUserId; // نرجع UserId
            }
        }

        private int GetOrCreateCenter()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // التعديل: استخدام CenterId بناءً على sp_GetAllCentersList
                SqlCommand cmdCheck = new SqlCommand("SELECT TOP 1 CenterId FROM Centers", con);
                object result = cmdCheck.ExecuteScalar();

                if (result != null) return Convert.ToInt32(result);

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO Centers (CenterName, Location) VALUES ('Test Center', 'Test Loc'); SELECT SCOPE_IDENTITY();", con);
                return Convert.ToInt32(cmdInsert.ExecuteScalar());
            }
        }

        private int GetOrCreateTeacher(int centerId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // التعديل: استخدام UserId بناءً على sp_GetTeachersByCenterId
                SqlCommand cmdCheck = new SqlCommand("SELECT TOP 1 UserId FROM Teachers", con);
                object result = cmdCheck.ExecuteScalar();

                if (result != null) return Convert.ToInt32(result);

                // إنشاء مستخدم للمعلم
                string userSql = "INSERT INTO Users (Username, Password, Role, FullName, PhoneNumber, UserType) VALUES (@Name, '123', 'Teacher', 'Test Teacher', '0920000000', 'Teacher'); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdUser = new SqlCommand(userSql, con);
                cmdUser.Parameters.AddWithValue("@Name", "TestTeacher_" + Guid.NewGuid().ToString().Substring(0, 8));
                int newUserId = Convert.ToInt32(cmdUser.ExecuteScalar());

                // إضافة للمعلمين وربطه بالمركز
                string teacherSql = "INSERT INTO Teachers (UserId, CenterId, FullName, Phone) VALUES (@UserId, @CenterId, 'Test Teacher', '0920000000');";
                SqlCommand cmdTeacher = new SqlCommand(teacherSql, con);
                cmdTeacher.Parameters.AddWithValue("@UserId", newUserId);
                cmdTeacher.Parameters.AddWithValue("@CenterId", centerId);
                cmdTeacher.ExecuteNonQuery();

                return newUserId;
            }
        }
    }
}