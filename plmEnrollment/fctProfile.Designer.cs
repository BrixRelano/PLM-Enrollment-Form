namespace plmEnrollment
{
    partial class fctProfile
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactNumberLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label departmentLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fctProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new plmEnrollment.DataSet2();
            this.fctProfileTableAdapter = new plmEnrollment.DataSet2TableAdapters.fctProfileTableAdapter();
            this.tableAdapterManager = new plmEnrollment.DataSet2TableAdapters.TableAdapterManager();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactNumberLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(contactNumberLabel);
            this.groupBox1.Controls.Add(this.contactNumberTextBox);
            this.groupBox1.Controls.Add(sexLabel);
            this.groupBox1.Controls.Add(this.sexTextBox);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(departmentLabel);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(154, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 302);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faculty Profile";
            // 
            // fctProfileBindingSource
            // 
            this.fctProfileBindingSource.DataMember = "fctProfile";
            this.fctProfileBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fctProfileTableAdapter
            // 
            this.fctProfileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fctProfileTableAdapter = this.fctProfileTableAdapter;
            this.tableAdapterManager.UpdateOrder = plmEnrollment.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox3.Location = new System.Drawing.Point(463, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(660, 94);
            this.pictureBox3.TabIndex = 24;
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
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::plmEnrollment.Properties.Resources.imageedit_1_5127447814;
            this.pictureBox4.Location = new System.Drawing.Point(632, 161);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(427, 384);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
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
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(83, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fctProfileBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(218, 86);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(372, 86);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fctProfileBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(490, 63);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.addressTextBox.Size = new System.Drawing.Size(162, 63);
            this.addressTextBox.TabIndex = 3;
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new System.Drawing.Point(83, 126);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new System.Drawing.Size(129, 20);
            contactNumberLabel.TabIndex = 4;
            contactNumberLabel.Text = "Contact Number:";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fctProfileBindingSource, "ContactNumber", true));
            this.contactNumberTextBox.Location = new System.Drawing.Point(218, 123);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.ReadOnly = true;
            this.contactNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.contactNumberTextBox.TabIndex = 5;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(83, 158);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(40, 20);
            sexLabel.TabIndex = 6;
            sexLabel.Text = "Sex:";
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fctProfileBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(218, 155);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(100, 26);
            this.sexTextBox.TabIndex = 7;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(83, 190);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(60, 20);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fctProfileBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(218, 187);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(100, 26);
            this.statusTextBox.TabIndex = 9;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(372, 193);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(98, 20);
            departmentLabel.TabIndex = 10;
            departmentLabel.Text = "Department:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fctProfileBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(490, 172);
            this.departmentTextBox.Multiline = true;
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.departmentTextBox.Size = new System.Drawing.Size(162, 65);
            this.departmentTextBox.TabIndex = 11;
            // 
            // fctProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1123, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fctProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource fctProfileBindingSource;
        private DataSet2TableAdapters.fctProfileTableAdapter fctProfileTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox addressTextBox;
        public System.Windows.Forms.TextBox contactNumberTextBox;
        public System.Windows.Forms.TextBox sexTextBox;
        public System.Windows.Forms.TextBox statusTextBox;
        public System.Windows.Forms.TextBox departmentTextBox;
    }
}