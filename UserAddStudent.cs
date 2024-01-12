using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Student_Information_System
{
    public partial class UserAddStudent : UserControl
    {

        public System.Drawing.Image uploadedImage;
        public event EventHandler ButtonClicked;
        public UserAddStudent()
        {
            InitializeComponent();

        }

        private void UserAddStudent_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public void cleanInput ()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            picDisplay.Image = null;
            cmbCourse.SelectedIndex = -1;
            cmbMunicipality.SelectedIndex = -1;
            dateTimeOfBirth.Value = DateTimePicker.MinimumDateTime;

        }
        private void btnAddStud_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private int CalculateAge(DateTime birthdate, DateTime currentDate)
        {
            int age = currentDate.Year - birthdate.Year;
            if (currentDate < birthdate.AddYears(age))
            {
                age--;
            }

            return age;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string realGender, FirstName, LastName, Email, Municipality, phoneNum, Gender, Course, generateId;
            Database db = new Database();
            DateTime selectedDate = dateTimeOfBirth.Value;
            int age = CalculateAge(selectedDate, DateTime.Now);
            Course = cmbCourse.Text;
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            Email = txtEmail.Text;
            Municipality = cmbMunicipality.Text;
            phoneNum = txtPhoneNumber.Text;
            if (radioMale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            realGender = Gender;
            generateId = db.generatedId();
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                uploadedImage.Save(ms, uploadedImage.RawFormat);
                imageBytes = ms.ToArray();
            }

            string hexImage = BitConverter.ToString(imageBytes).Replace("-", "");
            string sql = $"INSERT INTO tblStudent (FirstName, LastName, Age, Email, Municipality, PhoneNumber, Gender, GenerateID, Course, PicId) " +
             $"OUTPUT INSERTED.Student_Id VALUES ('{FirstName}', '{LastName}', {age}, '{Email}', '{Municipality}', '{phoneNum}', '{realGender}', '{generateId}', '{Course}', 0x{hexImage})";

            int studentId = db.executeInsertWithOutput(sql, "Student_Id");

            if (studentId > 0)
            {
                MessageBox.Show("You just added a student");
               // UserStudent user = new UserStudent();
                //user.displayData();
                cleanInput();
            }
            string courseInsertSql = $"INSERT INTO tblCourse OUTPUT INSERTED.Course_Id VALUES ('{Course}')";
            int courseId = Convert.ToInt32(db.executeScalar(courseInsertSql));
            string enrollmentInsertSql = $"INSERT INTO tblEnrollment (StudentId, CourseId, EnrollmentDate) VALUES ({studentId}, {courseId}, GETDATE())";
            db.getData(enrollmentInsertSql);

            db.insertCollege(Course);
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    uploadedImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDisplay.Image = uploadedImage;

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }
    }
}
