using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.B_Supervisors_B.Subordinate_B
{
    // فئة لتمثيل بيانات المحفظ في واجهة التعديل
    public class TeacherAssignment
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAssigned { get; set; } // لتحديد ما إذا كان معينًا لهذا المركز أم لا
    }
}
