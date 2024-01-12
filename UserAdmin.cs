using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Information_System
{
    public partial class UserAdmin : UserControl
    {
        public UserAdmin()
        {
            InitializeComponent();
            btnPrint.Click += (s, ev) => PrintInformation();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            userAdminPanel1.Visible = true;
         userAdminPanel1.BringToFront();
        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            designdGridView();
            displayData();
        }
        public void designdGridView ()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 85, 23);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Rockwell", 9);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Rockwell", 8);
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 85, 23);
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        public void displayData()
        {

            Database db = new Database();
            string sql = "Select GenerateID, FirstName, LastName, Course, Gender, Municipality, Age, PhoneNumber FROM tblStudent";
            dataGridView1.DataSource = db.selectTable(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete it? The students will automatically be wiped out from the system.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string sql = $"DELETE FROM tblStudent WHERE GenerateID = '{lblStudId.Text}'";
                if (db.getData(sql) > 0)
                {
                    MessageBox.Show("Delete Successfully!");
                    displayData();
                }
            }
            
        }

        private void userAdminPanel1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Database db = new Database();
            lblStudId.Text = dataGridView1[0, e.RowIndex].Value.ToString(); 
            lblFirstName.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            lblLastName.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            lblCourse.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            lblGender.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            lblMunicipality.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            lblAge.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            lblPhoneNumber.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            string generatedID = lblStudId.Text;
            string sql = $"SELECT PicId FROM tblStudent WHERE GenerateID = '{generatedID}'";
            byte[] imageBytes = (byte[])db.executeRealScalar(sql);

            Image image;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                image = Image.FromStream(ms);
            }

            picDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            picDisplay.Image = image;

        }
       private void PrintInformation()
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (s, ev) =>
            {
                try
                {
                    int margin = 40;
                    int topMargin = 50;
                    int pageWidth = ev.PageBounds.Width;
                    int pageHeight = ev.PageBounds.Height;

                    ev.Graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, pageWidth, pageHeight));

                    StringFormat stringFormatCenter = new StringFormat();
                    stringFormatCenter.Alignment = StringAlignment.Center;

                    StringFormat stringFormatLeft = new StringFormat();
                    stringFormatLeft.Alignment = StringAlignment.Near;

                    using (Font fontTitle = new Font("Arial", 16, FontStyle.Bold))
                    using (Font fontContent = new Font("Arial", 12))
                    using (Font fontContentBold = new Font("Arial", 12, FontStyle.Bold))
                    {
                        Brush textBrush = Brushes.Black;
                        int pictureSize = 250;
                        int pictureX = pageWidth - margin - pictureSize;
                        int pictureY = topMargin;
                        GraphicsPath path = new GraphicsPath();
                        path.AddEllipse(pictureX, pictureY, pictureSize, pictureSize);
                        ev.Graphics.SetClip(path);
                        ev.Graphics.DrawImage(picDisplay.Image, new Rectangle(pictureX, pictureY, pictureSize, pictureSize));
                        ev.Graphics.ResetClip();
                        ev.Graphics.DrawString("STUDENT INFORMATION", fontTitle, textBrush, new PointF(pageWidth / 2, topMargin), stringFormatCenter);

                        topMargin += 100;

                        ev.Graphics.DrawString($"Student ID:    {lblStudId.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                        topMargin += 40;

                        ev.Graphics.DrawString($"First Name:    {lblFirstName.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                        topMargin += 40;

                        ev.Graphics.DrawString($"Last Name:     {lblLastName.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                        topMargin += 40;

                        ev.Graphics.DrawString($"Course:    {lblCourse.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                        topMargin += 40;

                        ev.Graphics.DrawString($"Gender:    {lblGender.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                        topMargin += 40;

                        ev.Graphics.DrawString($"Municipality:  {lblMunicipality.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                        topMargin += 40;

                        ev.Graphics.DrawString($"Age:   {lblAge.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                        topMargin += 40;

                        ev.Graphics.DrawString($"Phone Number:      {lblPhoneNumber.Text}", fontContentBold, textBrush, new PointF(margin, topMargin), stringFormatLeft);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during print preview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintInformation();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayDAta();
        }
       
        public void displayDAta ()
        {

            Database db = new Database();
            string result = cmbGender.SelectedItem != null ? cmbGender.SelectedItem.ToString() : "";
            string result2 = cmbDepartment.SelectedItem != null ? cmbDepartment.SelectedItem.ToString() : "";
            string searchText = textBox1.Text.Trim();

            string sql;

            if (!string.IsNullOrEmpty(searchText))
            {
                sql = $"Select GenerateID, FirstName, LastName, Course, Gender, Municipality, Age, PhoneNumber FROM tblStudent WHERE GenerateId LIKE '%{textBox1.Text}%'";
            }
            else
            {
                if (result == "Male" || result == "Female")
                {
                    if (result2 == "BSED" || result2 == "BSIT" || result2 == "BSTM" || result2 == "BSHM" || result2 == "BTVTED" || result2 == "BSCRIM" || result2 == "AB PSYCH" || result2 == "AB ENGLISH")
                    {
                        sql = $"Select GenerateID, FirstName, LastName, Course, Gender, Municipality, Age, PhoneNumber FROM tblStudent WHERE Gender = '{result}' AND Course = '{result2}'";
                    }
                    else
                    {
                        sql = $"Select GenerateID, FirstName, LastName, Course, Gender, Municipality, Age, PhoneNumber FROM tblStudent WHERE Gender = '{result}'";
                    }
                }
                else
                {
                    sql = "Select GenerateID, FirstName, LastName, Course, Gender, Municipality, Age, PhoneNumber FROM tblStudent";
                }
            }

            dataGridView1.DataSource = db.selectTable(sql);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayDAta();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            displayDAta();
        }
    }
}
