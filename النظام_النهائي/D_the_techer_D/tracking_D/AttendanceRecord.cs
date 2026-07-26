using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace النظام_النهائي.D_the_techer_D.tracking_D
{
    /// <summary>
    /// يمثل سجل حضور طالب واحد ليوم معين في جدول العرض
    /// </summary>
    public class AttendanceRecord
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string RegistrationNumber { get; set; }
        public string Status { get; set; } // سيحتوي على: حاضر، غائب، متأخر، بإذن
    }
}
