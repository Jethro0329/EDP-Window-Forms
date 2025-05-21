using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class FormLogin : Form
    {
        string connectionString = "server=localhost;port=3306;database=school_information_system;uid=root;pwd=jeth123;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblStatus.Text = "Please enter both username and password.";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username=@username AND password=SHA2(@password, 256)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open Form1 and hide the login form
                        Form1 mainForm = new Form1();
                        mainForm.Show();
                        this.Hide(); // or this.Close(); if you don't want to keep the login form in memory
                    }
                    else
                    {
                        lblStatus.Text = "Invalid credentials. Try again.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecovery recoveryForm = new FormRecovery();
            recoveryForm.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
