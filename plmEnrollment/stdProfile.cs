using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plmEnrollment
{
    public partial class stdProfile : Form
    {
        
        public stdProfile()
        {
            InitializeComponent();
        }

        private void stdInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stdInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentAccess stda = new studentAccess();
            this.Hide();
            stda.Show();
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
