using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.C_monetor_C.Level_lerning_C
{
    public class TeacherEvaluation
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CenterId { get; set; }
        public int SupervisorId { get; set; }
        public string TeacherClassification { get; set; }
        public string Period { get; set; }
        public string QuranMemorizationLevel { get; set; }
        public string RecitationAttention { get; set; }
        public string CorrectionAttention { get; set; }
        public string NarrationAdherence { get; set; }
        public int StudentsPresent { get; set; }
        public int StudentsAbsent { get; set; }
        public string OverallStudentLevel { get; set; }
        public string OpinionOnTeacher { get; set; }
        public string GeneralAppearance { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
