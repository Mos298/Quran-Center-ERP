using System;

namespace النظام_النهائي
{
    // هذا الكلاس يمثل الهيكل الكامل لبيانات الطالب الواحد
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string GuardianName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Residence { get; set; }
        public string Gender { get; set; }
        public string NationalID { get; set; } // الرقم الوطني أو جواز السفر
        public string StudentPhone { get; set; }
        public string GuardianPhone { get; set; }
        public string RegistrationNumber { get; set; }
        public string Password { get; set; }
    }
}

