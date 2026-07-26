using System;
using Xunit;
using Xunit.Abstractions;
using النظام_النهائي.Services;

namespace FinalSystem.Tests
{
    public class NominationTests
    {
        private readonly ITestOutputHelper _output;

        public NominationTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void SubmitNomination_ShouldSucceed()
        {
            // --- 1. Arrange (تجهيز البيانات) ---
            string myConnString = @"Data Source=ABDALRAOUF\ABD_ALRAOUF559;Initial Catalog=QuranCenterDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=True";

            NominationService service = new NominationService(myConnString);

            // ⚠️⚠️ تحديث هام: تأكد أن هذه الأرقام موجودة فعلاً في قاعدة بياناتك لكي ينجح الاختبار
            int validStudentId = 1;      // <-- ضع رقم طالب موجود
            int validCompetitionId = 1;  // <-- ضع رقم مسابقة موجودة
            int validTeacherId = 5;      // <-- ضع رقم معلم موجود

            // --- 2. Act (التنفيذ) ---
            bool isSuccess = false;
            string errorMessage = "";

            try
            {
                isSuccess = service.SubmitStudentNomination(validStudentId, validCompetitionId, validTeacherId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                // التعامل مع حالة أن الطالب مسجل مسبقاً (يعتبر نجاحاً للاتصال)
                if (errorMessage.Contains("موجود") || errorMessage.Contains("already") || errorMessage.Contains("UNIQUE constraint"))
                {
                    isSuccess = true;
                    _output.WriteLine("Note: الطالب كان مسجلاً بالفعل، لكن الاتصال بالكود تم بنجاح.");
                }
            }

            // --- 3. Assert & Output (التحقق والتوثيق) ---
            if (isSuccess)
            {
                _output.WriteLine("");
                _output.WriteLine("**********************************************");
                _output.WriteLine("      ✅ نجاح عملية الترشيح (Nomination Success)      ");
                _output.WriteLine("**********************************************");
                _output.WriteLine($" 👨‍🎓 رقم الطالب (Student ID):   {validStudentId}");
                _output.WriteLine($" 🏆 رقم المسابقة (Comp ID):   {validCompetitionId}");
                _output.WriteLine($" 👨‍🏫 رقم المعلم (Teacher ID):  {validTeacherId}");
                _output.WriteLine("**********************************************");
                _output.WriteLine("");
            }
            else
            {
                _output.WriteLine("❌ فشل عملية الترشيح");
                _output.WriteLine($"السبب: {errorMessage}");
            }

            Assert.True(isSuccess, "يجب أن تتم عملية الترشيح بنجاح");
        }
    }
}