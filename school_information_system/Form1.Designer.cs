namespace school_information_system
{
    partial class Form1
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
            this.Label = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpGraduationDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnLoadClasses = new System.Windows.Forms.Button();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLoadTeachers = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.txtTEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTSubject = new System.Windows.Forms.TextBox();
            this.txtTLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            this.btnLoadEnrollments = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAddEnrollment = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnLoadSubjects = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(43, 144);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(86, 16);
            this.Label.TabIndex = 1;
            this.Label.Text = "First Name:";
            this.Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(147, 197);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(204, 22);
            this.dtpBirthdate.TabIndex = 2;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dtpBirthdate_ValueChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(163, 272);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(121, 33);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birthdate:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(330, 567);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(140, 37);
            this.btnLoadStudents.TabIndex = 7;
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(100, 330);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(604, 201);
            this.dgvStudents.TabIndex = 8;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(147, 141);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(204, 22);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(147, 169);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(204, 22);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 22);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(523, 141);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 22);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(523, 169);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(232, 22);
            this.txtClassID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Class ID:";
            // 
            // dtpGraduationDate
            // 
            this.dtpGraduationDate.Location = new System.Drawing.Point(523, 199);
            this.dtpGraduationDate.Name = "dtpGraduationDate";
            this.dtpGraduationDate.Size = new System.Drawing.Size(232, 22);
            this.dtpGraduationDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Graduation Date";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(358, 133);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(175, 22);
            this.txtClassName.TabIndex = 20;
            this.txtClassName.TextChanged += new System.EventHandler(this.txtClassName_TextChanged);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(358, 212);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(95, 36);
            this.btnAddClass.TabIndex = 21;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnLoadClasses
            // 
            this.btnLoadClasses.Location = new System.Drawing.Point(329, 491);
            this.btnLoadClasses.Name = "btnLoadClasses";
            this.btnLoadClasses.Size = new System.Drawing.Size(151, 36);
            this.btnLoadClasses.TabIndex = 22;
            this.btnLoadClasses.Text = "Load Classes";
            this.btnLoadClasses.UseVisualStyleBackColor = true;
            this.btnLoadClasses.Click += new System.EventHandler(this.btnLoadClasses_Click);
            // 
            // dgvClasses
            // 
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(173, 275);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.Size = new System.Drawing.Size(456, 195);
            this.dgvClasses.TabIndex = 23;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(523, 229);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(79, 22);
            this.txtStudentID.TabIndex = 29;
            this.txtStudentID.Visible = false;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(326, 272);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(155, 33);
            this.btnUpdateStudent.TabIndex = 30;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(523, 272);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(135, 33);
            this.btnDeleteStudent.TabIndex = 31;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 677);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtStudentID);
            this.tabPage1.Controls.Add(this.btnDeleteStudent);
            this.tabPage1.Controls.Add(this.Label);
            this.tabPage1.Controls.Add(this.btnUpdateStudent);
            this.tabPage1.Controls.Add(this.dtpBirthdate);
            this.tabPage1.Controls.Add(this.btnAddStudent);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.dgvStudents);
            this.tabPage1.Controls.Add(this.btnLoadStudents);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtClassID);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtpGraduationDate);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 59);
            this.label8.TabIndex = 32;
            this.label8.Text = "STUDENTS";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cmbTeachers);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtClassName);
            this.tabPage2.Controls.Add(this.btnAddClass);
            this.tabPage2.Controls.Add(this.btnLoadClasses);
            this.tabPage2.Controls.Add(this.dgvClasses);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classes";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(281, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 59);
            this.label14.TabIndex = 33;
            this.label14.Text = "CLASSES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(216, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Assign Teacher: ";
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(358, 161);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(175, 24);
            this.cmbTeachers.TabIndex = 27;
            this.cmbTeachers.SelectedIndexChanged += new System.EventHandler(this.cmbTeachers_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Class:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage4.Controls.Add(this.btnLoadTeachers);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.dgvTeachers);
            this.tabPage4.Controls.Add(this.btnDeleteTeacher);
            this.tabPage4.Controls.Add(this.btnUpdateTeacher);
            this.tabPage4.Controls.Add(this.btnAddTeacher);
            this.tabPage4.Controls.Add(this.txtTEmail);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txtTSubject);
            this.tabPage4.Controls.Add(this.txtTLastName);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtTFirstName);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(776, 648);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Teachers";
            // 
            // btnLoadTeachers
            // 
            this.btnLoadTeachers.Location = new System.Drawing.Point(304, 520);
            this.btnLoadTeachers.Name = "btnLoadTeachers";
            this.btnLoadTeachers.Size = new System.Drawing.Size(147, 38);
            this.btnLoadTeachers.TabIndex = 34;
            this.btnLoadTeachers.Text = "Load Teachers";
            this.btnLoadTeachers.UseVisualStyleBackColor = true;
            this.btnLoadTeachers.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(257, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 59);
            this.label15.TabIndex = 33;
            this.label15.Text = "TEACHERS";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(172, 362);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.RowTemplate.Height = 24;
            this.dgvTeachers.Size = new System.Drawing.Size(427, 140);
            this.dgvTeachers.TabIndex = 11;
            this.dgvTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellContentClick);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(470, 275);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(138, 41);
            this.btnDeleteTeacher.TabIndex = 10;
            this.btnDeleteTeacher.Text = "Delete Teacher";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.Location = new System.Drawing.Point(302, 275);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(149, 41);
            this.btnUpdateTeacher.TabIndex = 9;
            this.btnUpdateTeacher.Text = "Update Teacher";
            this.btnUpdateTeacher.UseVisualStyleBackColor = true;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(159, 275);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(124, 41);
            this.btnAddTeacher.TabIndex = 8;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // txtTEmail
            // 
            this.txtTEmail.Location = new System.Drawing.Point(560, 199);
            this.txtTEmail.Name = "txtTEmail";
            this.txtTEmail.Size = new System.Drawing.Size(141, 22);
            this.txtTEmail.TabIndex = 7;
            this.txtTEmail.TextChanged += new System.EventHandler(this.txtTEmail_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(440, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(434, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Subject:";
            // 
            // txtTSubject
            // 
            this.txtTSubject.Location = new System.Drawing.Point(560, 156);
            this.txtTSubject.Name = "txtTSubject";
            this.txtTSubject.Size = new System.Drawing.Size(141, 22);
            this.txtTSubject.TabIndex = 4;
            // 
            // txtTLastName
            // 
            this.txtTLastName.Location = new System.Drawing.Point(267, 199);
            this.txtTLastName.Name = "txtTLastName";
            this.txtTLastName.Size = new System.Drawing.Size(141, 22);
            this.txtTLastName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Last Name:";
            // 
            // txtTFirstName
            // 
            this.txtTFirstName.Location = new System.Drawing.Point(267, 158);
            this.txtTFirstName.Name = "txtTFirstName";
            this.txtTFirstName.Size = new System.Drawing.Size(141, 22);
            this.txtTFirstName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "First Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage3.Controls.Add(this.dgvEnrollments);
            this.tabPage3.Controls.Add(this.btnLoadEnrollments);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.btnAddEnrollment);
            this.tabPage3.Controls.Add(this.txtGrade);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.cbSubject);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.cbStudent);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(776, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Enrollments";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgvEnrollments
            // 
            this.dgvEnrollments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollments.Location = new System.Drawing.Point(88, 330);
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.RowHeadersWidth = 51;
            this.dgvEnrollments.RowTemplate.Height = 24;
            this.dgvEnrollments.Size = new System.Drawing.Size(488, 153);
            this.dgvEnrollments.TabIndex = 8;
            this.dgvEnrollments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollments_CellContentClick);
            // 
            // btnLoadEnrollments
            // 
            this.btnLoadEnrollments.Location = new System.Drawing.Point(265, 489);
            this.btnLoadEnrollments.Name = "btnLoadEnrollments";
            this.btnLoadEnrollments.Size = new System.Drawing.Size(165, 44);
            this.btnLoadEnrollments.TabIndex = 7;
            this.btnLoadEnrollments.Text = "Load Enrollments";
            this.btnLoadEnrollments.UseVisualStyleBackColor = true;
            this.btnLoadEnrollments.Click += new System.EventHandler(this.btnLoadEnrollments_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(124, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 16);
            this.label20.TabIndex = 6;
            this.label20.Text = "Grade:";
            // 
            // btnAddEnrollment
            // 
            this.btnAddEnrollment.Location = new System.Drawing.Point(194, 255);
            this.btnAddEnrollment.Name = "btnAddEnrollment";
            this.btnAddEnrollment.Size = new System.Drawing.Size(129, 43);
            this.btnAddEnrollment.TabIndex = 5;
            this.btnAddEnrollment.Text = "Enroll Student";
            this.btnAddEnrollment.UseVisualStyleBackColor = true;
            this.btnAddEnrollment.Click += new System.EventHandler(this.btnAddEnrollment_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(244, 195);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 22);
            this.txtGrade.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(97, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Select Subject:";
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(229, 137);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 24);
            this.cbSubject.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(97, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Select Student:";
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(229, 74);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(121, 24);
            this.cbStudent.TabIndex = 0;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.dgvSubjects);
            this.tabPage5.Controls.Add(this.btnLoadSubjects);
            this.tabPage5.Controls.Add(this.btnDeleteSubject);
            this.tabPage5.Controls.Add(this.btnUpdateSubject);
            this.tabPage5.Controls.Add(this.btnAddSubject);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.txtSubjectName);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(776, 648);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Subjects";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(271, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 59);
            this.label17.TabIndex = 7;
            this.label17.Text = "Subjects";
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(212, 286);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 24;
            this.dgvSubjects.Size = new System.Drawing.Size(368, 170);
            this.dgvSubjects.TabIndex = 6;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellContentClick);
            // 
            // btnLoadSubjects
            // 
            this.btnLoadSubjects.Location = new System.Drawing.Point(323, 474);
            this.btnLoadSubjects.Name = "btnLoadSubjects";
            this.btnLoadSubjects.Size = new System.Drawing.Size(143, 40);
            this.btnLoadSubjects.TabIndex = 5;
            this.btnLoadSubjects.Text = "Load Subjects";
            this.btnLoadSubjects.UseVisualStyleBackColor = true;
            this.btnLoadSubjects.Click += new System.EventHandler(this.btnLoadSubjects_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(515, 214);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(141, 40);
            this.btnDeleteSubject.TabIndex = 4;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(324, 214);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(142, 40);
            this.btnUpdateSubject.TabIndex = 3;
            this.btnUpdateSubject.Text = "Update Subject";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(166, 214);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(113, 40);
            this.btnAddSubject.TabIndex = 2;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(242, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Subject Name:";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(396, 147);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(141, 22);
            this.txtSubjectName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 679);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "tab";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpGraduationDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnLoadClasses;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtTFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTSubject;
        private System.Windows.Forms.TextBox txtTLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLoadTeachers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnLoadSubjects;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLoadEnrollments;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnAddEnrollment;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.DataGridView dgvEnrollments;
    }
}

