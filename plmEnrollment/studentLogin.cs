using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace plmEnrollment
{

    public partial class studentLogin : Form
    {
        int count = 0;
        public static string user;
        public studentLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentAccess stdac = new studentAccess();
            if (isValid())
            {
                using(SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog = stdLoginInfo; AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\stdLoginInfo.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM stdLoginInfo WHERE StudentNumber = '" + textBox1.Text.Trim() + "' AND Password = '" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        user = textBox1.Text.Trim();
                        this.Hide();
                        stdac.Show();
                    }
                    else
                        MessageBox.Show("Invalid Student No./Password, please try again!", "Error");
                }
            }
        }
        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid Student ID please!", "Error");
                return false;
            }
            else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password please!", "Error");
                return false;
            }
            return true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            if (count % 2 == 0)
            {
                textBox2.PasswordChar = '\0';
                count++;
            }
            else
            {
                textBox2.PasswordChar = '*';
                count++;
            }
        }

        private void studentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
