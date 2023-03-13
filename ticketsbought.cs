using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketeuse
{
    public partial class ticketsbought : Form
    {
        public ticketsbought()
        {
            InitializeComponent();
        }

        private void ticketsbought_Load(object sender, EventArgs e)
        {
            viewData();
        }
        public void viewData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RGBNCFM\\SQLEXPRESS;Initial Catalog=Ticketeuse;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM booking2", connection);
                {
                    connection.Open();
                    DataTable dtEvent = new DataTable();
                    SqlDataReader sdr = command.ExecuteReader();
                    dtEvent.Load(sdr);
                    dataGridView1.DataSource = dtEvent;
                }
            }
        }
    }
}
