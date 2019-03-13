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
    public partial class FormFindPhone : Form
    {
        private StringBuilder findName;


        public FormFindPhone(StringBuilder findName)
        {
            InitializeComponent();
            
            this.findName = findName;
            buttonFind.Enabled = textBoxFindPhone.Text != "";
            textBoxFindPhone.Text = this.findName.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //we pass back the shop to find - maybe not if text box is empty.
            findName.Clear();
            findName.Append(textBoxFindPhone.Text.Trim());
          
            this.Close();
        }

        private void textBoxFindPhone_TextChanged(object sender, EventArgs e)
        {
            // only enable find if text box not empty
            buttonFind.Enabled = textBoxFindPhone.Text != "";
        }

        private void FormFindPhone_Load(object sender, EventArgs e)
        {

        }
    }
}
