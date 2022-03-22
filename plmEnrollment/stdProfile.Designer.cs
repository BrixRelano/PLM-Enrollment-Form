namespace plmEnrollment
{
    partial class stdProfile
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactNoLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label year_LevelLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stdProfile));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.stdInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new plmEnrollment.DataSet1();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.year_LevelTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stdInfoTableAdapter = new plmEnrollment.DataSet1TableAdapters.stdInfoTableAdapter();
            this.tableAdapterManager = new plmEnrollment.DataSet1TableAdapters.TableAdapterManager();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            studentIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactNoLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            year_LevelLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(39, 44);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(94, 20);
            studentIDLabel.TabIndex = 19;
            studentIDLabel.Text = "Student No:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(39, 76);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(39, 108);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 23;
            firstNameLabel.Text = "First Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(39, 140);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(105, 20);
            middleNameLabel.TabIndex = 25;
            middleNameLabel.Text = "Middle Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(39, 188);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 27;
            addressLabel.Text = "Address:";
            // 
            // contactNoLabel
            // 
            contactNoLabel.AutoSize = true;
            contactNoLabel.Location = new System.Drawing.Point(391, 47);
            contactNoLabel.Name = "contactNoLabel";
            contactNoLabel.Size = new System.Drawing.Size(93, 20);
            contactNoLabel.TabIndex = 29;
            contactNoLabel.Text = "Contact No:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(391, 79);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(40, 20);
            sexLabel.TabIndex = 31;
            sexLabel.Text = "Sex:";
            // 
            // year_LevelLabel
            // 
            year_LevelLabel.AutoSize = true;
            year_LevelLabel.Location = new System.Drawing.Point(391, 111);
            year_LevelLabel.Name = "year_LevelLabel";
            year_LevelLabel.Size = new System.Drawing.Size(88, 20);
            year_LevelLabel.TabIndex = 33;
            year_LevelLabel.Text = "Year Level:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(391, 143);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(60, 20);
            statusLabel.TabIndex = 35;
            statusLabel.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(studentIDLabel);
            this.groupBox1.Controls.Add(this.studentIDTextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(middleNameLabel);
            this.groupBox1.Controls.Add(this.middleNameTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(contactNoLabel);
            this.groupBox1.Controls.Add(this.contactNoTextBox);
            this.groupBox1.Controls.Add(sexLabel);
            this.groupBox1.Controls.Add(this.sexTextBox);
            this.groupBox1.Controls.Add(year_LevelLabel);
            this.groupBox1.Controls.Add(this.year_LevelTextBox);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Location = new System.Drawing.Point(154, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 293);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Profile";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "studentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(150, 41);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(164, 26);
            this.studentIDTextBox.TabIndex = 20;
            this.studentIDTextBox.TextChanged += new System.EventHandler(this.studentIDTextBox_TextChanged);
            // 
            // stdInfoBindingSource
            // 
            this.stdInfoBindingSource.DataMember = "stdInfo";
            this.stdInfoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(150, 73);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(164, 26);
            this.lastNameTextBox.TabIndex = 22;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(150, 105);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(164, 26);
            this.firstNameTextBox.TabIndex = 24;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "middleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(150, 137);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.ReadOnly = true;
            this.middleNameTextBox.Size = new System.Drawing.Size(164, 26);
            this.middleNameTextBox.TabIndex = 26;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(150, 185);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.addressTextBox.Size = new System.Drawing.Size(401, 92);
            this.addressTextBox.TabIndex = 28;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "contactNo", true));
            this.contactNoTextBox.Location = new System.Drawing.Point(502, 44);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.ReadOnly = true;
            this.contactNoTextBox.Size = new System.Drawing.Size(164, 26);
            this.contactNoTextBox.TabIndex = 30;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(502, 76);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(164, 26);
            this.sexTextBox.TabIndex = 32;
            // 
            // year_LevelTextBox
            // 
            this.year_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "Year Level", true));
            this.year_LevelTextBox.Location = new System.Drawing.Point(502, 108);
            this.year_LevelTextBox.Name = "year_LevelTextBox";
            this.year_LevelTextBox.ReadOnly = true;
            this.year_LevelTextBox.Size = new System.Drawing.Size(164, 26);
            this.year_LevelTextBox.TabIndex = 34;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stdInfoBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(502, 140);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(164, 26);
            this.statusTextBox.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stdInfoTableAdapter
            // 
            this.stdInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.stdInfoTableAdapter = this.stdInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = plmEnrollment.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox3.Location = new System.Drawing.Point(462, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(660, 94);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox2.Image = global::plmEnrollment.Properties.Resources.plmbanner;
            this.pictureBox2.Location = new System.Drawing.Point(1, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::plmEnrollment.Properties.Resources.imageedit_1_5127447814;
            this.pictureBox4.Location = new System.Drawing.Point(635, 161);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(427, 384);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::plmEnrollment.Properties.Resources.imageedit_1_5127447814;
            this.pictureBox1.Location = new System.Drawing.Point(1, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // stdProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1058, 544);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stdProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Student Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource stdInfoBindingSource;
        private DataSet1TableAdapters.stdInfoTableAdapter stdInfoTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox studentIDTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.TextBox middleNameTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox contactNoTextBox;
        public System.Windows.Forms.TextBox sexTextBox;
        public System.Windows.Forms.TextBox year_LevelTextBox;
        public System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}