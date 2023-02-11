//Modify prisoner form 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prison
{
    public partial class modifyForm : Form
    {
        //Create connection to database
        public MySqlConnection? connection;
        private string dbConfig = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";


        public modifyForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modifyForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        //null
        private void modifyButton_Click(object sender, EventArgs e)
        {
            
        }
        //null
        private void clearButton_Click(object sender, EventArgs e)
        {
            
        }
        //null
        private void searchButton_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void liberationDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Button that modifies info presented
        private void modifyButton_Click_1(object sender, EventArgs e)
        {
            string config = dbConfig;
            int idx;


            try
            {
                //open connection
                string query = "Update PrisonDB.Prison set LastName = @lastName, FirstName = @firstName, Photo = @photo, BirthDate = @birthDate, Height = @height," +
                    "Hair = @hair, Eyes = @eyes, PlaceOfBirth = @placeOfBirth, Sentence = @sentence, DateOfConviction = @dateOfConviction, DateToBeLiberated = @dateToBeLiberated" +
                    " where PrisonerID = @prisonerID";
                connection = new MySqlConnection(config);
                connection.Open();

                //modify info to database
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastNameTextBox.Text;
                cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = nameTextBox.Text;
                cmd.Parameters.Add("@photo", MySqlDbType.VarChar).Value = photoTextBox.Text;
                cmd.Parameters.Add("@birthDate", MySqlDbType.Date).Value = birthDateTextBox.Text;
                cmd.Parameters.Add("@height", MySqlDbType.Decimal).Value = (Double.Parse(heightTextBox.Text));
                cmd.Parameters.Add("@hair", MySqlDbType.VarChar).Value = hairTextBox.Text;
                cmd.Parameters.Add("@eyes", MySqlDbType.VarChar).Value = eyesTextBox.Text;
                cmd.Parameters.Add("@placeOfBirth", MySqlDbType.VarChar).Value = birthPlaceTextBox.Text;
                cmd.Parameters.Add("@sentence", MySqlDbType.VarChar).Value = sentenceTextBox.Text;
                cmd.Parameters.Add("@dateOfConviction", MySqlDbType.Date).Value = convictionDateTextBox.Text;
                cmd.Parameters.Add("@dateToBeLiberated", MySqlDbType.Date).Value = liberationDateTextBox.Text;
                cmd.Parameters.Add("@prisonerID", MySqlDbType.Int32).Value = Int32.Parse(prisonerIDTextBox.Text);

                idx = cmd.ExecuteNonQuery();

                //if successfuly adds record
                if (idx != 0)
                {
                    MessageBox.Show("Record sucessfully updated!");
                    searchTextBox.Text = "";
                    prisonerIDTextBox.Text = "";
                    nameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    birthDateTextBox.Text = "";
                    heightTextBox.Text = "";
                    hairTextBox.Text = "";
                    eyesTextBox.Text = "";
                    birthPlaceTextBox.Text = "";
                    sentenceTextBox.Text = "";
                    convictionDateTextBox.Text = "";
                    liberationDateTextBox.Text = "";
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

        //Clear all text box and picture box button
        private void clearButton_Click_1(object sender, EventArgs e)
        {
            //Clear button
            searchTextBox.Text = "";
            prisonerIDTextBox.Text = "";
            nameTextBox.Text = "";
            lastNameTextBox.Text = "";
            birthDateTextBox.Text = "";
            heightTextBox.Text = "";
            hairTextBox.Text = "";
            eyesTextBox.Text = "";
            birthPlaceTextBox.Text = "";
            sentenceTextBox.Text = "";
            convictionDateTextBox.Text = "";
            liberationDateTextBox.Text = "";
            photoTextBox.Text = "";
            prisonerPictureBox.Image = null;
        }

        //Button that searches all info using prisoner ID
        private void searchButton_Click_1(object sender, EventArgs e)
        {
            int id;
            string config = dbConfig;

            //If id search is empty display messagebox
            if (searchButton.Text.Length == 0)
            {
                MessageBox.Show("ID is empty!");
                return;
            }

            //Parse string to int textbox
            id = Int32.Parse(searchTextBox.Text);

            //search
            if (id > 0)
            {
                try
                {
                    //Open connection
                    string query = "Select * from PrisonDB.Prison where prisonerID = @id";
                    connection = new MySqlConnection(config);
                    connection.Open();

                    //search ID
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    //retrieve Prisoner info
                    while (reader.Read())
                    {
                        prisonerIDTextBox.Text = reader.GetString("prisonerID");
                        lastNameTextBox.Text = reader.GetString("lastName");
                        nameTextBox.Text = reader.GetString("firstName");
                        birthDateTextBox.Text = reader.GetString("birthDate");
                        heightTextBox.Text = reader.GetString("height");
                        hairTextBox.Text = reader.GetString("hair");
                        eyesTextBox.Text = reader.GetString("eyes");
                        birthPlaceTextBox.Text = reader.GetString("placeOfBirth");
                        sentenceTextBox.Text = reader.GetString("sentence");
                        convictionDateTextBox.Text = reader.GetString("dateOfConviction");
                        liberationDateTextBox.Text = reader.GetString("dateToBeLiberated");
                        photoTextBox.Text = reader.GetString("photo");

                        string photoName = photoTextBox.Text;
                        Image newImage = Image.FromFile(photoName);
                        prisonerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        prisonerPictureBox.Image = newImage;
                    }
                    //Close reader and connection
                    reader.Close();
                    connection.Close();
                }//try and catch for exceptiopn handeling
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
            }
            else
            {
                //ID must not be 0!
                MessageBox.Show("Search id must be greater than zero!");
            }
        }

        //Event where double clicking picture box opens file directory to add a picture
        private void addPictureEvent(object sender, EventArgs e)
        {
            //displayed label become invisible
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
                }//try catch if file path exeeds 25 characters
                catch (Exception ex)
                {
                    MessageBox.Show("Error with picture file path:", ex.Message);
                }
            }

        }
    }
}
