using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using static Org.BouncyCastle.Math.EC.ECCurve;
using System.Windows.Forms;

namespace Prison
{
    public partial class displayForm : Form
    {
        public MySqlConnection? connection;
        private string dbConfig = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";
        public displayForm()
        {
            InitializeComponent();
        }

        private void displayForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            PrintDataToTable();
        }

        private void PrintDataToTable()
        {
            string connectionString = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM PrisonDB.prison";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    prisonDataGridView.DataSource = dataTable;
                }
            }

        }

        private void prisonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void closeTableButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }

}