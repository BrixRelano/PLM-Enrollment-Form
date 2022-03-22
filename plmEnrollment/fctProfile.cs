using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plmEnrollment
{
    public partial class fctProfile : Form
    {
        public fctProfile()
        {
            InitializeComponent();
        }
        public fctProfile(string text)
        {
            nameTextBox.Text = text;
        }
        private void fctProfileBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fctProfileBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.fctProfile' table. You can move, or remove it, as needed.
            this.fctProfileTableAdapter.Fill(this.dataSet2.fctProfile);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fctClass fctc = new fctClass();
            this.Hide();
            fctc.Show();
        }
    }
}
