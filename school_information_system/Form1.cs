using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_information_system
{
    public partial class Form1 : Form
    {

        string connectionString = "server=localhost;port=3306;database=school_information_system;uid=root;pwd=jeth123;";

        public Form1()
        {
            InitializeComponent();
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
            string connStr = "server=localhost;database=school_information_system;uid=root;pwd=jeth123;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
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
    }
}
