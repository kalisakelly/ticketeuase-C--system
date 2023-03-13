using System.Data.SqlClient;
using System.Data;

namespace Ticketeuse
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }
    }
}