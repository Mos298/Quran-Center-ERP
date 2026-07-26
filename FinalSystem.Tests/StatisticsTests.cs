using System;
using System.Data;
using Xunit;
using Xunit.Abstractions;
using النظام_النهائي.Services;

namespace FinalSystem.Tests
{
    public class StatisticsTests
    {
        private readonly ITestOutputHelper _output;

        public StatisticsTests(ITestOutputHelper output)
        {
            _output = output;
        }

        // 1. اختبار إحصائية الطلاب
        [Fact]
        public void GetStudentStats_ShouldReturnData()
        {
            // Arrange
            string myConnString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";
            StatisticsService service = new StatisticsService(myConnString);

            // Act
            DataTable dt = service.GetStatisticsData("sp_Stats_StudentsPerCenter");

            // Assert & Log
            Assert.NotNull(dt);
            _output.WriteLine($"✅ تم جلب بيانات الطلاب. عدد المراكز: {dt.Rows.Count}");

            if (dt.Rows.Count > 0)
            {
                Assert.Contains("CenterName", dt.Columns[0].ColumnName); // التأكد من اسم العمود
                _output.WriteLine($"   مثال: {dt.Rows[0]["CenterName"]} - العدد: {dt.Rows[0][1]}");
            }
        }

        // 2. اختبار إحصائية المحفظين
        [Fact]
        public void GetTeacherStats_ShouldReturnData()
        {
            // Arrange
            string myConnString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";
            StatisticsService service = new StatisticsService(myConnString);

            // Act
            DataTable dt = service.GetStatisticsData("sp_Stats_TeachersPerCenter");

            // Assert
            Assert.NotNull(dt);
            _output.WriteLine($"✅ تم جلب بيانات المعلمين. عدد الصفوف: {dt.Rows.Count}");
        }

        // 3. اختبار إحصائية التقييمات (الأعقد لأن فيها حسابات)
        [Fact]
        public void GetTopRatedCenters_ShouldReturnValidScores()
        {
            // Arrange
            string myConnString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";
            StatisticsService service = new StatisticsService(myConnString);

            // Act
            DataTable dt = service.GetStatisticsData("sp_Stats_TopRatedCenters");

            // Assert
            Assert.NotNull(dt);
            _output.WriteLine($"✅ تم جلب تقييمات المراكز.");

            foreach (DataRow row in dt.Rows)
            {
                decimal score = Convert.ToDecimal(row["AverageScore"]);
                _output.WriteLine($"   المركز: {row["CenterName"]} - التقييم: {score}");

                // التأكد أن النسبة مئوية منطقية (بين 0 و 100)
                Assert.True(score >= 0 && score <= 100, "التقييم يجب أن يكون بين 0 و 100");
            }
        }
    }
}