using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using النظام_النهائي.A_Data_entry_A;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace النظام_النهائي.C_monetor_C.Home_page_C
{
    public partial class home_c : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public home_c()
        {
            InitializeComponent();
        }

        private void home_c_Load(object sender, EventArgs e)
        {
            // قم بتمرير رقم المستخدم الحالي هنا
            LoadMentorData();
        }

       //=========================================================
        // دالة جلب البيانات الآمنة (لن تتعطل أبداً)
        // =========================================================
        private void LoadMentorData()
        {
            // تأكد من أن رقم المستخدم صحيح
            if (Session.CurrentUserId == 0)
            {
                MessageBox.Show("خطأ: لم يتم العثور على رقم المستخدم (ID = 0)");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // تأكد من اسم الإجراء المخزن هنا
                    using (SqlCommand cmd = new SqlCommand("sp_GetMentorProfile", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", Session.CurrentUserId);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // --- البيانات الأساسية (عادة موجودة دائماً) ---
                                lblMONETORNameValue.Text = GetSafeString(reader, "FullName");
                                lblMONETORIdRegistration_number.Text = GetSafeString(reader, "RegistrationNumber");

                                // معالجة التاريخ بشكل آمن
                                if (HasColumn(reader, "BirthDate") && reader["BirthDate"] != DBNull.Value)
                                {
                                    lblMONRTODobValuedata.Text = Convert.ToDateTime(reader["BirthDate"]).ToString("yyyy/MM/dd");
                                }
                                else
                                {
                                    lblMONRTODobValuedata.Text = "غير محدد";
                                }

                                // --- البيانات التي كانت تسبب المشكلة (نستخدم الدالة الآمنة) ---

                                // الجنس (إذا لم يجده سيكتب "غير متوفر" ولن يغلق البرنامج)
                                lblMONETRORGenderValue.Text = GetSafeString(reader, "Gender");

                                // بيانات الاتصال
                                lblCenterPhoneValue.Text = GetSafeString(reader, "PhoneNumber");
                                lblCenterEmailValue.Text = GetSafeString(reader, "Email");

                                // بيانات الموجه (قد تكون فارغة للمستخدم الجديد)
                                labelcity_value.Text = GetSafeString(reader, "Residence"); // السكن
                                lblMONETORDeptValue.Text = GetSafeString(reader, "MentorQualification"); // لاحظ الاسم هنا

                                // ملاحظة: إذا لم يعمل MentorQualification جرب Qualification
                                if (lblMONETORDeptValue.Text == "---")
                                    lblMONETORDeptValue.Text = GetSafeString(reader, "Qualification");

                                lblMONETORPositionValue.Text = GetSafeString(reader, "Specialty"); // التخصص
                            }
                            else
                            {
                                MessageBox.Show("لم يتم العثور على بيانات لهذا المستخدم (ID: " + Session.CurrentUserId + ")");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // عرض رسالة الخطأ بالتفصيل لنعرف السبب
                MessageBox.Show("حدث خطأ أثناء القراءة:\n" + ex.Message);
            }
        }

        // =========================================================
        // دالة سحرية: تقرأ العمود فقط إذا كان موجوداً
        // =========================================================
        private string GetSafeString(SqlDataReader reader, string columnName)
        {
            // 1. نفحص هل العمود موجود أصلاً في النتيجة القادمة من السيكوال؟
            if (!HasColumn(reader, columnName))
            {
                return "---"; // علامة تدل أن العمود غير موجود
            }

            // 2. إذا كان موجوداً، هل قيمته NULL؟
            if (reader[columnName] == DBNull.Value)
            {
                return "غير محدد";
            }

            // 3. إرجاع القيمة كنص
            return reader[columnName].ToString();
        }

        // دالة مساعدة للتحقق من وجود العمود
        private bool HasColumn(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        // =========================================================
        // زر الطباعة (buttonPRINTR)
        // =========================================================
        private void buttonPRINTR_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF File|*.pdf";
                sfd.FileName = "ملف_الموجه_" + lblMONETORNameValue.Text.Trim();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4, 20, 20, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                        BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                        iTextSharp.text.Font cellFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        // العنوان
                        PdfPTable titleTable = new PdfPTable(1);
                        titleTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                        titleTable.DefaultCell.Border = Rectangle.NO_BORDER;
                        PdfPCell titleCell = new PdfPCell(new Phrase("بطاقة الموجه الشخصية", titleFont));
                        titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        titleCell.Border = Rectangle.NO_BORDER;
                        titleCell.PaddingBottom = 20;
                        titleTable.AddCell(titleCell);
                        doc.Add(titleTable);

                        // الصورة (تأكد أن لديك PictureBox في التصميم باسم userPictureBox)
                        // إذا لم يكن موجوداً، احذف هذا الجزء
                      /*  
                        if (userAvatar.Image != null)
                        {
                            try {
                                Image pdfImg = Image.GetInstance(userAvatar.Image, System.Drawing.Imaging.ImageFormat.Png);
                                pdfImg.ScaleToFit(100f, 100f);
                                pdfImg.Alignment = Element.ALIGN_CENTER;
                                doc.Add(pdfImg);
                                doc.Add(new Paragraph("\n"));
                            } catch { } 
                        }
                        
*/
                        // الجدول
                        PdfPTable table = new PdfPTable(2);
                        table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                        table.WidthPercentage = 100;
                        table.SetWidths(new float[] { 2f, 1f });

                        // تعبئة البيانات باستخدام الأسماء الجديدة
                        AddCellToTable(table, "الاسم", lblMONETORNameValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "رقم القيد", lblMONETORIdRegistration_number.Text, headerFont, cellFont);
                        AddCellToTable(table, "تاريخ الميلاد", lblMONRTODobValuedata.Text, headerFont, cellFont);
                        AddCellToTable(table, "الجنس", lblMONETRORGenderValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "رقم الهاتف", lblCenterPhoneValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "البريد الإلكتروني", lblCenterEmailValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "المدينة/السكن", labelcity_value.Text, headerFont, cellFont);
                        AddCellToTable(table, "المؤهل/القسم", lblMONETORDeptValue.Text, headerFont, cellFont);
                        AddCellToTable(table, "التخصص/الوظيفة", lblMONETORPositionValue.Text, headerFont, cellFont);

                        doc.Add(table);
                        doc.Close();
                        writer.Close();

                        MessageBox.Show("تم التصدير بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ: " + ex.Message);
                    }
                }
            }
        }

        private void AddCellToTable(PdfPTable table, string label, string value, iTextSharp.text.Font fHead, iTextSharp.text.Font fVal)
        {
            PdfPCell c1 = new PdfPCell(new Phrase(label, fHead));
            c1.BackgroundColor = new BaseColor(52, 73, 94);
            c1.HorizontalAlignment = Element.ALIGN_CENTER;
            c1.Padding = 8;
            c1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(c1);

            PdfPCell c2 = new PdfPCell(new Phrase(value, fVal));
            c2.BackgroundColor = BaseColor.WHITE;
            c2.HorizontalAlignment = Element.ALIGN_CENTER;
            c2.Padding = 8;
            c2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(c2);
        }

        // زر تغيير الصورة
        private void btnEditPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // تأكد أنك أضفت PictureBox للتصميم، إذا لم يكن موجوداً احذف هذا السطر
                    // userPictureBox.Image = System.Drawing.Image.FromFile(ofd.FileName);
                }
            }
        }

        // زر الصفحة الرئيسية
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            // الكود الخاص بالعودة للصفحة الرئيسية
        }
    }
}