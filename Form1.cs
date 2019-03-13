using MobilePhone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneShopApp
{
    //NEW
    public partial class FormShop : Form
    {
        //create phonelot object
        Shop shop;
       
        private int currentMobilePhone;
        StringBuilder findString = new StringBuilder();


        //the form manages a mobile phone object

        public FormShop()
        {
            InitializeComponent();
            
        }
        

        private void FormShop_Load(object sender, EventArgs e)
        {
            shop = new Shop();
            
            //ceate object mobile phones and add phones to it
            AndroidPhone android0 = new AndroidPhone("Samsung", "S8 Edge", new DateTime(2017, 9, 15), 700, MobilePhone.Condition.mint, MobilePhone.OpSystem.android);
            AndroidPhone android1 = new AndroidPhone("Samsung", "S8", new DateTime(2017, 6, 15), 600, MobilePhone.Condition.good, MobilePhone.OpSystem.android);
            AndroidPhone android2 = new AndroidPhone("Samsung", "S7 Edge", new DateTime(2016, 8, 15), 500, MobilePhone.Condition.mint, MobilePhone.OpSystem.android);
            AndroidPhone android3 = new AndroidPhone("Samsung", "S7", new DateTime(2016, 4, 15), 400, MobilePhone.Condition.fair, MobilePhone.OpSystem.android);
            AndroidPhone android4 = new AndroidPhone("Samsung", "S6 Edge", new DateTime(2015, 7, 15), 350, MobilePhone.Condition.good, MobilePhone.OpSystem.android);
            AndroidPhone android5 = new AndroidPhone("Samsung", "S6", new DateTime(2015, 6, 15), 300, MobilePhone.Condition.good, MobilePhone.OpSystem.android);
            AndroidPhone android6 = new AndroidPhone("Samsung", "S5", new DateTime(2014, 4, 15), 200, MobilePhone.Condition.poor, MobilePhone.OpSystem.android);
            AndroidPhone android7 = new AndroidPhone("LG", "G6", new DateTime(2016, 10, 15), 500, MobilePhone.Condition.mint, MobilePhone.OpSystem.android);
            AndroidPhone android8 = new AndroidPhone("LG", "G5", new DateTime(2015, 4, 15), 500, MobilePhone.Condition.fair, MobilePhone.OpSystem.android);

            //add android phone to the shop list
            shop.AddMobilePhone(android0);
            shop.AddMobilePhone(android1);
            shop.AddMobilePhone(android2);
            shop.AddMobilePhone(android3);
            shop.AddMobilePhone(android4);
            shop.AddMobilePhone(android5);
            shop.AddMobilePhone(android6);
            shop.AddMobilePhone(android7);
            shop.AddMobilePhone(android8);
           
            // add whatever object to the listbox
            listPhonesForSale.Items.Add("pojP");

            //then display 
            DisplayMobilePhone();

        }

        private void DisplayMobilePhone()
        {
            
            labelCurrentMobilePhone.Text = string.Format("Viewing {0} of {1}", shop.MobilePhoneCurrentlyDisplayed + 1, shop.NumberOfMobilePhone);

            
            //display data to the textbox apropriate
            textBoxMake.Text = shop.GetMobilePhoneMake();

            textBoxModel.Text = shop.GetMobilePhoneModel();
           
            textBoxReleasedDate.Text = shop.GetReleasedDate().ToString();

            textBoxOperatingSystem.Text = shop.GetOpSystem();

            textBoxOriginalValue.Text = string.Format("{0}", shop.GetOriginalValue());

            textBoxCalculateApproxYears.Text = shop.GetPhoneAgeInYears().ToString();

            textBoxCalculateApproxValue.Text = shop.GetCalculateApproxValue().ToString();

            textBoxCondition.Text = shop.DescribeCurrentMobilePhone().ToString();
            
            listPhonesForSale.Items.Clear();

            for (int i = 0; i < shop.ListCount(); i++)
            {
                listPhonesForSale.Items.Add(shop.ListMobiles(i));
            }


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {//go to the next
            shop.StepToNextMobilePhone();
            //and update the display
           DisplayMobilePhone();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {// go to the previous
            shop.StepToPreviousMobilePhone();
            //and update the display

            DisplayMobilePhone();
        }
        
        private void listPhonesForSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = listPhonesForSale.SelectedIndex;

            shop.SetCurrent(selected);
            
            DisplayMobilePhone(selected);
          
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {//this displays the add phone form and passes an mobile phone object and
         //a reference to the phoneList
         //if the dialog returns ok then the filled out phone details are
         //added to the list
          
            FormAddNewPhone openFormAdd = new FormAddNewPhone(shop);
            openFormAdd.Show();

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FormFindPhone findForm = new FormFindPhone(findString);
            //findForm.Show();
            //Visible = false;

            if ((findForm.ShowDialog()) == System.Windows.Forms.DialogResult.OK)
            {
                //here we search - we need a string object for the name, not stringbuilder

                string make = findString.ToString();

                int i = 0;
                bool found = false;

                // we search till we either reach the end of the arraylist or we have found the animal


                while ((i < shop.listMobilePhoneStock.Count) & (!found))
                {
                    //this is to make the search case insensitive - 
                    
                    if (shop.listMobilePhoneStock[i].Make.ToLower() == make.ToLower())
                    {
                        found = true;
                        //don't step to next one if found - we use counter to tell us
                        //which one we stopped at
                    }
                    else
                    {
                        i += 1;
                    }
                }

                if (found)
                {
                    //look at the found mobilephone
                    currentMobilePhone = i;
                    DisplayMobilePhone(currentMobilePhone);
                }
                else
                {
                    MessageBox.Show(make + " was not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // check if there is an phone to delete
            if (currentMobilePhone < shop.listMobilePhoneStock.Count)
            {
                string currentPhoneMake = shop.listMobilePhoneStock[currentMobilePhone].Make;

                if (MessageBox.Show("Delete " + currentPhoneMake + ". Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    DeleteCurrentPhone();

                }
            }
        }

        
        private void buttonSave_Click(object sender, EventArgs e)
        {//call the constructor
            SavePhoneList();
        }

        private void SavePhoneList()
        {
            //create the save dialog and give it sensible default values

            string saveFilename = null;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = ".txt";
            saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveDialog.Filter = "Mobile phone list files (text)|*.txt";
            saveDialog.FileName = "phone_data.txt";
            DialogResult dr = saveDialog.ShowDialog();

            if (dr== System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    saveFilename = saveDialog.FileName;

                    System.IO.FileStream s = new System.IO.FileStream(saveFilename, System.IO.FileMode.Create);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    f.Serialize(s, shop.listMobilePhoneStock ); 
                    s.Close();
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void EnableValidControls()
        {//these buttons would be activated using bool logic to avoid grey out start to end list
            buttonPrevious.Enabled = Convert.ToBoolean(shop.listMobilePhoneStock.Count > 1);
            buttonNext.Enabled = Convert.ToBoolean(shop.listMobilePhoneStock.Count > 1);
            buttonDelete.Enabled = Convert.ToBoolean(shop.listMobilePhoneStock.Count > 0);
        }

        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //call the constructor
            LoadPhoneList();
        }

        private void LoadPhoneList()
        {
            //declare and set value
            string fileName = null;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = "*.txt";

             //display extention file type allowed
            openDialog.Filter = "Mobile phone list files (text)|*.txt";

            //create file type txt name Phone_data.txt
            openDialog.FileName = "phone_data.txt";

            //Get main saved file directory
            openDialog.InitialDirectory = Directory.GetCurrentDirectory();

            //display dialog box
            DialogResult dr = openDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                //could fail - so we have a try catch block
                //also we load to a second copy of the phone list
                //then if the load is ok we copy the data to the original list
                //
                //this means that if the load fails we won't lose any original list

                try
                {
                    fileName = openDialog.FileName;
                    
                        System.IO.FileStream filestream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    List<MobilePhone> restoredPhoneList = null;
                    restoredPhoneList = (List<MobilePhone>)f.Deserialize(filestream);

                    //check if the file is empty
                    //if (filestream.Length == 0)

                        filestream.Close();

                    // copy this across to the real one

                    shop.listMobilePhoneStock = restoredPhoneList;

                    //looking at 1st mobilephone (if it exists)
                  currentMobilePhone = 0;

                    // display current phone
                    DisplayMobilePhone(currentMobilePhone);

                    //call the constroctor
                    EnableValidControls();
                   
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                  
                }

            }
        }

       
        private void DeleteCurrentPhone()
        {
            if (shop.listMobilePhoneStock.Count > 0)
            {
                string make = shop.listMobilePhoneStock[currentMobilePhone].Make;

                //delete it
                shop.listMobilePhoneStock.RemoveAt(currentMobilePhone);

                //if we were looking at the last animal in the list then step back 1
                //(otherwise we leave the currentAnimal unchanged)

                if (currentMobilePhone >= shop.listMobilePhoneStock.Count)
                {
                    //except of course if we deleted the only animal we can't step back to -1

                    if ((shop.listMobilePhoneStock.Count > 0))
                    {
                        currentMobilePhone = shop.listMobilePhoneStock.Count - 1;
                    }
                    else
                    {
                        currentMobilePhone = 0;
                    }
                }

                //currentMobilePhone will have changed so redraw the display
                DisplayMobilePhone(currentMobilePhone);
                MessageBox.Show(make + " deleted", "Delete Phone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayMobilePhone(int currentMobilePhone)
        {
        
        }

    
        private void buttonSort_Click(object sender, EventArgs e)
        {
            //sort to a List of mobile phone
            shop.listMobilePhoneStock.Sort();
            // display current phone
            DisplayMobilePhone(currentMobilePhone);
        }

    }

    
}

