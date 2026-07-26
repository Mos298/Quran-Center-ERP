using Xunit;

using Xunit.Abstractions; // ضروري للطباعة في المخرجات
using النظام_النهائي.Services;

namespace FinalSystem.Tests
{
    public class LoginIntegrationTests
    {
        // 1. تعريف أداة الطباعة
        private readonly ITestOutputHelper _output;

        // 2. حقن الأداة عبر الـ Constructor
        public LoginIntegrationTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ValidateUser_WithRealPassword_ShouldReturnTrue()
        {
            // --- Arrange ---
            // تأكد من صحة جملة الاتصال الخاصة بجهازك
            string myConnString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";
            AuthService auth = new AuthService(myConnString);

            string realRegNumber = "25094010001";
            string plainPassword = "6666";

            // --- Act ---
            // نرسل كلمة المرور "6666" كما هي
            bool result = auth.ValidateUser(realRegNumber, plainPassword);

            // --- Assert & Output ---

            if (result)
            {
                // ✅ هذه الرسالة ستظهر بوضوح الآن في نافذة Output
                _output.WriteLine("**********************************");
                _output.WriteLine("      نجاح التسجيل (Login Success) ");
                _output.WriteLine("**********************************");
            }
            else
            {
                _output.WriteLine("فشل التسجيل - تأكد من البيانات");
            }

            Xunit.Assert.True(result, "يجب أن ينجح تسجيل الدخول لأن قاعدة البيانات ستتولى التشفير والمطابقة.");
        }
    }
}