using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ticketeuse
{
    public partial class events : Form
    {
        public events()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            String eventname = eventnametxt.Text;
            DateTime date = dtpDate.Value.Date;
            String time = dtpTime.Text;
            string location = txtLocation.Text;
            string performers = txtPerformers.Text;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO events2 (eventname,date, time, location, performs) VALUES (@eventname,@date, @time, @location, @performers)", connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@eventname", eventname);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@performers", performers);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event saved successfully");
                }
                else
                {
                    MessageBox.Show("Error saving event");
                }
                connection.Close();
                viewData();
            }
        }





        private void eventid_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            String eventname = eventnametxt.Text;
            DateTime date = dtpDate.Value.Date;
            String time = dtpTime.Text;
            string location = txtLocation.Text;
            string performers = txtPerformers.Text;

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE events2 SET eventname=@eventname,date=@date, time=@time,location=@location,performs=@performers WHERE id=@ID", connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@eventname", eventname);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@performers", performers);

                command.ExecuteNonQuery();
                MessageBox.Show("Updated with Success");
                viewData();
                connection.Close();

            }
        }

        private void events_Load(object sender, EventArgs e)
        {
            viewData();
        }

        public void viewData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM events2", connection);
                {
                    connection.Open();
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dtEvent.Load(sdr);
                    dataGridView1.DataSource = dtEvent;
                }
            }
        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
            {
                string query = "SELECT * FROM events2 WHERE ID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Get the data from the reader and display it in the UI

                            dtpDate.Text = reader["date"].ToString();
                            dtpTime.Text = reader["time"].ToString();
                            txtLocation.Text = reader["location"].ToString();
                            txtPerformers.Text = reader["performs"].ToString();
                            eventnametxt.Text = reader["eventname"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record found for ID " + id);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);

            DialogResult result = MessageBox.Show("Are you Sure?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
                {
                    SqlCommand command = new SqlCommand("DELETE FROM events2 where id=@ID", connection);
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@ID", IDTextBox.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted with Success");
                        viewData();
                    }
                }
            }
        }
    }
}





