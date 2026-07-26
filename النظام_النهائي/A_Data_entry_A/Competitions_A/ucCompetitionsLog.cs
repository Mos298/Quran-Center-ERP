using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace النظام_النهائي
{
    public partial class ucCompetitionLog : UserControl
    {
        public ucCompetitionLog()
        {
            InitializeComponent();
        }

        public void LoadData(List<Competition> allCompetitions)
        {
            var logData = allCompetitions
                .OrderByDescending(c => c.Date) // ترتيب تنازلي حسب التاريخ
                .Select(c => new
                {
                    ID = c.Id,
                    الاسم = c.Name,
                    الموقع = c.Location,
                    التاريخ = c.Date,
                    الحالة = c.Status,
                  //  النوع = c.Type,
                   // اللجنة = c.Committee
                }).ToList();

            dgvLog.DataSource = logData;

            // تحسين مظهر الأعمدة
            if (dgvLog.Columns.Count > 0)
            {
                dgvLog.Columns["ID"].HeaderText = "المعرف";
                dgvLog.Columns["ID"].Visible = false; // إخفاء المعرف
            }
        }
    }
}
