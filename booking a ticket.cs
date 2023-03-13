using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Ticketeuse
{
    public partial class booking_a_ticket : Form
    {
        public booking_a_ticket()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = nametxt.Text;
            int tickets = int.Parse(ticketscombobox.Text);
            String phone = phonetxt.Text;
            String email = emailtxt.Text;
            String payment = paymentcombbox.Text;
            String eventname = eventbox.Text;
            int numberseats = int.Parse(numbertxt.Text);
            String parking = comboBox3.Text;
            int total = numberseats * tickets;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT into booking2 (name,phone,email,eventname,payment_mode,tickets,no_seats,parking_slot) VALUES (@name,@phone,@email,@eventname,@payment,@tickets,@numberseats,@parking)", connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@eventname", eventname);
                command.Parameters.AddWithValue("@tickets", tickets);
                command.Parameters.AddWithValue("@numberseats", numberseats);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@payment", payment);
                command.Parameters.AddWithValue("@parking", parking);
                command.Parameters.AddWithValue("@email", email);




                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event saved successfully the amount to pay is" + total);
                }
                else
                {
                    MessageBox.Show("Error saving event");
                }
                connection.Close();
            }

        }

        private void booking_a_ticket_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))

            {
                SqlCommand command = new SqlCommand("SELECT * FROM events2", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    eventbox.Items.Add(reader["eventname"].ToString());
                }
                reader.Close();
            }
        }

        private void ticketscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
