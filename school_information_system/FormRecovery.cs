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
    public partial class FormRecovery : Form
    {
        string connectionString = "server=localhost;port=3306;database=school_information_system;uid=root;pwd=jeth123;";
        public FormRecovery()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();

            if (email == "" || newPassword == "")
            {
                lblMessage.Text = "Please fill in both fields.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if email exists
                    string checkQuery = "SELECT * FROM users WHERE email=@Email";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    var reader = checkCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Close();

                        // Update password using SHA2
                        string updateQuery = "UPDATE users SET password=SHA2(@Password, 256) WHERE email=@Email";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Password", newPassword);
                        updateCmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lblMessage.Text = "Password reset successfully.";
                            lblMessage.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblMessage.Text = "Reset failed. Try again.";
                            lblMessage.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        reader.Close();
                        lblMessage.Text = "Email not found.";
                        lblMessage.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
