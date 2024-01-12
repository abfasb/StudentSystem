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

namespace Student_Information_System
{
    public partial class UserEditStudentcs : UserControl
    {

        public System.Drawing.Image uploadedImage;
        public UserEditStudentcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAddStudent userAddStudent1 = new UserAddStudent();
            userAddStudent1.Hide();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Database db = new Database();
            string sql = "SELECT FirstName, LastName, Email, Municipality, PhoneNumber, Gender, Course, PicId FROM tblStudent WHERE GenerateID = '" + txtSearch.Text + "'";
            DataTable tb = db.selectTable(sql);
            if (tb.Rows.Count > 0)
            {
                txtFirstName.Text = tb.Rows[0]["FirstName"].ToString();
                txtLastName.Text = tb.Rows[0]["LastName"].ToString();
                txtEmail.Text = tb.Rows[0]["Email"].ToString();
                cmbMunicipality.Text = tb.Rows[0]["Municipality"].ToString();
                txtPhoneNumber.Text = tb.Rows[0]["PhoneNumber"].ToString();
                string gender = tb.Rows[0]["Gender"].ToString();
                string imagePath = tb.Rows[0]["PicId"].ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    byte[] imageBytes = db.SelectBytes($"SELECT PicId FROM tblStudent WHERE GenerateID = '{txtSearch.Text}'");

                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDisplay.Image = Image.FromStream(ms);
                        }
                    }
                }
                if (gender == "Male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
            }
            else
            {
                txtFirstName.Text = String.Empty;
                txtLastName.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtPhoneNumber.Text = String.Empty;
                radioMale.Checked = false;
                radioFemale.Checked = false;
                cmbMunicipality.SelectedIndex = -1;
                picDisplay.Image = null;
            }
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
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
        public void displayData ()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtSearch.Clear();
            cmbMunicipality.SelectedIndex = -1;
            picDisplay.Image = null;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
                string realGender, FirstName, LastName, Email, Municipality, phoneNum, Gender;
                Database db = new Database();
                DateTime selectedDate = dateTimeOfBirth.Value;
                int age = CalculateAge(selectedDate, DateTime.Now);
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
                byte[] imageBytes = null;
                if (uploadedImage != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        uploadedImage.Save(ms, uploadedImage.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

            string hexImage = (imageBytes != null) ? BitConverter.ToString(imageBytes).Replace("-", "") : "NULL";

            string sql = $"UPDATE tblStudent SET FirstName = '{FirstName}', LastName = '{LastName}', Age = {age}, Email = '{Email}', Municipality = '{Municipality}', PhoneNumber = '{phoneNum}', Gender = '{Gender}', PicId = {(imageBytes != null ? $"0x{hexImage}" : "NULL")} WHERE GenerateID = '{txtSearch.Text}'";

            try
            {
                if (db.getData(sql) > 0)
                {
                    MessageBox.Show("Updated Successfully");
                    displayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

        private void UserEditStudentcs_Load(object sender, EventArgs e)
        {

        }
    }
}
