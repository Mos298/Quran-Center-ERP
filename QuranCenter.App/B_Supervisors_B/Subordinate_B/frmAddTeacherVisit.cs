using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A;

namespace النظام_النهائي
{
    public partial class frmAddTeacherVisit : Form
    {
        // قراءة جملة الاتصال
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public frmAddTeacherVisit()
        {
            InitializeComponent();

            // ربط الأحداث يدوياً لضمان العمل
            this.comboxCenter.SelectedIndexChanged += new System.EventHandler(this.comboxCenter_SelectedIndexChanged);

            // إضافـــة هــذا السطـــر الجديـــد:
            this.comboTecher.SelectedIndexChanged += new System.EventHandler(this.comboTecher_SelectedIndexChanged);

            LoadCenters();
        }
        // حدث عند تغيير اختيار المحفظ
        private void comboTecher_SelectedIndexChanged(object sender, EventArgs e)
        {
            // التأكد من وجود اختيار
            // التأكد من وجود اختيار
            if (comboTecher.SelectedIndex != -1 && comboTecher.SelectedItem != null)
            {
                try
                {
                    // بما أن المصدر هو DataTable، فإن العنصر المختار عبارة عن DataRowView
                    DataRowView row = comboTecher.SelectedItem as DataRowView;

                    if (row != null)
                    {
                        // جلب رقم الهاتف من الصف المختار ووضعه في التيكست بوكس
                        // تأكد أن "PhoneNumber" هو اسم العمود في قاعدة البيانات
                        string phone = row["PhoneNumber"] != DBNull.Value ? row["PhoneNumber"].ToString() : "";
                        phoonTextBox1.Text = phone;
                    }
                }
                catch (Exception)
                {
                    // تجاهل الخطأ في حالة حدوث مشكلة بسيطة في التحويل
                    phoonTextBox1.Text = "";
                }
            }
        }
        // ---------------------------------------------------------
        // دالة تحميل المراكز
        // ---------------------------------------------------------
        private void LoadCenters()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetAllCentersList", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        comboxCenter.DataSource = dt;
                        comboxCenter.DisplayMember = "CenterName";
                        comboxCenter.ValueMember = "CenterId";

                        comboxCenter.SelectedIndex = -1; // تفريغ الاختيار المبدئي
                        comboTecher.DataSource = null;   // تفريغ قائمة المعلمين
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المراكز: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // حدث عند اختيار مركز جديد
        // ---------------------------------------------------------
        private void comboxCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // نتأكد أن القيمة المختارة هي رقم صحيح (CenterId)
            if (comboxCenter.SelectedIndex != -1 && comboxCenter.SelectedValue is int)
            {
                int centerId = (int)comboxCenter.SelectedValue;
                LoadTeachers(centerId);
            }
        }

        // ---------------------------------------------------------
        // دالة جلب المعلمين للمركز المختار
        // ---------------------------------------------------------
        private void LoadTeachers(int centerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GetTeachersByCenterId", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CenterId", centerId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        comboTecher.DataSource = dt;
                        comboTecher.DisplayMember = "TeacherName"; // الاسم المعروض
                        comboTecher.ValueMember = "TeacherId";     // القيمة المخفية (UserId)

                        comboTecher.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المعلمين: " + ex.Message);
            }
        }

        // ---------------------------------------------------------
        // زر الحفظ
        // ---------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. التحقق من البيانات
            if (comboxCenter.SelectedIndex == -1 || comboTecher.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار المركز والمعلم أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddSupervisorVisit", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // 2. تعبئة الباراميترات
                        // رقم المشرف من الجلسة
                        cmd.Parameters.AddWithValue("@SupervisorId", Session.CurrentUserId);

                        // المركز والمعلم من القوائم
                        cmd.Parameters.AddWithValue("@CenterId", Convert.ToInt32(comboxCenter.SelectedValue));
                        cmd.Parameters.AddWithValue("@TeacherId", Convert.ToInt32(comboTecher.SelectedValue));

                        // التاريخ والوقت
                        cmd.Parameters.AddWithValue("@VisitDate", DateTime.Now);

                        // بيانات الفورم (استخدمت الأسماء الموجودة في ملفاتك السابقة)
                        cmd.Parameters.AddWithValue("@HasIjazah", cmbQuranIjazah.Text);
                        cmd.Parameters.AddWithValue("@AssignmentType", cmbAssignmentType.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoonTextBox1.Text); // حسب التسمية في ملفك
                        cmd.Parameters.AddWithValue("@CommitmentLevel", cmbCommitment.Text);
                        cmd.Parameters.AddWithValue("@TeachingHours", (int)numTeachingHours.Value);

                        cmd.Parameters.AddWithValue("@MorningStudents", (int)numStudents1.Value);
                        cmd.Parameters.AddWithValue("@MorningAttendance", cmbAttendance1.Text);

                        cmd.Parameters.AddWithValue("@EveningStudents", (int)numStudents2.Value);
                        cmd.Parameters.AddWithValue("@EveningAttendance", cmbAttendance2.Text);

                        // 3. التنفيذ
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("تم حفظ بيانات الزيارة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}