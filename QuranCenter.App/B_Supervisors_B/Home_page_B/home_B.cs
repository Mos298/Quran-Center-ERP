using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;       // مكتبة الـ PDF الأساسية
using iTextSharp.text.pdf;   // أدوات الكتابة في الـ PDF
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;
using النظام_النهائي.A_Data_entry_A;

namespace النظام_النهائي.B_Supervisors_B.Home_page_B
{
    public partial class home_B : UserControl
    {
        // جلب نص الاتصال
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public home_B()
        {
            InitializeComponent();
        }

        // حدث تحميل الصفحة (يتم استدعاؤه عند فتح الفورم)
        private void home_B_Load(object sender, EventArgs e)
        {
            // استدعاء دالة جلب البيانات
            LoadSupervisorData();
        }

        private void LoadSupervisorData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // استعلام لجلب بيانات المستخدم الحالي
                    string query = @"
                        SELECT 
                            u.FullName, 
                            u.RegistrationNumber, 
                            u.BirthDate, 
                            u.Gender, 
                            u.City, 
                            u.Qualification, 
                            u.UserType, 
                            u.ProfileImage
                        FROM Users u
                        WHERE u.UserId = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // نستخدم الـ ID الذي تم حفظه عند تسجيل الدخول
                        cmd.Parameters.AddWithValue("@Id", Session.CurrentUserId);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // === تعبئة البيانات في الـ Labels ===
                                // تأكد أن أسماء الـ Labels هنا تطابق الموجودة في التصميم (Design)

                                lblSupervisorNameValue.Text = reader["FullName"].ToString();
                                lblSupervisorIdRegistration_number.Text = reader["RegistrationNumber"].ToString();

                                // تنسيق التاريخ
                                if (reader["BirthDate"] != DBNull.Value)
                                    lblSupervisorDobValuedata.Text = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString();

                                lblSupervisorGenderValue.Text = reader["Gender"].ToString();
                                labelcity_value.Text = reader["City"].ToString();

                                lblSupervisorDeptValue.Text = reader["Qualification"] != DBNull.Value ? reader["Qualification"].ToString() : "غير محدد";
                                lblSupervisorPositionValue.Text = reader["UserType"].ToString();

                                // === تعبئة الصورة الشخصية ===
                                // ملاحظة: هذا الكود يفترض أنك تخزن "مسار الصورة" في قاعدة البيانات
                                string imagePath = reader["ProfileImage"] != DBNull.Value ? reader["ProfileImage"].ToString() : "";

                                // (اختياري) إذا كان لديك PictureBox اسمه pbProfile
                                /*
                                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                {
                                    pbProfile.Image = Image.FromFile(imagePath);
                                }
                                */
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }

        private void btnEditPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "اختر الصورة الشخصية";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // أ: تحديد مسار المجلد الذي سنحفظ فيه الصور (بجانب ملف التشغيل)
                        string folderPath = Path.Combine(Application.StartupPath, "UserImages");

                        // إنشاء المجلد إذا لم يكن موجوداً
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // ب: إنشاء اسم فريد للصورة لتجنب تكرار الأسماء (نستخدم GUID)
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(ofd.FileName);
                        string destPath = Path.Combine(folderPath, fileName);

                        // ج: نسخ الصورة المختارة إلى مجلد البرنامج
                        File.Copy(ofd.FileName, destPath);

                        // د: حفظ المسار الجديد في قاعدة البيانات
                        UpdateUserImageInDB(Session.CurrentUserId, destPath);

                        // هـ: تحديث الصورة المعروضة حالياً في الواجهة
                        // ملاحظة: تأكد أن اسم الـ PictureBox لديك هو pbProfile أو غيره حسب تصميمك
                        // pbProfile.Image = Image.FromFile(destPath); 
                        MessageBox.Show("تم تحديث الصورة الشخصية بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // (اختياري) إذا كنت تريد تحديث الصورة في القائمة الجانبية (Form_B) فوراً، ستحتاج لإعادة تحميل الفورم الرئيسي أو استخدام Events
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء حفظ الصورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // دالة مساعدة لحفظ المسار في قاعدة البيانات
        private void UpdateUserImageInDB(int userId, string imagePath)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateUserProfileImage", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // نمرر رقم المستخدم الحالي (Session.CurrentUserId) إلى فورم تغيير الباسورد
            frmChangePassword_A FF = new frmChangePassword_A(Session.CurrentUserId);

            // نعرض النافذة كـ Dialog (نافذة منبثقة تمنع استخدام الخلفية حتى تغلق)
            if (FF.ShowDialog() == DialogResult.OK)
            {
                // إذا تم التغيير بنجاح، يمكنك تسجيل الخروج أو فقط إعلام المستخدم
                 MessageBox.Show("تم تغيير كلمة المرور، يرجى إعادة تسجيل الدخول لضمان الأمان.");
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {

        }

        private void buttonPRINTR_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF File|*.pdf";
                sfd.FileName = "بيانات_المشرف_" + lblSupervisorNameValue.Text.Trim() + ".pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // إعداد المستند
                        Document doc = new Document(PageSize.A4, 20, 20, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                        doc.Open();

                        // =========================================================
                        // تصحيح الخطأ هنا: استخدام iTextSharp.text.Font بشكل صريح
                        // =========================================================
                        string fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\arial.ttf";
                        BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                        // لاحظ هنا كتبنا iTextSharp.text.Font بدلاً من Font فقط
                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                        iTextSharp.text.Font cellFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        // إضافة العنوان
                        PdfPTable titleTable = new PdfPTable(1);
                        titleTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                        titleTable.DefaultCell.Border = Rectangle.NO_BORDER;

                        PdfPCell titleCell = new PdfPCell(new Phrase("بطاقة بيانات المشرف العام", titleFont));
                        titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        titleCell.Border = Rectangle.NO_BORDER;
                        titleCell.PaddingBottom = 20;
                        titleTable.AddCell(titleCell);
                        doc.Add(titleTable);

                        // إنشاء جدول البيانات
                        PdfPTable table = new PdfPTable(2);
                        table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                        table.WidthPercentage = 100;
                        table.SetWidths(new float[] { 2f, 1f });

                        // إضافة البيانات
                        AddCellToTable(table, "الاسم الكامل", lblSupervisorNameValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "رقم القيد", lblSupervisorIdRegistration_number.Text, headerFont, cellFont);
                        AddCellToTable(table, "المنصب", lblSupervisorPositionValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "القسم", lblSupervisorDeptValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "تاريخ الميلاد", lblSupervisorDobValuedata.Text, headerFont, cellFont);
                        AddCellToTable(table, "الجنس", lblSupervisorGenderValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "المدينة", labelcity_value.Text, headerFont, cellFont);

                        // إضافة الجدول للملف
                        doc.Add(table);

                        doc.Close();
                        writer.Close();

                        MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        // =========================================================
        // الدالة المساعدة (يجب تحديث نوع المتغيرات هنا أيضاً)
        // =========================================================
        private void AddCellToTable(PdfPTable table, string labelText, string valueText, iTextSharp.text.Font fontHead, iTextSharp.text.Font fontVal)
        {
            // خلية العنوان
            PdfPCell cellLabel = new PdfPCell(new Phrase(labelText, fontHead));
            cellLabel.BackgroundColor = new BaseColor(52, 73, 94);
            cellLabel.HorizontalAlignment = Element.ALIGN_CENTER;
            cellLabel.VerticalAlignment = Element.ALIGN_MIDDLE;
            cellLabel.Padding = 8;
            cellLabel.BorderColor = BaseColor.WHITE;
            cellLabel.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            // خلية القيمة
            PdfPCell cellValue = new PdfPCell(new Phrase(valueText, fontVal));
            cellValue.BackgroundColor = BaseColor.WHITE;
            cellValue.HorizontalAlignment = Element.ALIGN_CENTER;
            cellValue.VerticalAlignment = Element.ALIGN_MIDDLE;
            cellValue.Padding = 8;
            cellValue.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            table.AddCell(cellLabel);
            table.AddCell(cellValue);
        }
    }
    }
