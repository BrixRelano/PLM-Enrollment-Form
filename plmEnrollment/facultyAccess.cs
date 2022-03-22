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
    public partial class facultyAccess : Form
    {
       
        
        public facultyAccess()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            fctProfile fctp = new fctProfile();
            

            this.Hide();
            fctp.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
