namespace Student_Information_System
{
    partial class UserStudent
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
            this.btnAddStud = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userAddStudent1 = new Student_Information_System.UserAddStudent();
            this.userEditStudentcs1 = new Student_Information_System.UserEditStudentcs();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStud
            // 
            this.btnAddStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnAddStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStud.FlatAppearance.BorderSize = 0;
            this.btnAddStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStud.Font = new System.Drawing.Font("Candara Light", 18.25F);
            this.btnAddStud.ForeColor = System.Drawing.Color.White;
            this.btnAddStud.Location = new System.Drawing.Point(1124, 206);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(191, 36);
            this.btnAddStud.TabIndex = 15;
            this.btnAddStud.Text = "Edit Student";
            this.btnAddStud.UseVisualStyleBackColor = false;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara Light", 18.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1339, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1502, 775);
            this.dataGridView1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.textBox1.Location = new System.Drawing.Point(346, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1013, 43);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "ALL",
            "Male Students",
            "Female Students"});
            this.cmbFilter.Location = new System.Drawing.Point(189, 123);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(161, 43);
            this.cmbFilter.TabIndex = 19;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 33.25F);
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 18.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(373, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter Stud Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 18.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(212, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Student_Information_System.Properties.Resources.Vector__31_;
            this.pictureBox1.Location = new System.Drawing.Point(1323, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // userAddStudent1
            // 
            this.userAddStudent1.BackColor = System.Drawing.Color.White;
            this.userAddStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAddStudent1.Location = new System.Drawing.Point(0, 0);
            this.userAddStudent1.Name = "userAddStudent1";
            this.userAddStudent1.Size = new System.Drawing.Size(1616, 1073);
            this.userAddStudent1.TabIndex = 25;
            this.userAddStudent1.Visible = false;
            // 
            // userEditStudentcs1
            // 
            this.userEditStudentcs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userEditStudentcs1.Location = new System.Drawing.Point(0, 0);
            this.userEditStudentcs1.Name = "userEditStudentcs1";
            this.userEditStudentcs1.Size = new System.Drawing.Size(1616, 1073);
            this.userEditStudentcs1.TabIndex = 24;
            this.userEditStudentcs1.Visible = false;
            // 
            // UserStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddStud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userAddStudent1);
            this.Controls.Add(this.userEditStudentcs1);
            this.Name = "UserStudent";
            this.Size = new System.Drawing.Size(1616, 1073);
            this.Load += new System.EventHandler(this.UserStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserEditStudentcs userEditStudentcs1;
        private UserAddStudent userAddStudent1;
    }
}
