using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public partial class frmAddStudent : System.Windows.Forms.Form
    {
        private string _connectionString;

        // The constructor now accepts the connection string
        public frmAddStudent(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            // Set default values for ComboBoxes
            cboNationality.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            // Generate the registration number when the form loads
            GenerateRegistrationNumber();
        }

        /// <summary>
        /// Generates a unique registration number based on a predefined format.
        /// </summary>
        private void GenerateRegistrationNumber()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    // Query to get the count of existing students to generate the next sequence
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Students", con);
                    int studentCount = (int)cmd.ExecuteScalar();
                    int nextSequence = studentCount + 1;

                    string year = DateTime.Now.ToString("yy"); // e.g., 25
                    string cityCode = "06"; // Placeholder for city code
                    string positionCode = "11"; // Placeholder for student code

                    // Format: YY-City-Position-Sequence (e.g., 2506110001)
                    string regNumber = $"{year}{cityCode}{positionCode}{nextSequence:D4}";
                    lblRegistrationNumber.Text = regNumber;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate registration number: \n" + ex.Message);
                lblRegistrationNumber.Text = "Error";
            }
        }

        /// <summary>
        /// Handles the change in nationality selection to update the ID label.
        /// </summary>
        private void cboNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNationality.SelectedItem.ToString() == "ليبي/ة")
            {
                lblNationalId.Text = "الرقم الوطني:";
            }
            else
            {
                lblNationalId.Text = "رقم جواز السفر:";
            }
        }

        /// <summary>
        /// Validates input and saves the new student data to the database.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Basic Validation
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtGuardianName.Text) ||
                string.IsNullOrWhiteSpace(txtNationalId.Text))
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول المطلوبة.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO Students 
                                    (FullName, GuardianName, BirthDate, TeacherName, Nationality, Residence, Gender, NationalID, StudentPhone, GuardianPhone, RegistrationNumber, Password, Status)
                                    VALUES 
                                    (@FullName, @GuardianName, @BirthDate, @TeacherName, @Nationality, @Residence, @Gender, @NationalID, @StudentPhone, @GuardianPhone, @RegistrationNumber, @Password, @Status)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@GuardianName", txtGuardianName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value);
                    cmd.Parameters.AddWithValue("@TeacherName", txtTeacherName.Text);
                    cmd.Parameters.AddWithValue("@Nationality", cboNationality.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Residence", txtResidence.Text);
                    cmd.Parameters.AddWithValue("@Gender", cboGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@NationalID", txtNationalId.Text);
                    cmd.Parameters.AddWithValue("@StudentPhone", txtStudentPhone.Text);
                    cmd.Parameters.AddWithValue("@GuardianPhone", txtGuardianPhone.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", lblRegistrationNumber.Text);
                    cmd.Parameters.AddWithValue("@Password", "0000"); // Default password
                    cmd.Parameters.AddWithValue("@Status", "Pending"); // New students are 'Pending' by default

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("تمت إضافة الطالب بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ بيانات الطالب: \n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
