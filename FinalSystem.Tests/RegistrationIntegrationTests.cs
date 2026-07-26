using System;
using Xunit;
using Xunit.Abstractions;
using النظام_النهائي.Services;

namespace FinalSystem.Tests
{
    public class RegistrationIntegrationTests
    {
        private readonly ITestOutputHelper _output;
        private readonly string _connectionString;

        public RegistrationIntegrationTests(ITestOutputHelper output)
        {
            _output = output;
            // تأكد من صحة جملة الاتصال الخاصة بك
            _connectionString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";
        }

        [Fact]
        public void GenerateID_ShouldIncrement_WhenUserIsAdded()
        {
            // --- 1. Arrange (التجهيز) ---
            var service = new RegistrationService(_connectionString);
            string cityCode = "094"; // كود طرابلس
            string actorCode = "03"; // كود الموجهين

            // --- 2. Act (التنفيذ) ---

            // الخطوة أ: جلب الرقم المتاح حالياً (مثلاً 25094030001)
            string firstId = service.GetNextRegistrationNumber(cityCode, actorCode);
            _output.WriteLine($"1. الرقم المتاح أول مرة: {firstId}");

            // الخطوة ب: محاكاة أن هذا الرقم تم استخدامه وحفظه في قاعدة البيانات
            service.InsertDummyUserForTest(firstId);
            _output.WriteLine("   -> تم حجز هذا الرقم في قاعدة البيانات (مستخدم وهمي).");

            // الخطوة ج: طلب الرقم المتاح مرة أخرى (يجب أن يكون 25094030002)
            string secondId = service.GetNextRegistrationNumber(cityCode, actorCode);
            _output.WriteLine($"2. الرقم المتاح بعد الحجز: {secondId}");

            // --- 3. Assert (التحقق) ---
            try
            {
                // تحويل الأرقام إلى Long للمقارنة الحسابية
                long num1 = long.Parse(firstId);
                long num2 = long.Parse(secondId);

                // التحقق من أن الرقم الثاني أكبر من الأول بـ 1
                Assert.Equal(num1 + 1, num2);
                _output.WriteLine("✅ نجح الاختبار: الرقم زاد بمقدار 1 بشكل صحيح.");
            }
            finally
            {
                // --- 4. Cleanup (التنظيف) ---
                // حذف المستخدم الوهمي لكي لا نلوث قاعدة البيانات
                service.DeleteDummyUserForTest(firstId);
                _output.WriteLine("🧹 تم تنظيف قاعدة البيانات (حذف المستخدم الوهمي).");
            }
        }

        [Fact]
        public void GenerateID_ShouldFollowFormat()
        {
            // اختبار التحقق من شكل الرقم (سنة + مدينة + فاعل + مسلسل)
            var service = new RegistrationService(_connectionString);
            string cityCode = "031"; // مصراتة
            string actorCode = "03";

            string generatedId = service.GetNextRegistrationNumber(cityCode, actorCode);
            _output.WriteLine($"الرقم المولد لمصراتة: {generatedId}");

            // التأكد من أن الطول 11 خانة (2 سنة + 3 مدينة + 2 فاعل + 4 مسلسل)
            Assert.Equal(11, generatedId.Length);

            // التأكد من أنه يبدأ بالسنة الحالية (مثلاً 25)
            string currentYear = DateTime.Now.ToString("yy");
            Assert.StartsWith(currentYear + cityCode + actorCode, generatedId);
        }
    }
}