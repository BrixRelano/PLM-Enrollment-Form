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
    public partial class loginForm : Form
    {
        studentLogin std = new studentLogin();
        facultyLogin fcl = new facultyLogin();
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            std.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();           
            fcl.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
