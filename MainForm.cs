using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Information_System
{
    public partial class MainForm : Form
    {
        public MainForm(string roleUniv)
        {
            InitializeComponent();
            panelNav.Paint += Panel1_Paint;
            if (roleUniv == "Admin")
            {
                adminLogin();
                picDashboard.Visible = false;
                picDashboard.SendToBack();
            }
            else if (roleUniv == "Student"){
                studentLogin();
                picDashboard.Visible = true;
            }
        }
        private void UserControl1_ButtonClicked(object sender, EventArgs e)
        {
        }
        public void applyBorderBtn()
        {
            BorderRadius.ApplyBorderRadius(btnDashboard, 15);
            BorderRadius.ApplyBorderRadius(btnLogout, 15);
            BorderRadius.ApplyBorderRadius(btnColleges, 15);
            BorderRadius.ApplyBorderRadius(btnStudents, 15);
            BorderRadius.ApplyBorderRadius(btnAnalytics, 15);
            BorderRadius.ApplyBorderRadius(btnDocumentation, 15);
            BorderRadius.ApplyBorderRadius(btnAdmin, 15);
        }
        public void adminLogin ()
        {
            btnAdmin.BackColor = Color.FromArgb(60, 223, 19);
            hideUserControl(userAdmin1, userCollege1, userStudent1, userAnalytics1, userDocumentation1);
            userDashboard1.Visible = false;
            btnDashboard.Enabled = false;
            btnColleges.Enabled = false;
            btnStudents.Enabled = false;
            btnAnalytics.Enabled = false;
            btnDocumentation.Enabled = false;
            btnAdmin.ForeColor = Color.White;
        }
        public void studentLogin ()
        {
            btnDashboard.BackColor = Color.FromArgb(60, 223, 19);
            userDashboard1.Visible = true;
            btnAdmin.Enabled = false;
            userDashboard1.BringToFront();
            hideUserControl(userDashboard1, userCollege1, userStudent1, userAnalytics1, userDocumentation1);
        }
        public void hideUserControl (UserControl userControl1, UserControl userControl2, UserControl userControl3, UserControl userControl4, UserControl userControl5)
        {
            userControl1.BringToFront();
            userControl1.Visible = true;
            userControl2.Visible = false;
            userControl3.Visible = false;
            userControl4.Visible = false;
            userControl5.Visible = false;
            button1.BringToFront();
            btnMinimize.BringToFront();
            btnMaximize.BringToFront();
        }
        public void showAndHideBtnColor (Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            button1.BackColor = Color.FromArgb(60, 223, 19);
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
        }
        public void showAndHidePic (PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5)
        {
            pic1.Visible = true;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pictureBox3.BringToFront();
        }
        public void hidePic ()
        {
            picDashboard.Visible = false;
            picCollege.Visible = false;
            picStud.Visible = false;
            picAnalytics.Visible = false;
            picHelp.Visible = false;
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(panelNav.ClientRectangle, Color.FromArgb(31, 85, 23), Color.FromArgb(31, 85, 23), LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panelNav.ClientRectangle);
            }
        }
        private void visibleUserControl (UserControl userControl1, UserControl userControl2, UserControl userControl3, UserControl userControl4, UserControl userControl5)
        {
            
        }
        public void designOfDGridView ()
        {
            
                /*dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 14, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 102, 153);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.DefaultCellStyle.Font = new Font("Rockwell", 14);
                dataGridView1.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
                dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Rockwell", 12);
                dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 102, 153);
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.RowTemplate.Height = 40;
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.GridColor = Color.Silver;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            */
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BorderRadius.ApplyBorderRadiusPanel(panelNav, 10);
            applyBorderBtn();
            hidePic();
            picDashboard.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            btnDashboard.BackColor = Color.FromArgb(60, 223, 19);
           hideUserControl(userDashboard1, userCollege1, userStudent1, userAnalytics1, userDocumentation1);
            showAndHideBtnColor(btnDashboard, btnColleges, btnStudents, btnAnalytics, btnDocumentation);
            showAndHidePic(picDashboard, picCollege, picStud, picAnalytics, picHelp);
        }

        private void btnColleges_Click(object sender, EventArgs e)
        {
            btnColleges.BackColor = Color.FromArgb(60, 223, 19);
            hideUserControl(userCollege1, userDashboard1, userStudent1, userAnalytics1, userDocumentation1);
            showAndHideBtnColor(btnColleges, btnDashboard, btnStudents, btnAnalytics, btnDocumentation);
            showAndHidePic(picCollege, picDashboard, picStud, picAnalytics, picHelp);

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            btnStudents.BackColor = Color.FromArgb(60, 223, 19);
            hideUserControl(userStudent1, userDashboard1, userCollege1, userAnalytics1, userDocumentation1);
            showAndHideBtnColor(btnStudents, btnColleges, btnDashboard, btnAnalytics, btnDocumentation);
            showAndHidePic(picStud, picCollege, picDashboard, picAnalytics, picHelp);

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(60, 223, 19);
           hideUserControl(userAnalytics1, userDashboard1, userStudent1, userCollege1, userDocumentation1);
            showAndHideBtnColor(btnAnalytics, btnColleges, btnStudents, btnDashboard, btnDocumentation);
            showAndHidePic(picAnalytics, picCollege, picDashboard, picStud, picHelp);
        }

        private void btnDocumentation_Click(object sender, EventArgs e)
        {
            btnDocumentation.BackColor = Color.FromArgb(60, 223, 19);
           hideUserControl(userDocumentation1, userDashboard1, userStudent1, userCollege1, userAnalytics1);
            showAndHideBtnColor(btnDocumentation, btnColleges, btnStudents, btnAnalytics, btnDashboard);
            showAndHidePic(picHelp, picCollege, picDashboard, picAnalytics, picStud);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            this.Hide();
            logForm.Show();
        }

        private void userStudent1_Load(object sender, EventArgs e)
        {
          //  userControl2.displayData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void userStudent1_Load_1(object sender, EventArgs e)
        {

        }

        private void picHelp_Click(object sender, EventArgs e)
        {

        }

        private void picAnalytics_Click(object sender, EventArgs e)
        {

        }

        private void picStud_Click(object sender, EventArgs e)
        {

        }

        private void picCollege_Click(object sender, EventArgs e)
        {

        }
    }
}
