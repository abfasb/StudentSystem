using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Student_Information_System
{
    public partial class AdminRegistration : Form
    {
        Database db = new Database();
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username, password, phoneNumber, gender, department, roleUniv, textEmail;
            username = txtUsername.Text;
            password = db.HashPassword(txtPassword.Text);
            phoneNumber = txtNumber.Text;
            textEmail = txtEmail.Text;
            gender = cmbGender.Text;
            department = cmbDepartment.Text;
            roleUniv = txtRole.Text;
            int age = int.Parse(txtAge.Text);
            string sql = $"INSERT INTO tblAdmin VALUES ('{username}', '{password}', '{phoneNumber}', '{gender}', '{department}', '{roleUniv}', {age}, '{textEmail}')";
            if (db.getData(sql) > 0)
            {
                MessageBox.Show("Congrats you just succesfully registered as one of the admin in our univeristy!");
                cleanData();
            } 
            else
            {
                MessageBox.Show("Something went wrong. Try again later.");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        private void AdminRegistration_Load(object sender, EventArgs e)
        {

        }
        private void cleanData ()
        {
            txtAge.Clear();
            txtEmail.Clear();
            txtNumber.Clear();
            txtPassword.Clear();
            txtRole.Clear();
            txtUsername.Clear();
        }
       
    }
}
