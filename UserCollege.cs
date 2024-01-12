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
    public partial class UserCollege : UserControl
    {
        public UserCollege()
        {
            InitializeComponent();
            BorderRadius.ApplyBorderRadiusPanel(panelBoard, 10);
            BorderRadius.ApplyBorderRadiusPanel(panelCCS, 14);
            BorderRadius.ApplyBorderRadiusPanel(panelCbm, 14);
            BorderRadius.ApplyBorderRadiusPanel(panelCas, 14);
            BorderRadius.ApplyBorderRadiusPanel(panelCcje, 14);
            BorderRadius.ApplyBorderRadiusPanel(panelBTE, 14);
            BorderRadius.ApplyBorderRadiusPanel(panelBTVTED, 14);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserCollege_Load(object sender, EventArgs e)
        {
            displayLabelGender();
            displayRankings();
        }

        public void displayLabelGender ()
        {
            double countMale = displayGender("Male");
            double countFemale = displayGender("Female");
            lblMale.Text = $"Male ({countMale:F2}%)";
            lblFemale.Text = $"Female ({countFemale:F2}%)";
        }
        public double displayGender (string gender)
        {

            Database db = new Database();
            double calculatePercentage;
            int maleCount = db.getTotalRecordGender("Male");
            int femaleCount = db.getTotalRecordGender("Female");
            int totalCount = maleCount + femaleCount;
            if (gender == "Male")
            {
                calculatePercentage = (double)maleCount / totalCount * 100;
            }
            else
            {
                calculatePercentage = (double)femaleCount / totalCount * 100;
            }
            return calculatePercentage;

        }
        private void label13_Click(object sender, EventArgs e)
        {
            displayCollege("CCJE");
        }

        private void panelCCS_Paint(object sender, PaintEventArgs e)
        {

        }
        public void displayRankings()
        {

            Database db = new Database();
            int topRankings = 6;

            List<string> collegeNames = db.displayCollegeByPopulation(topRankings);

            if (collegeNames.Count >= 1)
            {
                lblFirstRanking.Text = collegeNames[0];
            }
            else
            {
                lblFirstRanking.Text = "No data available";
            }

            if (collegeNames.Count >= 2)
            {
                lblSecondRanking.Text = collegeNames[1];
            }
            else
            {
                lblSecondRanking.Text = "No data available";
            }

            if (collegeNames.Count >= 3)
            {
                lblThirdRanking.Text = collegeNames[2];
            }
            else
            {
                lblThirdRanking.Text = "No data available";
            }

            if (collegeNames.Count >= 4)
            {
                lblFourthRanking.Text = collegeNames[3];
            }
            else
            {
                lblFourthRanking.Text = "No data available";
            }

            if (collegeNames.Count >= 5)
            {
                lblFifthRanking.Text = collegeNames[4];
            }
            else
            {
                lblFifthRanking.Text = "No data available";
            }

            if (collegeNames.Count >= 6)
            {
                lblSixthRanking.Text = collegeNames[5];
            }
            else
            {
                lblSixthRanking.Text = "No data available";
            }
        }
        public void displayCollege(string tableName)
        {
            UserDisplayCollege userDisplayCollege1 = new UserDisplayCollege(tableName);
            userDisplayCollege1.Show();
            this.Controls.Add(userDisplayCollege1);
            userDisplayCollege1.BringToFront();
        }
        private void panelCCS_Click(object sender, EventArgs e)
        {
            displayCollege("CCS");
        }

        private void panelCbm_Click(object sender, EventArgs e)
        {
            displayCollege("CBM");
        }
        private void panelCas_Click(object sender, EventArgs e)
        {
            displayCollege("CAS");
        }

        private void panelCcje_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCcje_Click(object sender, EventArgs e)
        {
            displayCollege("CCJE");
        }

        private void panelBTVTED_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBTVTED_Click(object sender, EventArgs e)
        {
            displayCollege("BTVTED");
        }

        private void panelBTE_Click(object sender, EventArgs e)
        {
            displayCollege("BTE");
        }

        private void lblFirstRanking_Click(object sender, EventArgs e)
        {

        }

        private void panelCbm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displayCollege("CCS");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            displayCollege("CCS");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            displayCollege("CCS");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displayCollege("CBM");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            displayCollege("CBM");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            displayCollege("CBM");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            displayCollege("CAS");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displayCollege("CAS");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            displayCollege("CAS");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displayCollege("CCJE");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            displayCollege("CCJE");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displayCollege("BTVTED");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            displayCollege("BTVTED");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            displayCollege("BTVTED");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displayCollege("CTE");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            displayCollege("CTE");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            displayCollege("CTE");
        }
    }
}
