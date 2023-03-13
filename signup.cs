using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get user inputs
            string username = usernametxt.Text;
            string phone = txtPhone.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Encrypt password
            string encryptedPassword = EncryptPassword(password);

            // Save user data to database
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO users (username,[phone number],password,role) VALUES (@Username, @Phone, @Password,'user')", connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Signup successful.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Signup failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private string EncryptPassword(string password)
        {
            // Create a byte array from the password string
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Create a SHA256 hash from the password bytes
            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            // Convert the hash bytes to a string
            StringBuilder hashBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashBuilder.Append(hashBytes[i].ToString("x2"));
            }

            return hashBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}

