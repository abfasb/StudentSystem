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
    public partial class UserAdminPanel : UserControl
    {
        Database db = new Database();
        public UserAdminPanel()
        {
            InitializeComponent();
        }
        public void displayData()
        {
            string sql = "Select Username AS AdminName, Age, Role AS Postion, Gender, Phone_Number, Department FROM tblAdmin";
            dataGridView1.DataSource = db.selectTable(sql);
        }
        public void displayDataLabel(string clauseName)
        {
            string sql = $"Select Username AS AdminName, Age, Role AS Postion, Gender, Phone_Number, Department FROM tblAdmin WHERE Department = '{clauseName}'";
            dataGridView1.DataSource = db.selectTable(sql);
        }
        private void UserAdminPanel_Load(object sender, EventArgs e)
        {
            hidePic();
            displayData();
            displayLabelAdmin();
            designDGridview();
        }
        public void hidePic ()
        {
            picLib.Visible = false;
            picRegistrar.Visible = false;
            picSecurity.Visible = false;
            picOthers.Visible = false;
        }
        public void hideAndDisplayPic(PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5)
        {
            pic1.Visible = true;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
        }
        public void displayLabelAdmin () {
            Database db = new Database();
            lblRegistrar.Text = db.countAdmin("Registrar").ToString();
            lblLibrarian.Text = db.countAdmin("Librarian").ToString();
            lblRegistrar.Text = db.countAdmin("Guard").ToString();
        }
        public void designDGridview ()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 102, 153);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Rockwell", 9);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dataGridView1.RowHeadersDefaultCellStyle.Font = new Font("Rockwell", 8);
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 102, 153);
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            hideAndDisplayPic(picRegistrar, picAll, picLib, picOthers, picSecurity);
            displayDataLabel("Registrar");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            hideAndDisplayPic(picLib, picAll, picRegistrar, picOthers, picSecurity);
            displayDataLabel("Library");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            hideAndDisplayPic(picSecurity, picAll, picLib, picOthers, picRegistrar);
            displayDataLabel("Security");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            hideAndDisplayPic(picOthers, picAll, picLib, picRegistrar, picSecurity);
            displayDataLabel("Others");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            hideAndDisplayPic(picAll, picRegistrar, picLib, picOthers, picSecurity);
            displayData();
        }

        private void btnViewStud_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            UserAdmin user1 = new UserAdmin();
            user1.Show();
            this.Visible = false;
            user1.BringToFront();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            hideAndDisplayPic(picAll, picRegistrar, picLib, picOthers, picSecurity);
            displayData();
        }
    }
}
