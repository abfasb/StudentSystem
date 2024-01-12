using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class UserDisplayCollege : UserControl
    {
        string storeTableName = string.Empty;
        Database db = new Database();
        public UserDisplayCollege(string tableName)
        {
            InitializeComponent();
            storeTableName = tableName;

        }
        public void displayData()
        {
            string sql = $"SELECT c.College_Id, c.CollegeName, s.FirstName, s.LastName, s.Age, s.Email, s.Municipality, s.PhoneNumber, s.Gender, s.Course, s.GenerateID FROM dbo.tblCollege c JOIN dbo.tblStudent s ON c.College_Id = s.Student_Id WHERE c.CollegeName = '{storeTableName}';";
            dGridCollege.DataSource = db.selectTable(sql);
        }

        private void UserDisplayCollege_Load(object sender, EventArgs e)
        {
            lblCollege.Text = conditionalForCollege(storeTableName);
            displayData();
            designDataGridView();
        }
        public void designDataGridView()
        {
            dGridCollege.EnableHeadersVisualStyles = false;
            dGridCollege.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 10, FontStyle.Bold);
            dGridCollege.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 102, 153);
            dGridCollege.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dGridCollege.DefaultCellStyle.Font = new Font("Rockwell", 9);
            dGridCollege.DefaultCellStyle.BackColor = Color.White;
            dGridCollege.DefaultCellStyle.ForeColor = Color.Black;
            dGridCollege.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dGridCollege.RowHeadersDefaultCellStyle.Font = new Font("Rockwell", 8);
            dGridCollege.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 102, 153);
            dGridCollege.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dGridCollege.RowTemplate.Height = 40;
            dGridCollege.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridCollege.BorderStyle = BorderStyle.None;
            dGridCollege.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGridCollege.GridColor = Color.Silver;
            dGridCollege.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public string conditionalForCollege (string tblName)
        {
            string storeTableNamee = "";
            if (tblName == "CCS")
            {
                storeTableNamee = "Computer of College Studies";
            }
            else if (tblName == "CBM")
            {
                storeTableNamee = "College of Business Management";
            }
            else if (tblName == "CAS")
            {
                storeTableNamee = "College of Arts and Sciences";
            }
            else if (tblName == "CCJE")
            {
                storeTableNamee = "College of Criminal Justice Education";
            }
            else if (tblName == "BTVTED")
            {
                storeTableNamee = "Bachelor of Technical Vocational Education";
            }
            else if (tblName == "CTE")
            {
                storeTableNamee = "College of Teacher Education";
            }
            return storeTableNamee;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT c.College_Id, c.CollegeName, s.FirstName, s.LastName, s.Age, s.Email, s.Municipality, s.PhoneNumber, s.Gender, s.Province, s.Course, s.GenerateID FROM dbo.tblCollege c JOIN dbo.tblStudent s ON c.College_Id = s.Student_Id WHERE (s.FirstName LIKE '%{txtSearch.Text}%' OR s.LastName LIKE '%{txtSearch.Text}%') AND c.CollegeName = '{storeTableName}'";
            dGridCollege.DataSource = db.selectTable(sql);
        }
    }
}
