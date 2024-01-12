using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class UserStudent : UserControl
    {
        public UserStudent()
        {
            InitializeComponent();
        }

        private void UserStudent_Load(object sender, EventArgs e)
        {
            dGridView();
            displayData();
        }

        public void dGridView ()
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
        public void displayDataFilter(string filterData)
        {
            Database db = new Database();
            string sql;
            if (filterData == "Female" || filterData == "Male")
            {
                sql = $"Select GenerateId, FirstName, LastName, Age, Email, Municipality, PhoneNumber, Gender, Course FROM tblStudent WHERE Gender = '{filterData}' ORDER BY GenerateId ASC";
            }
            else
            {
                sql = "Select GenerateId, FirstName, LastName, Age, Email, Municipality, PhoneNumber, Gender, Course FROM tblStudent ORDER BY GenerateId ASC";
            }
            dataGridView1.DataSource = db.selectTable(sql);
        }
        public void displayData()
        {
            Database db = new Database();
            string sql = "Select GenerateId, FirstName, LastName, Age, Email, Municipality, PhoneNumber, Gender, Course FROM tblStudent ORDER BY GenerateId ASC";

            dataGridView1.DataSource = db.selectTable(sql);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterData = "", selectedFilter;
            selectedFilter = cmbFilter.SelectedItem.ToString();
            if (selectedFilter == "Male Students")
            {
                filterData = "Male";
            }
            else if (selectedFilter == "Female Students")
            {
                filterData = "Female";
            }
            displayDataFilter(filterData);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Database db = new Database();
            string filterData = "", selectedFilter;
            selectedFilter = cmbFilter.SelectedItem?.ToString();
            if (selectedFilter == "Male Students")
            {
                filterData = "Male";
            }
            else if (selectedFilter == "Female Students")
            {
                filterData = "Female";
            }
            string filterCondition = string.IsNullOrWhiteSpace(filterData) ? "" : $" AND Gender = '{filterData}'";
            string sql = $"SELECT GenerateId, FirstName, LastName, Age, Email, Municipality, Province, PhoneNumber, Gender, Course FROM tblStudent WHERE GenerateID LIKE '%{textBox1.Text}%' {filterCondition} ORDER BY GenerateId ASC";
            dataGridView1.DataSource = db.selectTable(sql);
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            userEditStudentcs1.Visible = true;
            userEditStudentcs1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userAddStudent1.Visible = true;
            userAddStudent1.BringToFront();
            userEditStudentcs1.Visible = false;
        }

        private void btnAddStud_Click_1(object sender, EventArgs e)
        {
            userEditStudentcs1.Visible = true;
            userEditStudentcs1.BringToFront();
            userAddStudent1.Visible = false;
        }
    }
}
