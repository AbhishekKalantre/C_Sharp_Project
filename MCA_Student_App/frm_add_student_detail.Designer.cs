namespace MCA_Student_App
{
    partial class frm_add_student_detail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_student_detail));
            this.lbl_Add_Student_details = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Roll_no = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_mobile_no = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_Student_list = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.tb_Roll_no = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_Student_details
            // 
            this.lbl_Add_Student_details.AutoSize = true;
            this.lbl_Add_Student_details.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Student_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Add_Student_details.Location = new System.Drawing.Point(356, 37);
            this.lbl_Add_Student_details.Name = "lbl_Add_Student_details";
            this.lbl_Add_Student_details.Size = new System.Drawing.Size(437, 43);
            this.lbl_Add_Student_details.TabIndex = 0;
            this.lbl_Add_Student_details.Text = "Add Student Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.lbl_Add_Student_details);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MCA_Student_App.Properties.Resources._360_F_474199429_m6TfIkF9oVjqC267jT9tcNSn3IkRIi6e;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_User.Location = new System.Drawing.Point(7, 6);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(48, 17);
            this.lbl_User.TabIndex = 11;
            this.lbl_User.Text = "User";
            this.lbl_User.Click += new System.EventHandler(this.lbl_User_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Crimson;
            this.btn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOut.Font = new System.Drawing.Font("Sanskrit Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_LogOut.Location = new System.Drawing.Point(909, 9);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(169, 71);
            this.btn_LogOut.TabIndex = 11;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_Roll_no
            // 
            this.lbl_Roll_no.AutoSize = true;
            this.lbl_Roll_no.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_Roll_no.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_no.ForeColor = System.Drawing.Color.Linen;
            this.lbl_Roll_no.Location = new System.Drawing.Point(445, 132);
            this.lbl_Roll_no.Name = "lbl_Roll_no";
            this.lbl_Roll_no.Size = new System.Drawing.Size(150, 38);
            this.lbl_Roll_no.TabIndex = 2;
            this.lbl_Roll_no.Text = "Roll no";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_course.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.ForeColor = System.Drawing.Color.Linen;
            this.lbl_course.Location = new System.Drawing.Point(445, 533);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(131, 38);
            this.lbl_course.TabIndex = 3;
            this.lbl_course.Text = "Course";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_name.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Linen;
            this.lbl_name.Location = new System.Drawing.Point(445, 225);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(93, 38);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            // 
            // lbl_mobile_no
            // 
            this.lbl_mobile_no.AutoSize = true;
            this.lbl_mobile_no.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_mobile_no.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile_no.ForeColor = System.Drawing.Color.Linen;
            this.lbl_mobile_no.Location = new System.Drawing.Point(445, 328);
            this.lbl_mobile_no.Name = "lbl_mobile_no";
            this.lbl_mobile_no.Size = new System.Drawing.Size(188, 38);
            this.lbl_mobile_no.TabIndex = 5;
            this.lbl_mobile_no.Text = "Mobile no";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_dob.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.Color.Linen;
            this.lbl_dob.Location = new System.Drawing.Point(445, 427);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(131, 38);
            this.lbl_dob.TabIndex = 6;
            this.lbl_dob.Text = "D.O.B.";
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.BackColor = System.Drawing.Color.Purple;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Save.Location = new System.Drawing.Point(558, 619);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(262, 59);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightYellow;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Location = new System.Drawing.Point(7, 342);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(266, 59);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LightYellow;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Maroon;
            this.btn_refresh.Location = new System.Drawing.Point(7, 238);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(262, 59);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.Khaki;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(771, 221);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(267, 46);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.BackColor = System.Drawing.Color.Khaki;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(771, 319);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(267, 46);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtp_DOB.CalendarMonthBackground = System.Drawing.Color.Khaki;
            this.dtp_DOB.CalendarTitleBackColor = System.Drawing.Color.Khaki;
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(771, 418);
            this.dtp_DOB.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(267, 37);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // btn_Student_list
            // 
            this.btn_Student_list.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Student_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Student_list.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_list.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Student_list.Location = new System.Drawing.Point(7, 145);
            this.btn_Student_list.Name = "btn_Student_list";
            this.btn_Student_list.Size = new System.Drawing.Size(266, 59);
            this.btn_Student_list.TabIndex = 9;
            this.btn_Student_list.Text = "Student List";
            this.btn_Student_list.UseVisualStyleBackColor = false;
            this.btn_Student_list.Click += new System.EventHandler(this.btn_Student_list_Click);
            // 
            // cmb_Course
            // 
            this.cmb_Course.BackColor = System.Drawing.Color.Khaki;
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BBA",
            "BCS",
            "MCA",
            "BBA",
            "MBA"});
            this.cmb_Course.Location = new System.Drawing.Point(771, 523);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(267, 47);
            this.cmb_Course.TabIndex = 5;
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.BackColor = System.Drawing.Color.LightYellow;
            this.btn_Search_Student_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_Details.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Search_Student_Details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(7, 56);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(262, 59);
            this.btn_Search_Student_Details.TabIndex = 8;
            this.btn_Search_Student_Details.Text = "Search Student ";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // tb_Roll_no
            // 
            this.tb_Roll_no.BackColor = System.Drawing.Color.Khaki;
            this.tb_Roll_no.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_no.Location = new System.Drawing.Point(771, 128);
            this.tb_Roll_no.MaxLength = 5;
            this.tb_Roll_no.Name = "tb_Roll_no";
            this.tb_Roll_no.Size = new System.Drawing.Size(267, 46);
            this.tb_Roll_no.TabIndex = 1;
            this.tb_Roll_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.btn_Search_Student_Details);
            this.panel2.Controls.Add(this.lbl_User);
            this.panel2.Controls.Add(this.btn_Student_list);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(5, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 594);
            this.panel2.TabIndex = 12;
            // 
            // frm_add_student_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Roll_no);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_mobile_no);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_Roll_no);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_add_student_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Student_Detail";
            this.Load += new System.EventHandler(this.frm_add_student_detail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label lbl_Add_Student_details;
        private System.Windows.Forms.Label lbl_Roll_no;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_mobile_no;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button btn_Student_list;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private System.Windows.Forms.TextBox tb_Roll_no;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Panel panel2;
    }
}