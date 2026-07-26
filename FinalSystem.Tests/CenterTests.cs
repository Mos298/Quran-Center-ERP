using System;
using Xunit;
using Xunit.Abstractions;
using النظام_النهائي.Services;

namespace FinalSystem.Tests
{
    public class CenterTests
    {
        private readonly ITestOutputHelper _output;

        public CenterTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void AddCenter_ShouldInsertSuccessfully()
        {
            // --- 1. Arrange (تجهيز البيانات) ---
            string myConnString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";

            CenterService service = new CenterService(myConnString);

            // بيانات المركز الجديد
            string name = "مركز النور القرآني - تجريبي";
            string city = "طرابلس";
            string neighborhood = "حي الأندلس";

            // تحديد ساعات العمل (مثلاً من 8 صباحاً إلى 2 ظهراً)
            TimeSpan timeFrom = new TimeSpan(8, 0, 0);
            TimeSpan timeTo = new TimeSpan(14, 0, 0);

            // --- 2. Act (التنفيذ) ---
            bool isSuccess = false;
            string errorMessage = "";

            try
            {
                isSuccess = service.AddCenter(name, city, neighborhood, timeFrom, timeTo);
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
                _output.WriteLine("      ✅ نجاح إضافة المركز (Center Added)      ");
                _output.WriteLine("**********************************************");
                _output.WriteLine($" 🕌 اسم المركز:    {name}");
                _output.WriteLine($" 🏙️ المدينة:      {city}");
                _output.WriteLine($" 📍 الحي:         {neighborhood}");
                _output.WriteLine($" ⏰ ساعات العمل:  {timeFrom} - {timeTo}");
                _output.WriteLine("**********************************************");
                _output.WriteLine("");
            }
            else
            {
                _output.WriteLine("❌ فشل إضافة المركز");
                _output.WriteLine($"السبب: {errorMessage}");
            }

            Assert.True(isSuccess, "يجب أن يتم إضافة المركز بنجاح");
        }
    }
}