using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.D_the_techer_D.Level_lerning_D
{
    public class StudentEvaluation
    {
        public int EvaluationId { get; set; }
        public int StudentId { get; set; }
        public DateTime EvaluationDate { get; set; }
        public string Commitment { get; set; }
        public int MemorizedAjza { get; set; }
        public int MemorizationLevel { get; set; }
        public int TajweedLevel { get; set; }
        public string OverallLevel { get; set; }
    }
}
