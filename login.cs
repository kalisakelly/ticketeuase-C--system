using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketeuse
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup signup = new signup();
            signup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))

            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT role FROM Users WHERE username=@username AND password=@password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader.GetString(0);
                    MessageBox.Show("Login successful with role: " + role);

                    // Authorize the user to certain forms based on their role
                    if (role == "administrator")
                    {
                        admin_panel admin_Panel = new admin_panel();
                        admin_Panel.Show();
                    }
                    else if (role == "user")
                    {
                        userpanel userpanel = new userpanel();
                        userpanel.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

    }
}




