using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;


namespace school_information_system
{
    public partial class Form1 : Form
    {

        string connectionString = "server=localhost;port=3306;database=school_information_system;uid=root;pwd=jeth123;";

        public Form1()
        {
            InitializeComponent();
        }

        private void ExportFilteredReportToExcel()
        {
            DataTable dt = LoadFilteredReportData();
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            // Excel export same as before
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Filtered Report";

            // Headers
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
            }

            // Data
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j]?.ToString();
                }
            }

            worksheet.UsedRange.Columns.AutoFit();
            worksheet.UsedRange.AutoFilter(1);
            excelApp.Visible = true;
        }




        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO students (first_name, last_name, date_of_birth, email, phone, class_id, graduation_date, last_login) " +
                                   "VALUES (@first_name, @last_name, @date_of_birth, @email, @phone, @class_id, @graduation_date, @last_login)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", dtpBirthdate.Value);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@class_id", int.Parse(txtClassID.Text));
                    cmd.Parameters.AddWithValue("@graduation_date", dtpGraduationDate.Value);
                    cmd.Parameters.AddWithValue("@last_login", DateTime.Now); // or a DateTimePicker control

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added!");
                    LoadStudents(); 
                    ClearStudentFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string queryAll = "SELECT * FROM students";
                    MySqlDataAdapter da = new MySqlDataAdapter(queryAll, conn);
                    DataTable dtAll = new DataTable();
                    da.Fill(dtAll);
                    dgvStudents.DataSource = dtAll;

                    string queryNames = "SELECT student_id, CONCAT(first_name, ' ', last_name) AS full_name FROM students";
                    MySqlCommand cmd = new MySqlCommand(queryNames, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtNames = new DataTable();
                    dtNames.Load(reader);

                    cbStudent.DataSource = dtNames;
                    cbStudent.DisplayMember = "full_name";   
                    cbStudent.ValueMember = "student_id";    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO classes (class_name, teacher_id) VALUES (@class_name, @teacher_id)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@class_name", txtClassName.Text.Trim());
                    cmd.Parameters.AddWithValue("@teacher_id", cmbTeachers.SelectedValue);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Class added successfully!");
                    txtClassName.Clear();
                    cmbTeachers.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding class: " + ex.Message);
                }
            }
        }

        private void LoadClasses()
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT class_id, class_name, teacher_id FROM classes";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClasses.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }

        private void btnLoadClasses_Click(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadClasses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        private void LoadStudentAndClassOptions()
        {
            
        }

        private void btnLoadEnrollments_Click(object sender, EventArgs e)
        {

        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            
        }



        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells["student_id"].Value.ToString();
                txtFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtLastName.Text = row.Cells["last_name"].Value.ToString();
                dtpBirthdate.Value = Convert.ToDateTime(row.Cells["date_of_birth"].Value);
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtClassID.Text = row.Cells["class_id"].Value.ToString();
                dtpGraduationDate.Value = Convert.ToDateTime(row.Cells["graduation_date"].Value);
            }
        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student to update.");
                LoadStudents();
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE students SET first_name=@first_name, last_name=@last_name, date_of_birth=@dob,
                         email=@email, phone=@phone, class_id=@class_id, graduation_date=@grad_date
                         WHERE student_id=@student_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpBirthdate.Value);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@class_id", txtClassID.Text);
                cmd.Parameters.AddWithValue("@grad_date", dtpGraduationDate.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student updated successfully!");
                LoadStudents();
                ClearStudentFields();
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student to delete.");
                LoadStudents();
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM students WHERE student_id=@student_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student deleted successfully!");
                    LoadStudents();
                    ClearStudentFields();
                }
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearStudentFields()
        {
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtClassID.Clear();
            dtpBirthdate.Value = DateTime.Today;
            dtpGraduationDate.Value = DateTime.Today;
        }

        private void ClearTeacherFields()
        {
            txtTFirstName.Clear();
            txtTLastName.Clear();
            txtTSubject.Clear();
            txtTEmail.Clear();
        }
        private void txtClassName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                LoadTeachers();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTeacherID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadTeachers()
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT teacher_id, CONCAT(first_name, ' ', last_name) AS teacher_name, subject, email FROM teachers";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTeachers.DataSource = dt;

                    // Temporarily remove the event handler to prevent recursive calls.
                    cmbTeachers.SelectedIndexChanged -= cmbTeachers_SelectedIndexChanged;

                    cmbTeachers.DataSource = dt;
                    cmbTeachers.DisplayMember = "teacher_name";
                    cmbTeachers.ValueMember = "teacher_id";
                    cmbTeachers.SelectedIndex = -1;

                    // Reattach the event handler.
                    cmbTeachers.SelectedIndexChanged += cmbTeachers_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading teachers: " + ex.Message);
                }
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string firstName = txtTFirstName.Text.Trim();
            string lastName = txtTLastName.Text.Trim();
            string subject = txtTSubject.Text.Trim();
            string email = txtTEmail.Text.Trim();

            if (firstName == "" || lastName == "")
            {
                MessageBox.Show("First and Last name are required.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO teachers (first_name, last_name, subject, email) VALUES (@first, @last, @subject, @email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@first", firstName);
                cmd.Parameters.AddWithValue("@last", lastName);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher added successfully!");
                ClearTeacherFields();
                LoadTeachers();
            }
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];
                txtTFirstName.Text = row.Cells["first_name"].Value.ToString();
                txtTLastName.Text = row.Cells["last_name"].Value.ToString();
                txtTSubject.Text = row.Cells["subject"].Value.ToString();
                txtTEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void txtTEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow == null)
            {
                MessageBox.Show("Please select a teacher to update.");
                return;
            }

            int teacherId = Convert.ToInt32(dgvTeachers.CurrentRow.Cells["teacher_id"].Value);
            string firstName = txtTFirstName.Text.Trim();
            string lastName = txtTLastName.Text.Trim();
            string subject = txtTSubject.Text.Trim();
            string email = txtTEmail.Text.Trim();

            string connStr = "server=localhost;database=school_information_system;uid=root;pwd=jeth123;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE teachers SET first_name=@first, last_name=@last, subject=@subject, email=@email WHERE teacher_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", teacherId);
                cmd.Parameters.AddWithValue("@first", firstName);
                cmd.Parameters.AddWithValue("@last", lastName);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher updated!");
                ClearTeacherFields();
                LoadTeachers();
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow == null) return;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            int teacherId = Convert.ToInt32(dgvTeachers.CurrentRow.Cells["teacher_id"].Value);
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM teachers WHERE teacher_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", teacherId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher deleted.");
                ClearTeacherFields();
                LoadTeachers();
            }
        }

        private void cmbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            LoadStudents();
            LoadSubjects();
            LoadEnrollments();
        }

        private void LoadEnrollments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT e.enrollment_id, 
                   CONCAT(s.first_name, ' ', s.last_name) AS student_name,
                   sub.subject_name, 
                   e.grade
            FROM enrollments e
            JOIN students s ON e.student_id = s.student_id
            JOIN subjects sub ON e.subject_id = sub.subject_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvEnrollments.DataSource = dt;
            }
        }


        private void btnLoadSubjects_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT subject_id, subject_name FROM subjects";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSubjects.DataSource = dt;
                    cbSubject.DataSource = dt;
                    cbSubject.DisplayMember = "subject_name";
                    cbSubject.ValueMember = "subject_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading subjects: " + ex.Message);
                }
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Subject name is required.");
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO subjects (subject_name) VALUES (@subjectName)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@subjectName", subjectName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject added successfully.");
                    txtSubjectName.Clear();
                    LoadSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding subject: " + ex.Message);
                }
            }
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];
                txtSubjectName.Text = row.Cells["subject_name"].Value.ToString();
            }
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.CurrentRow == null)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            int subjectId = Convert.ToInt32(dgvSubjects.CurrentRow.Cells["subject_id"].Value);
            string subjectName = txtSubjectName.Text.Trim();

            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Subject name is required.");
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE subjects SET subject_name = @subjectName WHERE subject_id = @subjectId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@subjectName", subjectName);
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully.");
                    LoadSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating subject: " + ex.Message);
                }
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.CurrentRow == null)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            int subjectId = Convert.ToInt32(dgvSubjects.CurrentRow.Cells["subject_id"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM subjects WHERE subject_id = @subjectId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@subjectId", subjectId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Subject deleted successfully.");
                        LoadSubjects();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting subject: " + ex.Message);
                    }
                }
            }
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadEnrollments_Click_1(object sender, EventArgs e)
        {
            LoadEnrollments();
        }

        private void btnAddEnrollment_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(cbStudent.SelectedValue);
            int subjectId = Convert.ToInt32(cbSubject.SelectedValue);
            string grade = txtGrade.Text.Trim();

            if (string.IsNullOrEmpty(grade))
            {
                MessageBox.Show("Please enter a grade.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO enrollments (student_id, subject_id, grade) VALUES (@studentId, @subjectId, @grade)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enrollment added successfully.");
                LoadEnrollments();
                txtGrade.Clear();
            }
        }

        private void dgvEnrollments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];

                cbStudent.Text = row.Cells["student_name"].Value.ToString(); // just for UI
                cbSubject.Text = row.Cells["subject_name"].Value.ToString(); // just for UI
                txtGrade.Text = row.Cells["grade"].Value.ToString();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT user_id, username, email, role FROM users";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, email, password, role) VALUES (@Name, @Email, SHA2(@Password, 256), @Role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtUserEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", txtUserPassword.Text);
                    cmd.Parameters.AddWithValue("@Role", cbUserRole.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully.");
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUserName.Text = dgvUsers.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtUserEmail.Text = dgvUsers.Rows[e.RowIndex].Cells["email"].Value.ToString();
                cbUserRole.Text = dgvUsers.Rows[e.RowIndex].Cells["role"].Value.ToString();
                txtUserPassword.Text = ""; // password hidden for security
            }
        }

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE users SET username=@Name, email=@Email, role=@Role" +
                               (string.IsNullOrWhiteSpace(txtUserPassword.Text) ? "" : ", password=SHA2(@Password, 256)") +
                               " WHERE user_id=@UserId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Email", txtUserEmail.Text);
                cmd.Parameters.AddWithValue("@Role", cbUserRole.Text);
                cmd.Parameters.AddWithValue("@UserId", userId);
                if (!string.IsNullOrWhiteSpace(txtUserPassword.Text))
                    cmd.Parameters.AddWithValue("@Password", txtUserPassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated.");
                LoadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["user_id"].Value);

            var confirm = MessageBox.Show("Are you sure to delete this user?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE user_id=@UserId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted.");
                    LoadUsers();
                }
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtUserEmail.Clear();
            txtUserPassword.Clear();
            cbUserRole.SelectedIndex = -1;
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnGetAvgGrade_Click(object sender, EventArgs e)
        {
            
        }

        private void GetAverageGrade(int studentId)
        {
            
        }


        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtClassID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpGraduationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabReports)
            {
                LoadStudentsCombo();
                LoadClassesCombo();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtTSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void cbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserRole_Click(object sender, EventArgs e)
        {

        }

        private void lblUserPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUserEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LoadStudentsCombo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT student_id, CONCAT(first_name, ' ', last_name) AS student_name FROM students";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbStudents.DataSource = dt;
                    cmbStudents.DisplayMember = "student_name";
                    cmbStudents.ValueMember = "student_id";
                    cmbStudents.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }


        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCountStudents_Click(object sender, EventArgs e)
        {
            
        }

        private void CountStudentsInClass(int classId)
        {
            
        }


        private void btnGetHighestGrade_Click(object sender, EventArgs e)
        {
            
        }

        private void GetHighestGradeInClass(int classId)
        {
            
        }


        private void lblStudentCount_Click(object sender, EventArgs e)
        {

        }

        private void lblHighestGrade_Click(object sender, EventArgs e)
        {

        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadClassesCombo()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT class_id, class_name FROM classes";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbClasses.DataSource = dt;
                    cmbClasses.DisplayMember = "class_name";
                    cmbClasses.ValueMember = "class_id";
                    cmbClasses.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }

        private void btnGetAverage_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            int studentId = Convert.ToInt32(cmbStudents.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AVG(grade) AS avg_grade FROM grades WHERE student_id = @studentId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        double avgGrade = Convert.ToDouble(result);
                        lblAverageGrade.Text = $"Average Grade: {avgGrade:F2}";
                    }
                    else
                    {
                        lblAverageGrade.Text = "Average Grade: N/A";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating average: " + ex.Message);
                }
            }
        }

        private void lblHighestResult_Click(object sender, EventArgs e)
        {

        }

        private void btnGetHighest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable reportData = LoadAllStudentReports(); // ✅ get all data

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV File|*.csv" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            // Write headers
                            for (int i = 0; i < reportData.Columns.Count; i++)
                            {
                                sw.Write(reportData.Columns[i]);
                                if (i < reportData.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();

                            // Write data rows
                            foreach (DataRow row in reportData.Rows)
                            {
                                for (int i = 0; i < reportData.Columns.Count; i++)
                                {
                                    // Escape commas and quotes in data
                                    var data = row[i].ToString();
                                    if (data.Contains(",") || data.Contains("\""))
                                        data = $"\"{data.Replace("\"", "\"\"")}\"";

                                    sw.Write(data);
                                    if (i < reportData.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("Report exported successfully as CSV!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadClassFilter()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT class_id, class_name FROM classes", conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //cmbFilterClass.DataSource = dt;
                    //cmbFilterClass.DisplayMember = "class_name";
                    //cmbFilterClass.ValueMember = "class_id";
                    //cmbFilterClass.SelectedIndex = -1; // No selection by default
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load class filter: " + ex.Message);
                }
            }
        }

        private DataTable LoadFilteredReportData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                s.student_id,
                s.first_name,
                s.last_name,
                s.date_of_birth,
                s.email,
                s.phone,
                s.class_id,
                c.class_name,
                g.grade,
                s.graduation_date,
                s.last_login
            FROM students s
            LEFT JOIN classes c ON s.class_id = c.class_id
            LEFT JOIN grades g ON s.student_id = g.student_id
            WHERE 1 = 1";

                List<MySqlParameter> parameters = new List<MySqlParameter>();

                // Name filter
                if (!string.IsNullOrWhiteSpace(txtSearchName.Text))
                {
                    query += " AND (s.first_name LIKE @name OR s.last_name LIKE @name)";
                    parameters.Add(new MySqlParameter("@name", "%" + txtSearchName.Text + "%"));
                }

                // Class filter
                //if (cmbFilterClass.SelectedIndex != -1)
                //{
                 //   query += " AND s.class_id = @classId";
                 //   parameters.Add(new MySqlParameter("@classId", cmbFilterClass.SelectedValue));
                //}

                // Optional: Date range filter (graduation_date)
                //if (chkUseDateRange.Checked) // Use a checkbox if you want to toggle date filter
                //{
                //query += " AND s.graduation_date BETWEEN @from AND @to";
                //parameters.Add(new MySqlParameter("@from", dtpFrom.Value.Date));
                //parameters.Add(new MySqlParameter("@to", dtpTo.Value.Date));
                //}

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load data: " + ex.Message);
                    return null;
                }
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            dataGridViewReport.DataSource = LoadFilteredReportData();
        }

        private void cmbFilterClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private DataTable LoadAllStudentReports()
        {
            string connectionString = "server=localhost;user=root;password=jeth123;database=school_information_system;";
            string query = @"
                SELECT s.student_id, CONCAT(s.first_name, ' ', s.last_name) AS student_name,
                       s.email, s.phone, s.date_of_birth,
                       c.class_name, g.grade
                FROM students s
                LEFT JOIN classes c ON s.class_id = c.class_id
                LEFT JOIN grades g ON s.student_id = g.student_id
                
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

    }
}
