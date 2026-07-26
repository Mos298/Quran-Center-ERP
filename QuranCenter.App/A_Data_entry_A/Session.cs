using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using النظام_النهائي.A_Data_entry_A.Login_A;
namespace النظام_النهائي.A_Data_entry_A
{
    // نجعل الكلاس static لأنه لا يحتاج لإنشاء نسخة منه، هو حاوية بيانات عامة
    public static class Session
    {
        // 1. البيانات الأساسية للمستخدم (من جدول Users)
        public static int CurrentUserId { get; set; }
        public static string CurrentUserName { get; set; }
        public static string CurrentUserType { get; set; } // (Admin, Teacher, DataEntry, etc.)
        public static string CurrentFullName { get; set; } // الاسم الحقيقي للعرض

        // 2. البيانات التفصيلية (نستخدم int? أي يقبل null لأن الأدمن مثلاً ليس له TeacherId)

        /// <summary>
        /// يحمل رقم المدرس إذا كان المستخدم مسجل دخول كمدرس
        /// يستخدم في شاشة ترشيح الطلاب
        /// </summary>
        public static int? CurrentTeacherId { get; set; }

        /// <summary>
        /// يحمل رقم المركز إذا كان المستخدم تابعاً لمركز معين
        /// </summary>
        public static int? CurrentCenterId { get; set; }

        // 3. دالة لتسجيل الخروج وتنظيف البيانات
        public static void Logout()
        {
            CurrentUserId = 0;
            CurrentUserName = string.Empty;
            CurrentUserType = string.Empty;
            CurrentFullName = string.Empty;

            CurrentTeacherId = null;
            CurrentCenterId = null;
        }

        // 4. خاصية للتحقق هل المستخدم مسجل دخول أم لا
        public static bool IsLoggedIn
        {
            get { return CurrentUserId > 0; }
        }
    }
}