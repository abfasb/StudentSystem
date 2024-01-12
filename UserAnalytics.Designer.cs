namespace Student_Information_System
{
    partial class UserAnalytics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartEnrolled = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudPercentage = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblAdminPercentage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picCollege = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnrolled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCollege)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEnrolled
            // 
            this.chartEnrolled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartEnrolled.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEnrolled.Legends.Add(legend1);
            this.chartEnrolled.Location = new System.Drawing.Point(223, 382);
            this.chartEnrolled.Name = "chartEnrolled";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderWidth = 0;
            series1.LabelForeColor = System.Drawing.Color.Gold;
            series1.Legend = "Legend1";
            series1.Name = "Enrolled";
            this.chartEnrolled.Series.Add(series1);
            this.chartEnrolled.Size = new System.Drawing.Size(1479, 822);
            this.chartEnrolled.TabIndex = 0;
            this.chartEnrolled.Text = "chart1";
            title1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Month";
            title1.Text = "Enrolled Monthly";
            title2.Name = "Enrolled";
            this.chartEnrolled.Titles.Add(title1);
            this.chartEnrolled.Titles.Add(title2);
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPie.Legends.Add(legend2);
            this.chartPie.Location = new System.Drawing.Point(1207, 49);
            this.chartPie.Name = "chartPie";
            this.chartPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "StudentsByCollege";
            this.chartPie.Series.Add(series2);
            this.chartPie.Size = new System.Drawing.Size(356, 287);
            this.chartPie.TabIndex = 1;
            this.chartPie.Text = "chart2";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            title3.Name = "Month";
            title3.Text = "Colleges Analytics";
            this.chartPie.Titles.Add(title3);
            this.chartPie.Click += new System.EventHandler(this.chartPie_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblStudPercentage);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(92, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 164);
            this.panel1.TabIndex = 6;
            // 
            // lblStudPercentage
            // 
            this.lblStudPercentage.AutoSize = true;
            this.lblStudPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblStudPercentage.Font = new System.Drawing.Font("Rockwell", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblStudPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblStudPercentage.Location = new System.Drawing.Point(92, 100);
            this.lblStudPercentage.Name = "lblStudPercentage";
            this.lblStudPercentage.Size = new System.Drawing.Size(57, 22);
            this.lblStudPercentage.TabIndex = 11;
            this.lblStudPercentage.Text = "867%";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblStudent.Font = new System.Drawing.Font("Rockwell", 28.25F, System.Drawing.FontStyle.Bold);
            this.lblStudent.ForeColor = System.Drawing.Color.Black;
            this.lblStudent.Location = new System.Drawing.Point(87, 50);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(117, 47);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "5,390";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.label4.Location = new System.Drawing.Point(70, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Students";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Student_Information_System.Properties.Resources.Group_427318856;
            this.pictureBox1.Location = new System.Drawing.Point(16, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lblAdmin);
            this.panel2.Controls.Add(this.lblAdminPercentage);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(848, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 164);
            this.panel2.TabIndex = 7;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Rockwell", 28.25F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblAdmin.Location = new System.Drawing.Point(104, 50);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(117, 47);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "5,390";
            // 
            // lblAdminPercentage
            // 
            this.lblAdminPercentage.AutoSize = true;
            this.lblAdminPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPercentage.Font = new System.Drawing.Font("Rockwell", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblAdminPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.lblAdminPercentage.Location = new System.Drawing.Point(125, 100);
            this.lblAdminPercentage.Name = "lblAdminPercentage";
            this.lblAdminPercentage.Size = new System.Drawing.Size(57, 22);
            this.lblAdminPercentage.TabIndex = 12;
            this.lblAdminPercentage.Text = "876%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(94, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Admins";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Student_Information_System.Properties.Resources.Group_427318855;
            this.pictureBox2.Location = new System.Drawing.Point(21, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 53);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(478, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 164);
            this.panel3.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 28.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(121, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 47);
            this.label8.TabIndex = 13;
            this.label8.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(90, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Colleges";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Student_Information_System.Properties.Resources.Group_427318854;
            this.pictureBox3.Location = new System.Drawing.Point(23, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 53);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::Student_Information_System.Properties.Resources.ic_outline_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(1140, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(61, 54);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picCollege
            // 
            this.picCollege.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picCollege.Location = new System.Drawing.Point(589, 90);
            this.picCollege.Name = "picCollege";
            this.picCollege.Size = new System.Drawing.Size(0, 0);
            this.picCollege.TabIndex = 4;
            this.picCollege.TabStop = false;
            this.picCollege.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // UserAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picCollege);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.chartEnrolled);
            this.Name = "UserAnalytics";
            this.Size = new System.Drawing.Size(1616, 1073);
            this.Load += new System.EventHandler(this.UserAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEnrolled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCollege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnrolled;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCollege;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblStudPercentage;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblAdminPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
    }
}
