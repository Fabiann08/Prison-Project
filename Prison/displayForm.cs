//Display prisoner form

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
        //Create connection to database
        public MySqlConnection? connection;
        private string dbConfig = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";
        public displayForm()
        {
            InitializeComponent();
        }

        //When app loads, make app form fullscreen and execute the method PrintDataToTable to print all the info in a TableGridView
        private void displayForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            PrintDataToTable();
        }

        //PrintDataToTable method connects to the database in MYSQL, retrieves all info and printd info when called
        private void PrintDataToTable()
        {
            //Initiate connection
            string connectionString = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //Open connection
                connection.Open();

                string query = "SELECT * FROM PrisonDB.prison";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    //Fill data
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
        
        //Button that closes Display window and table
        private void closeTableButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }

}