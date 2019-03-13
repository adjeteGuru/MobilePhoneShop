using MobilePhoneShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneShopApp

{
    public partial class FormAddNewPhone : Form
    {
        // create an object of a phonelot class to pass
        //information to the main form a permission
       private Shop shop;

        //private MobilePhone mobilePhone;


        //create a parameter of form Add new phone constructor
        public FormAddNewPhone (Shop shop)
        
        {
            InitializeComponent();

            //this object is passing an object reference to the main form list

            this.shop = shop;
       

            buttonOk.Enabled = false;
        }


        private void FormAddNewPhone_Load(object sender, EventArgs e)
        {//set up the textbox
            InitialiseControls();

            foreach (var item in Enum.GetValues(typeof(OpSystem)))
            {
                comboBoxOS1.Items.Add(item);
            }
            
            foreach (var item2 in Enum.GetValues(typeof(Condition)))
            {
                comboBoxCondition1.Items.Add(item2);
            }

        }

        public enum OpSystem
        {
            android,
            appleiOS,
            windowsOS,
            blackberryOS,
        }
        public enum Condition
        {
            poor,
            fair,
            good,
            mint,
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //create an object for a specific mobile type then go through is statement

            if (comboBoxOS1.Text == "android")
            {
                //then from its inputbox grabed its attributes and assign them to the object of the main form
               
                AndroidPhone android0 = new AndroidPhone(textBoxMake1.Text, textBoxModel1.Text, Convert.ToDateTime(textBoxReleasedDate1.Text),
                 Convert.ToDecimal(textBoxOriginalValue1.Text), (MobilePhone.Condition)comboBoxCondition1.SelectedIndex, (MobilePhone.OpSystem)comboBoxOS1.SelectedIndex);
                
                // put that object to the list Shop using the reference
                shop.AddMobilePhone(android0);
            }
            else if (comboBoxOS1.Text == "appleiOS")
            {//then from its inputbox grabed its attributes and assign them to the object of the main form
                
                ApplePhone apple0 = new ApplePhone(textBoxMake1.Text, textBoxModel1.Text, Convert.ToDateTime(textBoxReleasedDate1.Text),
               Convert.ToDecimal(textBoxOriginalValue1.Text), (MobilePhone.Condition)comboBoxCondition1.SelectedIndex, (MobilePhone.OpSystem)comboBoxOS1.SelectedIndex);
                
                // put that object to the list Shop using the reference
                shop.AddMobilePhone(apple0);
            }

            else if (comboBoxOS1.Text == "windowsOS")
            {//then from its inputbox grabed its attributes and assign them to the object of the main form
               
                WindowsPhone windows0 = new WindowsPhone(textBoxMake1.Text, textBoxModel1.Text, Convert.ToDateTime(textBoxReleasedDate1.Text),
               Convert.ToDecimal(textBoxOriginalValue1.Text), (MobilePhone.Condition)comboBoxCondition1.SelectedIndex, (MobilePhone.OpSystem)comboBoxOS1.SelectedIndex);
                
                // put that object to the list Shop using the reference
                shop.AddMobilePhone(windows0);
            }

            else if (comboBoxOS1.Text == "blackberryOS")
            {//then from its inputbox grabed its attributes and assign them to the object of the main form
                
                BlackberryPhone blackberry0 = new BlackberryPhone(textBoxMake1.Text, textBoxModel1.Text, Convert.ToDateTime(textBoxReleasedDate1.Text),
               Convert.ToDecimal(textBoxOriginalValue1.Text), (MobilePhone.Condition)comboBoxCondition1.SelectedIndex, (MobilePhone.OpSystem)comboBoxOS1.SelectedIndex);
                
                // put that object to the list Shop using the reference
                shop.AddMobilePhone(blackberry0);
            }

            else
            {

                MessageBox.Show("Unrecognised Mobile phone");
            }

            this.Close();
        }

        private void InitialiseControls()
        {
            textBoxMake1.Text = shop.GetMobilePhoneMake();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxOS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
        }

        private void comboBoxOS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // we disallow typing in the combo box.
            e.Handled = true;
        }
    }
}
