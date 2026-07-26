using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي
{
    // هذا الملف يحتوي على تعريفات هياكل البيانات المستخدمة في المشروع

    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public List<int> Participants { get; set; }

        public Competition()
        {
            Participants = new List<int>();
        }
    }

    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
    }

    public class Scores
    {
        public int CompetitionId { get; set; }
        public int CandidateId { get; set; }
        public int HifzScore { get; set; } // تم التحديث هنا
        public int TajweedScore { get; set; } // تم التحديث هنا
    }
}

