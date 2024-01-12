using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Information_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            BorderRadius.ApplyBorderRadius(btnRegister, 30);
        }
        private void decreaseFont ()
        {
            txtName.Font = new Font(txtName.Font.FontFamily, txtName.Font.Size - 6, txtName.Font.Style);
            txtPassword.Font = new Font(txtPassword.Font.FontFamily, txtPassword.Font.Size - 6, txtPassword.Font.Style);
        }
        private void userRegister1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Enter your name";
                txtName.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Enter your password";
                txtPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm("Student");
            this.Hide();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegistration adm = new AdminRegistration();
            adm.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            authenticateUser();
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                txtPassword.PasswordChar = default;
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                authenticateUser();
            }
        }
        public void authenticateUser ()
        {
            Database db = new Database();
            string Email = txtName.Text;
            bool hashPass = db.VerifyPassword(txtPassword.Text, Email);
            bool userExists = db.CheckUserExists(txtName.Text);
            if (userExists)
            {
                if (hashPass)
                {
                    MessageBox.Show("Login Successfully!");
                    this.Hide();
                    MainForm frm = new MainForm("Admin");
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Username does not exist. Please try again later");
            }
        }
    }
}
