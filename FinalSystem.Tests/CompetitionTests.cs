using System;
using Xunit;
using Xunit.Abstractions;
using النظام_النهائي.Services;

namespace FinalSystem.Tests
{
    public class CompetitionTests
    {
        private readonly ITestOutputHelper _output;

        public CompetitionTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void AddCompetition_ShouldInsertSuccessfully()
        {
            // --- 1. Arrange (تجهيز البيانات) ---
            string myConnString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";
            CompetitionService service = new CompetitionService(myConnString);

            // بيانات مسابقة تجريبية للاختبار
            string name = "مسابقة التحدي البرمجي";
            string location = "قاعة الاختبارات الافتراضية";
            DateTime start = DateTime.Now.AddDays(1);
            DateTime end = DateTime.Now.AddDays(5);
            string committee = "اللجنة: الحاسب الآلي | الأعضاء: xUnit";
            string type = "حفظ القرآن الكريم"; // يجب أن يطابق الأنواع المسموح بها في قاعدتك
            string sponsor = "مشروع التخرج";
            string criteria = "اختبار الكود بنجاح";

            // --- 2. Act (التنفيذ) ---
            bool isAdded = service.AddCompetition(name, location, start, end, committee, type, sponsor, criteria);

            // --- 3. Assert & Output (التحقق والتوثيق) ---
            if (isAdded)
            {
                _output.WriteLine("");
                _output.WriteLine("**********************************************");
                _output.WriteLine("      ✅ نجاح إضافة المسابقة (Add Success)      ");
                _output.WriteLine("**********************************************");
                _output.WriteLine($" 🏆 اسم المسابقة:  {name}");
                _output.WriteLine($" 📍 الموقع:       {location}");
                _output.WriteLine($" 📅 التاريخ:      {start.ToShortDateString()}");
                _output.WriteLine("**********************************************");
                _output.WriteLine("");
            }
            else
            {
                _output.WriteLine("❌ فشل إضافة المسابقة");
            }

            Xunit.Assert.True(isAdded, "يجب أن يتم إضافة المسابقة بنجاح وترجع الدالة true");
        }
    }
}