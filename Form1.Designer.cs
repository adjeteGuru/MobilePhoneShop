namespace MobilePhoneShopApp
{
    partial class FormShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPhonesForSale = new System.Windows.Forms.ListBox();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxReleasedDate = new System.Windows.Forms.TextBox();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelReleasedDate = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.LabelOriginalValue = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxOriginalValue = new System.Windows.Forms.TextBox();
            this.textBoxCalculateApproxValue = new System.Windows.Forms.TextBox();
            this.textBoxCalculateApproxYears = new System.Windows.Forms.TextBox();
            this.labelCurrentMobilePhone = new System.Windows.Forms.Label();
            this.labelOS = new System.Windows.Forms.Label();
            this.labelCalculated = new System.Windows.Forms.Label();
            this.labelCalculatedYearInAge = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.textBoxOperatingSystem = new System.Windows.Forms.TextBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.labelPhoneForYou = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhones = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // listPhonesForSale
            // 
            this.listPhonesForSale.FormattingEnabled = true;
            this.listPhonesForSale.Location = new System.Drawing.Point(12, 12);
            this.listPhonesForSale.Name = "listPhonesForSale";
            this.listPhonesForSale.Size = new System.Drawing.Size(120, 160);
            this.listPhonesForSale.TabIndex = 1;
            this.listPhonesForSale.SelectedIndexChanged += new System.EventHandler(this.listPhonesForSale_SelectedIndexChanged);
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(451, 230);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(100, 20);
            this.textBoxMake.TabIndex = 4;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(451, 256);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 5;
            // 
            // textBoxReleasedDate
            // 
            this.textBoxReleasedDate.Location = new System.Drawing.Point(451, 338);
            this.textBoxReleasedDate.Name = "textBoxReleasedDate";
            this.textBoxReleasedDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReleasedDate.TabIndex = 6;
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(402, 237);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(34, 13);
            this.labelMake.TabIndex = 7;
            this.labelMake.Text = "Make";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(400, 263);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 8;
            this.labelModel.Text = "Model";
            // 
            // labelReleasedDate
            // 
            this.labelReleasedDate.AutoSize = true;
            this.labelReleasedDate.Location = new System.Drawing.Point(358, 345);
            this.labelReleasedDate.Name = "labelReleasedDate";
            this.labelReleasedDate.Size = new System.Drawing.Size(78, 13);
            this.labelReleasedDate.TabIndex = 9;
            this.labelReleasedDate.Text = "Released Date";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(11, 178);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(57, 23);
            this.buttonPrevious.TabIndex = 10;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(75, 178);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(57, 23);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // LabelOriginalValue
            // 
            this.LabelOriginalValue.AutoSize = true;
            this.LabelOriginalValue.Location = new System.Drawing.Point(349, 393);
            this.LabelOriginalValue.Name = "LabelOriginalValue";
            this.LabelOriginalValue.Size = new System.Drawing.Size(87, 13);
            this.LabelOriginalValue.TabIndex = 12;
            this.LabelOriginalValue.Text = "Original Value (£)";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(385, 319);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(51, 13);
            this.labelCondition.TabIndex = 13;
            this.labelCondition.Text = "Condition";
            // 
            // textBoxOriginalValue
            // 
            this.textBoxOriginalValue.Location = new System.Drawing.Point(451, 390);
            this.textBoxOriginalValue.Name = "textBoxOriginalValue";
            this.textBoxOriginalValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxOriginalValue.TabIndex = 14;
            // 
            // textBoxCalculateApproxValue
            // 
            this.textBoxCalculateApproxValue.Location = new System.Drawing.Point(451, 416);
            this.textBoxCalculateApproxValue.Name = "textBoxCalculateApproxValue";
            this.textBoxCalculateApproxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalculateApproxValue.TabIndex = 16;
            // 
            // textBoxCalculateApproxYears
            // 
            this.textBoxCalculateApproxYears.Location = new System.Drawing.Point(451, 364);
            this.textBoxCalculateApproxYears.Name = "textBoxCalculateApproxYears";
            this.textBoxCalculateApproxYears.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalculateApproxYears.TabIndex = 21;
            // 
            // labelCurrentMobilePhone
            // 
            this.labelCurrentMobilePhone.AutoSize = true;
            this.labelCurrentMobilePhone.Location = new System.Drawing.Point(312, 133);
            this.labelCurrentMobilePhone.Name = "labelCurrentMobilePhone";
            this.labelCurrentMobilePhone.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentMobilePhone.TabIndex = 23;
            // 
            // labelOS
            // 
            this.labelOS.AutoSize = true;
            this.labelOS.Location = new System.Drawing.Point(346, 290);
            this.labelOS.Name = "labelOS";
            this.labelOS.Size = new System.Drawing.Size(90, 13);
            this.labelOS.TabIndex = 26;
            this.labelOS.Text = "Operating System";
            // 
            // labelCalculated
            // 
            this.labelCalculated.AutoSize = true;
            this.labelCalculated.Location = new System.Drawing.Point(349, 419);
            this.labelCalculated.Name = "labelCalculated";
            this.labelCalculated.Size = new System.Drawing.Size(87, 13);
            this.labelCalculated.TabIndex = 28;
            this.labelCalculated.Text = "Calculated Value";
            // 
            // labelCalculatedYearInAge
            // 
            this.labelCalculatedYearInAge.AutoSize = true;
            this.labelCalculatedYearInAge.Location = new System.Drawing.Point(365, 367);
            this.labelCalculatedYearInAge.Name = "labelCalculatedYearInAge";
            this.labelCalculatedYearInAge.Size = new System.Drawing.Size(71, 13);
            this.labelCalculatedYearInAge.TabIndex = 29;
            this.labelCalculatedYearInAge.Text = "Age In Years ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 301);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 39);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(120, 344);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 40);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(120, 301);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 40);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(39, 388);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 40);
            this.buttonLoad.TabIndex = 33;
            this.buttonLoad.Text = "Loaded";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(120, 389);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 39);
            this.buttonSort.TabIndex = 34;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // textBoxOperatingSystem
            // 
            this.textBoxOperatingSystem.Location = new System.Drawing.Point(451, 282);
            this.textBoxOperatingSystem.Name = "textBoxOperatingSystem";
            this.textBoxOperatingSystem.Size = new System.Drawing.Size(100, 20);
            this.textBoxOperatingSystem.TabIndex = 35;
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(451, 308);
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(100, 20);
            this.textBoxCondition.TabIndex = 36;
            // 
            // labelPhoneForYou
            // 
            this.labelPhoneForYou.AutoSize = true;
            this.labelPhoneForYou.BackColor = System.Drawing.SystemColors.Control;
            this.labelPhoneForYou.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPhoneForYou.Location = new System.Drawing.Point(252, 118);
            this.labelPhoneForYou.Name = "labelPhoneForYou";
            this.labelPhoneForYou.Size = new System.Drawing.Size(74, 15);
            this.labelPhoneForYou.TabIndex = 20;
            this.labelPhoneForYou.Text = "PhoneForYou";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(39, 344);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 40);
            this.buttonFind.TabIndex = 38;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::MobilePhone.Properties.Resources.phoneShopLOGO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(229, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(114, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 37;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxPhones
            // 
            this.pictureBoxPhones.Location = new System.Drawing.Point(451, 12);
            this.pictureBoxPhones.Name = "pictureBoxPhones";
            this.pictureBoxPhones.Size = new System.Drawing.Size(125, 194);
            this.pictureBoxPhones.TabIndex = 0;
            this.pictureBoxPhones.TabStop = false;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.textBoxOperatingSystem);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCalculatedYearInAge);
            this.Controls.Add(this.labelCalculated);
            this.Controls.Add(this.labelOS);
            this.Controls.Add(this.labelCurrentMobilePhone);
            this.Controls.Add(this.textBoxCalculateApproxYears);
            this.Controls.Add(this.labelPhoneForYou);
            this.Controls.Add(this.textBoxCalculateApproxValue);
            this.Controls.Add(this.textBoxOriginalValue);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.LabelOriginalValue);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.labelReleasedDate);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.textBoxReleasedDate);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.listPhonesForSale);
            this.Controls.Add(this.pictureBoxPhones);
            this.Name = "FormShop";
            this.Text = "SHOP";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhones;
        private System.Windows.Forms.ListBox listPhonesForSale;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxReleasedDate;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelReleasedDate;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label LabelOriginalValue;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxOriginalValue;
        private System.Windows.Forms.TextBox textBoxCalculateApproxValue;
        private System.Windows.Forms.TextBox textBoxCalculateApproxYears;
        private System.Windows.Forms.Label labelCurrentMobilePhone;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.Label labelCalculated;
        private System.Windows.Forms.Label labelCalculatedYearInAge;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxOperatingSystem;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.Label labelPhoneForYou;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonFind;
    }
}

