//Add prisoner form

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Prison
{

    public partial class addForm : Form
    {
        public MySqlConnection? connection;
        private string dbConfig = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";
        //Constructor for addForm
        public addForm()
        {
            InitializeComponent();
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Save button
           

            ////////////////////////////////////////////////////////

            string config = dbConfig;
            int idx;

            // This try and catch has all database input info, takes data from text boxes and inserts
            // them into their respective place in the database.
            try
            {
                
                //Opening connection to database
                string query = "insert into PrisonDB.prison values (null, @lastName, @firstName, @photo, @birthDate, @height, @hair, @eyes, @placeOfBirth, @sentence, @dateOfConviction, @dateToBeLiberated)";
                connection = new MySqlConnection(config);
                connection.Open();

                //Add info to database
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.Parameters.Add("@prisonerID", MySqlDbType.Int32).Value = Int32.Parse(iDTextBox.Text);
                cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastNameTextBox.Text;
                cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = nameTextBox.Text;
                cmd.Parameters.Add("@photo", MySqlDbType.VarChar).Value = photoTextBox.Text;
                cmd.Parameters.Add("@birthDate", MySqlDbType.Date).Value = birthDateTextBox.Text;
                cmd.Parameters.Add("@height", MySqlDbType.Decimal).Value = heightTextBox.Text;
                cmd.Parameters.Add("@hair", MySqlDbType.VarChar).Value = hairTextBox.Text;
                cmd.Parameters.Add("@eyes", MySqlDbType.VarChar).Value = eyesTextBox.Text;
                cmd.Parameters.Add("@placeOfBirth", MySqlDbType.VarChar).Value = whereBornTextBox.Text;
                cmd.Parameters.Add("@sentence", MySqlDbType.VarChar).Value = sentenceTextBox.Text;
                cmd.Parameters.Add("@dateOfConviction", MySqlDbType.Date).Value = convictionTextBox.Text;
                cmd.Parameters.Add("@dateToBeLiberated", MySqlDbType.Date).Value = dateOfLiberationTextBox.Text;

                idx = cmd.ExecuteNonQuery();

                //if successfuly adds record
                if (idx != 0)
                {
                    MessageBox.Show("Record sucessfully inserted!");

                    //iDTextBox.Text = "";
                    nameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    birthDateTextBox.Text = "";
                    heightTextBox.Text = "";
                    hairTextBox.Text = "";
                    eyesTextBox.Text = "";
                    whereBornTextBox.Text = "";
                    sentenceTextBox.Text = "";
                    convictionTextBox.Text = "";
                    dateOfLiberationTextBox.Text = "";
                    photoTextBox.Text = "";
                    prisonerPictureBox.Image = null;
                    
                    //close connection
                    connection.Close();
                }
            }//try catch if error with adding info to database
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }


        }

        //CLear button
        private void button1_Click(object sender, EventArgs e)
        {
            //Clear all textboxes and picture box
            //iDTextBox.Text = "";
            nameTextBox.Text = "";
            lastNameTextBox.Text = "";
            birthDateTextBox.Text = "";
            heightTextBox.Text = "";
            hairTextBox.Text = "";
            eyesTextBox.Text = "";
            whereBornTextBox.Text = "";
            sentenceTextBox.Text = "";
            convictionTextBox.Text = "";
            dateOfLiberationTextBox.Text = "";
            photoTextBox.Text = "";
            prisonerPictureBox.Image = null;

            //info label become visible
            insertPictureClickLabel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Event where double clicking picture box opens file directory to add a picture
        private void addPictureEvent(object sender, EventArgs e)
        {

            //info label become invisible
            insertPictureClickLabel.Visible = false;

            var fileContent = string.Empty;
            var filePath = string.Empty;

            //OpenFileDialog opens file directory
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Only open files with these specifications
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                try
                {
                    //insert filepath into picture to show. Also inserts file path to text box to show.
                    string myFile = filePath;
                    photoTextBox.Text = filePath;
                    Image newImage = Image.FromFile(myFile);
                    prisonerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    prisonerPictureBox.Image = newImage;
                }catch(Exception ex)
                {
                    //try catch if file path exeeds 25 characters
                    MessageBox.Show("Error with picture file path:", ex.Message);
                }
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        { 

        }

        private void prisonerPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
    
}
