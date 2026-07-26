using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.B_Supervisors_B.Subordinate_B
{
    public class TeacherVisit
    {
        public int VisitId { get; set; }
        public int TeacherId { get; set; }
        public int CenterId { get; set; }
        public string QuranMemorization { get; set; }
        public string AssignmentType { get; set; }
        public string Commitment { get; set; }
        public string TeachingHoursFrom { get; set; }
        public string TeachingHoursTo { get; set; }
        public DateTime? Visit1_Date { get; set; }
        public int Visit1_StudentsPresent { get; set; }
        public string Visit1_TeacherAttendance { get; set; }
        public DateTime? Visit2_Date { get; set; }
        public int Visit2_StudentsPresent { get; set; }
        public string Visit2_TeacherAttendance { get; set; }
    }
}
