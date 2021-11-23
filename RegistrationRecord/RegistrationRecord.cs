using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//Satbir Singh
//20/11/2021
/*This Application will keep the record of the rego number who enter in to the parking 
and allows user to save and open that data, with the tag, modify and search option*/

namespace RegistrationRecord
{
    public partial class RegistrationRecord : Form
    {
        public RegistrationRecord()
        {
            InitializeComponent();
        }
        List<string> NumberList = new List<string> { "1ETU942", "1DNG675", "1GSA650", "1CGA449" };

        string currentFileName = "";
        #region Display Function
        private void DisplayRego()//Display Rego Numbers In list box
        {
            var rx = new Regex(@"^1[A-Z][A-Z][A-Z][0-9][0-9][0-9]$");//Will validate pattern for rego number starting with 1
            var rx1 = new Regex(@"^Z[1][A-Z][A-Z][A-Z][0-9][0-9][0-9]$");//Will validate pattern for rego number starting with Z
            
            
            VehiclePlateDisplay.Items.Clear();
            NumberList.Sort();
            try
            {
                foreach (var number in NumberList)
                {
                    if (rx.IsMatch(number) || rx1.IsMatch(number))
                    {
                        VehiclePlateDisplay.Items.Add(number);
                    }

                    else
                    {
                        toolStripStatusLabel1.Text = "Invalid Rego number";
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Someting went wrong please check the file or number in file");
            }




        }

        #endregion
        #region Utilities
        private void TextBoxClearFocus()//Clear text box and selected index after any button press
        {
            TextBoxNumber.Clear();
            TextBoxNumber.Focus();
            VehiclePlateDisplay.SelectedIndex = -1;

        }
        private void RegistrationRecord_MouseMove(object sender, MouseEventArgs e)//tool strip empty on mouse move
        {
            toolStripStatusLabel1.Text = "";
        }


        private void RegistrationRecord_Load(object sender, EventArgs e)//Display Pre loaded rego number on start
        {
            TextBoxNumber.CharacterCasing = CharacterCasing.Upper;
            DisplayRego();


        }
        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)//Wont Allow any Characters in Text Box
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolStripStatusLabel1.Text = "No Character should be in Rego Number";
            }



        }

        private void TextBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            TextBoxNumber.MaxLength = 8;

        }
        private void VehiclePlateDisplay_Click(object sender, EventArgs e)//Display The Selected item from the list to text box on click
        {
            if (VehiclePlateDisplay.SelectedItem != null)
            {

                TextBoxNumber.Text = VehiclePlateDisplay.SelectedItem.ToString();

            }
            else
            {
                toolStripStatusLabel1.Text = "Select a number from the List";

            }

        }
        #endregion Utilities
        #region Enter Vehicle Region
        private void ButtonEnter_Click(object sender, EventArgs e)
        {


            if (TextBoxNumber.Text != "")//Run only if number entered in text box
            {
                if (VehiclePlateDisplay.Items.Contains(TextBoxNumber.Text))
                {
                    toolStripStatusLabel1.Text = "Duplicate Rego number can not be added";// Will Not Allow Duplicate Numbers
                }
                else
                {
                    NumberList.Add(TextBoxNumber.Text);//Add Number TO the list
                    toolStripStatusLabel1.Text = "Successfully Added";
                }

            }
            else
            {
                MessageBox.Show("Enter the Number in Text Box", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            DisplayRego();
            TextBoxClearFocus();

        }
        #endregion EnterVehicle
        #region Rego Reset Region
        private void ButtonReset_Click(object sender, EventArgs e)//Clear Numbers From both list and display
        {

            VehiclePlateDisplay.Items.Clear();
            NumberList.Clear();
            TextBoxClearFocus();
            MessageBox.Show("Number List Is Empty", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }
        #endregion Rego Reset
        #region Vehicle Exit Region      
        private void ButtonExit_Click(object sender, EventArgs e)
        {

            if (TextBoxNumber.Text != "")
            {

                foreach (var search in NumberList)// Search for the number entered or selected
                {

                    if (TextBoxNumber.Text == search)//if found then will delete it from list and display 
                    {

                        NumberList.Remove(search);
                        VehiclePlateDisplay.Items.Remove(search);
                        MessageBox.Show("Vehicle Number " + search + " has left the parking ");
                        break;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Vehicle Rego not in list";

                    }
                }
                DisplayRego();
                TextBoxClearFocus();
            }
            else
            {
                MessageBox.Show("Enter the Number in Text Box", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion Vehicle Exit
        #region Binary Search Region
        private void ButtonBinarySearch_Click(object sender, EventArgs e)//Inbuilt Binary Search Method
        {
            if (TextBoxNumber.Text != "")
            {
                NumberList.Sort();
                if (NumberList.BinarySearch(TextBoxNumber.Text) >= 0)
                    MessageBox.Show("Vehicle Number " + TextBoxNumber.Text + " is parked in line " + (VehiclePlateDisplay.Items.IndexOf(TextBoxNumber.Text) + 1));
                else
                    MessageBox.Show("Vehicle Number " + TextBoxNumber.Text + " is not found in the parking");


            }
            else
            {
                MessageBox.Show("Enter the Number in Text Box or select from the list ", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TextBoxClearFocus();


        }
        #endregion Binary Search
        #region Linear Search Region
        private void ButtonLinearSearch_Click(object sender, EventArgs e)//Search Number Based on Linear Search
        {
            bool found = false;
            if (TextBoxNumber.Text != "")
            {


                foreach (var target in NumberList)// Search For the number in the list entered in the text box or selected from list
                {



                    if (target == TextBoxNumber.Text)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)//display this if found
                {
                    MessageBox.Show("Vehicle Number " + TextBoxNumber.Text + " is parked in line " + (VehiclePlateDisplay.Items.IndexOf(TextBoxNumber.Text) + 1),
                       "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else// display this if not found
                    MessageBox.Show("Vehicle number "+TextBoxNumber.Text + " not found",
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else//Show error message if nothing selected or nothing in the text box 
            {
                MessageBox.Show("Enter the Number in Text Box or Select from the list", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            TextBoxClearFocus();
        }
        #endregion Linear Search
        #region Modify Number Region
        private void ButtonModify_Click(object sender, EventArgs e)//update rego number if user need to edit it manually
        {
            var rx = new Regex(@"^1[A-Z][A-Z][A-Z][0-9][0-9][0-9]$");
            if (VehiclePlateDisplay.SelectedIndex != -1 && rx.IsMatch(TextBoxNumber.Text))// only works if user select the number from the list
            {
                DialogResult modifyTask = MessageBox.Show("Do you want to Continue?", "It will permanently modify the data.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (modifyTask == DialogResult.Yes)

                {

                    int idx = VehiclePlateDisplay.Items.IndexOf(VehiclePlateDisplay.SelectedItem);// get the index of selected number

                    NumberList.RemoveAt(idx);//semove that index number
                    NumberList.Insert(idx, TextBoxNumber.Text);//insert the user input to that index if valid patten for rego
                    toolStripStatusLabel1.Text = "Rego Number Successfully Changed";

                }
                else
                {
                    toolStripStatusLabel1.Text = "User had cancelled to modify";
                }


            }
            else
            {
                MessageBox.Show("Select Number From The List or Enter Valid Format to Modify", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayRego();
            TextBoxClearFocus();
        }
        #endregion Modify Number
        #region Tag Number Region
        private void ButtonTag_Click(object sender, EventArgs e)// Tag the rego number with a Character "Z"
        {
            TagItem();
            DisplayRego();
            TextBoxClearFocus();
        }
        private void TagItem()//Function for tag number
        {

            if (VehiclePlateDisplay.SelectedIndex != -1 || TextBoxNumber.Text !="")
            {
                try
                {
                    int idx = VehiclePlateDisplay.Items.IndexOf(TextBoxNumber.Text);
                    NumberList.RemoveAt(idx);
                    NumberList.Insert(idx, "Z" + TextBoxNumber.Text);
                    toolStripStatusLabel1.Text = "Rego Number Successfully tagged";
                }
                catch(Exception)
                {
                    MessageBox.Show("Number not in the list", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            else
            {
                MessageBox.Show("Enter the Number in Text Box or select from list ", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion Tag Number
        #region File Save Region
        private void ButtonSave_Click(object sender, EventArgs e)//Save the file as text file
        {
            SaveFile();
            this.Close();

        }
        private string GetNextFileName(string filename)// Generate the name of the file according to requirement  
        {
            filename = "demo.txt";
            int i = 0;
            string extension = Path.GetExtension(filename);
            string pathName = Path.GetDirectoryName(filename);
            string fileNameOnly = Path.Combine(pathName, Path.GetFileNameWithoutExtension(filename));
            filename = string.Format("{0}{1}{2}", fileNameOnly + "_0", i, extension);//give the first file name

            // If the file exists, keep trying until it doesn't
            while (File.Exists(filename))// only runs if file name already exists
            {
                i += 1;
                if (i < 10)// runs if file vesion with same name less than 10
                    filename = string.Format("{0}{1}{2}", fileNameOnly + "_0", i, extension);
                else//runs for file version after 10
                    filename = string.Format("{0}{1}{2}", fileNameOnly + "_", i, extension);
            }
            return filename;
        }
        private void SaveFile()// Function for Saving a file 
        {
            string fileName = GetNextFileName(".txt");
            SaveFileDialog SaveText = new SaveFileDialog();
            SaveText.Filter = "text files|*.txt";//Text File Display Filter
            DialogResult sr = SaveText.ShowDialog();

            if (sr == DialogResult.OK)// Save the file with the name user enetered
            {
                fileName = SaveText.FileName;

            }


            if (sr == DialogResult.Cancel)//ALso save the file but with auto incermented name
            {

                SaveText.FileName = fileName;
                MessageBox.Show("File Saved with auto name with an increment in version");
            }

            // Validate file name and increment
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (var number in NumberList)
                    {
                        writer.WriteLine(number);//Write the numberList on to a text file 
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File NOT saved");
            }
        }
        #endregion File Save
        #region File Open Region
        private void ButtonOpen_Click(object sender, EventArgs e)//Open only text file
        {
            string fileName = "demo.txt";
            OpenFileDialog OpenText = new OpenFileDialog();

            OpenText.Filter = "text files|*.txt";

            DialogResult sr = OpenText.ShowDialog();
            if (sr == DialogResult.OK)// OPen the selected Text File
            {
                fileName = OpenText.FileName;
            }
            currentFileName = fileName;
            try
            {
                NumberList.Clear();
                using (StreamReader reader = new StreamReader(File.OpenRead(fileName)))
                {
                    while (!reader.EndOfStream)
                    {
                        NumberList.Add(reader.ReadLine());//Read the TExt or number from the file
                    }
                }
                DisplayRego();//display after reading
            }
            catch (IOException)
            {
                MessageBox.Show("file not openned");
                this.Close();
            }
        }
        #endregion File Open
        #region WrongClick
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VehiclePlateDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        #endregion

    }

}
