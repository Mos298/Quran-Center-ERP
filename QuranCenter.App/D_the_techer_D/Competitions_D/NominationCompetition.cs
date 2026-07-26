using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.D_the_techer_D.Competitions_D
{
    public class NominationCompetition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Conditions { get; set; }
    }

    /// <summary>
    /// يمثل طالباً واحداً في قائمة الترشيح
    /// </summary>
    public class NominationStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// يمثل سجل ترشيح واحد معروض في الجدول
    /// </summary>
    public class NominationView
    {
        public int NominationId { get; set; }
        public string CompetitionName { get; set; }
        public string StudentName { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime NominationDate { get; set; }
    }
}
