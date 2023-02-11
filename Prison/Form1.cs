/*
Program made by Fabian Echevarria and Jesus Gonzales
Using MySQL connect to a database to input info of prisoners.
*/

using MySql.Data.MySqlClient;

namespace Prison
{
    public partial class prisonForm : Form
    {
        //Initiate connection  to the database
        public MySqlConnection? connection;
        private string dbConfig = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";

        public prisonForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //File

        //Add prisoner form
        private void addPrisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create constructor to display add prisoner form
            addForm showAddForm= new addForm();
            showAddForm.Show(); // or showAddForm.ShowDialog();
        }

        //Modify prisoner form
        private void modifyPrisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create constructor to display modify prisoner form
            modifyForm showModifyForm = new modifyForm();
            showModifyForm.Show();
        }

        //Search prisoner form
        private void searchForAPrisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create constructor to display search prisoner form
            searchForm showSearchForm = new searchForm();
            showSearchForm.Show();
        }

        //Display prisoner form
        private void displayPrisonerLiatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create constructor to display the display prisoner form
            displayForm showDisplayForm = new displayForm();
            showDisplayForm.Show();
        }

        //Exit app
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by:\nFabian Echevarria #121944\nJesus Gonzales #116745");
        }

        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is made to store in a database all of the information of a prisoner. " +
                "Properties are:\n Add a prisoner - will add a new prisoner to the data base\n" +
                "Modify a prisoner - modify an existent prisoner\n" +
                "Search for a prisoner - search made using prisoner’s id then displays all information of the prisoner\n" +
                "Display prisoner list - will display a table with all the prisoners");
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}