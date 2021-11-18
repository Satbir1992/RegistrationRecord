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

namespace RegistrationRecord
{
    public partial class RegistrationRecord : Form
    {
        public RegistrationRecord()
        {
            InitializeComponent();
        }
        List<string> NumberList = new List<string> { "1ETU-942", "1DNG-675", "1GSA-650", "ICGA-449" };
        string currentFileName = "";
        #region Display Function
        private void DisplayRego()
        {
            
            VehiclePlateDisplay.Items.Clear();
            NumberList.Sort();
            foreach (var number in NumberList)
            {
                VehiclePlateDisplay.Items.Add(number);
            }
        }
        
        #endregion

       #region WrongClick
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VehiclePlateDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
       
        #endregion
        #region Utilities
        private void TextBoxClearFocus()
        {
            TextBoxNumber.Clear();
            TextBoxNumber.Focus();
            
        }
         
        #endregion
        private void RegistrationRecord_Load(object sender, EventArgs e)
        {
            TextBoxNumber.CharacterCasing = CharacterCasing.Upper;
            TextBoxNumber.MaxLength = 8;
            DisplayRego();
            
            
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            
            if (TextBoxNumber.Text != "")
            {
                if (VehiclePlateDisplay.Items.Contains(TextBoxNumber.Text))
                {
                    toolStripStatusLabel1.Text = "Duplicate Rego number can not be added";
                }
                else
                {
                    NumberList.Add(TextBoxNumber.Text);
                    toolStripStatusLabel1.Text = "Successfully Added";
                }
                
            }
            else
            {
                MessageBox.Show("Enter the Number in Box","System Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            DisplayRego();
            TextBoxClearFocus();
            
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            
            NumberList.Clear();
            VehiclePlateDisplay.Items.Clear();
                   

        }

        private void RegistrationRecord_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

             
        private void ButtonExit_Click(object sender, EventArgs e)
        {
                       
           if (TextBoxNumber.Text != "")
            {
                
                foreach (var search in NumberList)
                {

                    if (TextBoxNumber.Text == search)
                    {

                        NumberList.Remove(search);
                        VehiclePlateDisplay.Items.Remove(search);
                        toolStripStatusLabel1.Text = "Vehicle Rego Successfully removed";
                        TextBoxClearFocus();
                        
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
                toolStripStatusLabel1.Text = "Select a Rego Number From the List or Enter Rego Number in Vehicle plate details box";
            }
                
            
        }

        private void VehiclePlateDisplay_Click(object sender, EventArgs e)
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

        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {
            if (TextBoxNumber.Text != "")
            {
                NumberList.Sort();
                if (NumberList.BinarySearch(TextBoxNumber.Text) >= 0)
                    MessageBox.Show("Vehicle Number "+TextBoxNumber.Text + " is parked in line " +(VehiclePlateDisplay.Items.IndexOf(TextBoxNumber.Text)+1));
                else
                    MessageBox.Show("Not Found");
                
            }
            else
            {
                toolStripStatusLabel1.Text = "Enter Rego Number";
            }
            TextBoxClearFocus();
            
            
        }

        private void ButtonLinearSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (TextBoxNumber.Text != "")
            {
                
                
                foreach (var target in NumberList)
                {

                    
                    
                    if (target == TextBoxNumber.Text)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    MessageBox.Show("Vehicle Number "+TextBoxNumber.Text + " is parked in line " + (VehiclePlateDisplay.Items.IndexOf(TextBoxNumber.Text)+1),
                       "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("Number not found",
                        "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else
            {
                toolStripStatusLabel1.Text = "Search Failed: Please enter rego number into text box";

            }
            
            TextBoxClearFocus();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if(VehiclePlateDisplay.SelectedIndex != -1)
            {
             DialogResult modifyTask = MessageBox.Show("Do you want to Continue?", "It will permanently modify the data.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (modifyTask == DialogResult.Yes)

                    {
                        
                        int idx = VehiclePlateDisplay.Items.IndexOf(VehiclePlateDisplay.SelectedItem);

                        NumberList.RemoveAt(idx);
                        NumberList.Insert(idx, TextBoxNumber.Text);
                    toolStripStatusLabel1.Text = "Rego Number Successfully Changed";

                    }
                    else
                    {
                    toolStripStatusLabel1.Text = "User had cancelled to modify";
                    }
                
             
            }
            else
            {
                toolStripStatusLabel1.Text = "User need to select data from the list";
            }
            DisplayRego();
            TextBoxClearFocus();
        }

        private void ButtonTag_Click(object sender, EventArgs e)
        {
            tagItem();
        }
        private void tagItem()
        {
            
            if(VehiclePlateDisplay.SelectedIndex != -1)
            {
                
                int idx = VehiclePlateDisplay.Items.IndexOf(VehiclePlateDisplay.SelectedItem);
                
                NumberList.RemoveAt(idx);
                NumberList.Insert(idx, "Z" + TextBoxNumber.Text);
                
                toolStripStatusLabel1.Text = "Rego Number Successfully tagged";
            }
            else
            {
                toolStripStatusLabel1.Text = "User need to select data from the list";
            }
            DisplayRego();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string fileName = "demo_01.txt";
            SaveFileDialog SaveText = new SaveFileDialog();
            DialogResult sr = SaveText.ShowDialog();
            SaveText.Filter = "|*.txt";
            if (sr == DialogResult.OK)
            {
                fileName = SaveText.FileName;
            }
            if (sr == DialogResult.Cancel)
            {
                SaveText.FileName = fileName;
            }
            // Validate file name and increment
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (var number in NumberList)
                    {
                        writer.WriteLine(number);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File NOT saved");
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            string fileName = "demo_01.txt";
            OpenFileDialog OpenText = new OpenFileDialog();
            DialogResult sr = OpenText.ShowDialog();
            if (sr == DialogResult.OK)
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
                        NumberList.Add(reader.ReadLine());
                    }
                }
                DisplayRego();
            }
            catch (IOException)
            {
                MessageBox.Show("file not openned");
            }
        }

        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumber.MaxLength = 8;
            if(!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                toolStripStatusLabel1.Text = "No Character should be in Rego Number"; 
            }
                  
            

        }

        private void TextBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            TextBoxNumber.MaxLength = 8;
        }
    }
 
}
