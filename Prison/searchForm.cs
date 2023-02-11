//Search prisoner form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;
using MySql.Data.MySqlClient;

namespace Prison
{
    public partial class searchForm : Form
    {
        //Create connection to database
        public MySqlConnection? connection;
        private string dbConfig = "Server=localhost;Database=PrisonDB;Uid=root;Pwd=29Bx4Xjkl58ZS976H";
        public searchForm()
        {
            InitializeComponent();
        }

        //Button that when pressed, connects to database and searches foe a specific prisoner using prisoner ID.
        private void searchButton_Click(object sender, EventArgs e)
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

                        //Display image image correcty
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

        //CLear all textboxes and picture box fields with a button
        private void clearButton_Click(object sender, EventArgs e)
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
    }

      
    
}
