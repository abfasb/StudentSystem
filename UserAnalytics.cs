using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Student_Information_System
{
    public partial class UserAnalytics : UserControl
    {
        public UserAnalytics()
        {
            InitializeComponent();

            BorderRadius.ApplyBorderRadiusPanel(panel1, 10);
            BorderRadius.ApplyBorderRadiusPanel(panel2, 10);
            BorderRadius.ApplyBorderRadiusPanel(panel3, 10);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void CustomizeChart(Chart chart)
        {
            chart.Size = new Size(1043, 519);
            chart.BackColor = Color.LightGreen;
            chart.BackSecondaryColor = Color.DarkGreen; 
            chart.BackGradientStyle = GradientStyle.TopBottom;
            ChartArea chartArea = chart.ChartAreas[0];
            chartArea.BackColor = Color.Transparent;
            Series series = chart.Series["Enrolled"];
            series.ChartType = SeriesChartType.Column; 
            Color[] seriesColors = new Color[] { Color.Blue, Color.Red, Color.Green, Color.Orange, Color.Purple, Color.Yellow };
            for (int i = 0; i < series.Points.Count; i++)
            {
                series.Points[i].Color = seriesColors[i % seriesColors.Length];
            }
            chart.Titles.Add("2023 - 2024");
            chart.Titles[0].ForeColor = Color.Black;
            chart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            series.Color = Color.FromArgb(255, 215, 0);
            Legend legend = chart.Legends[0];
            legend.Enabled = true;
            legend.Font = new Font("Arial", 10);
            legend.ForeColor = Color.Black;
            series.LabelForeColor = Color.White;
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font(chart.ChartAreas[0].AxisX.LabelStyle.Font, FontStyle.Bold);
            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font(chart.ChartAreas[0].AxisY.LabelStyle.Font, FontStyle.Bold);


        }

        private void UserAnalytics_Load(object sender, EventArgs e)
        {

            Database db = new Database();
            CustomizeChart(chartEnrolled);
            lblDisplay();
            displayLoadChartData();
            db.populatePieChartData(chartPie);
        }
        public void displayLoadChartPie ()
        {

        }
        public void displayLoadChartData()
        {

            Database db = new Database();
            db.PopulateChartFromData(chartEnrolled);
            chartEnrolled.ChartAreas[0].AxisX.Minimum = 0;
            chartEnrolled.ChartAreas[0].AxisX.Maximum = 11;
            chartEnrolled.ChartAreas[0].AxisX.Interval = 1;
            chartEnrolled.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartEnrolled.Series["Enrolled"].BorderWidth = 2;
            chartEnrolled.Series["Enrolled"].MarkerSize = 8;

        }
        public void lblDisplay()
        {

            Database db = new Database();
            lblStudent.Text = Convert.ToInt32(db.getTotalRecord("tblStudent")).ToString();
            lblAdmin.Text = Convert.ToInt32(db.getTotalRecord("tblAdmin")).ToString();
            lblStudPercentage.Text = $"{calculateStudentPercentage():F2}%";
            lblAdminPercentage.Text = $"{calculateAdminPercentage():F2}%";
        }
        public float calculateAdminPercentage()
        {

            Database db = new Database();
            int studentRecord = db.getTotalRecord("tblStudent");
            int adminRecord = db.getTotalRecord("tblAdmin");

            if (studentRecord + adminRecord == 0)
            {
                return 0;
            }
            float adminPercentage = ((float)adminRecord / (adminRecord + studentRecord)) * 100;
            return adminPercentage;

        }
        public float calculateStudentPercentage()
        {

            Database db = new Database();
            int studentRecord = db.getTotalRecord("tblStudent");
            int adminRecord = db.getTotalRecord("tblAdmin");

            if (studentRecord + adminRecord == 0)
            {
                return 0;
            }
            float adminPercentage = ((float)studentRecord / (studentRecord + adminRecord)) * 100;
            return adminPercentage;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            lblDisplay();
            displayLoadChartData();
            db.populatePieChartData(chartPie);
        }

        private void chartPie_Click(object sender, EventArgs e)
        {

        }
    }
}
