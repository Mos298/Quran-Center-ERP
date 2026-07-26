using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.D_the_techer_D.student_D
{
    public class NominationCompetition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Conditions { get; set; }
    }

    // فئة لتمثيل البيانات المبسطة للطالب في قائمة الترشيح
    public class NominationStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
