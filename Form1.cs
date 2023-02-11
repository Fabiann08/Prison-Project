using MySql.Data.MySqlClient;

namespace Prison
{
    public partial class prisonForm : Form
    {

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
        private void addPrisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm showAddForm= new addForm();
            showAddForm.Show(); // or showAddForm.ShowDialog();
        }

        private void modifyPrisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyForm showModifyForm = new modifyForm();
            showModifyForm.Show();
        }

        private void searchForAPrisonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchForm showSearchForm = new searchForm();
            showSearchForm.Show();
        }

        private void displayPrisonerLiatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayForm showDisplayForm = new displayForm();
            showDisplayForm.Show();
        }

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

    }

}