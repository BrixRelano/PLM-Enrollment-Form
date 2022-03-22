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
    public partial class facultyLogin : Form
    {
        int count = 0;
        public static string user1;
        public facultyLogin()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void facultyLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog = fclLoginInfo; AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\fctLoginInfo.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM fclLoginInfo WHERE Username = '" + textBox1.Text.Trim() + "' AND Password = '" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        user1 = textBox1.Text.Trim();
                        fctClass fctcl = new fctClass();
                        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\fctClass.mdf;Integrated Security=True");
                        con1.Open();
                        SqlCommand cmd = con1.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from fctClass where Professor = '" + user1 + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        fctcl.fctClassDataGridView.DataSource = dt;
                        con1.Close();

                        textBox1.Text = "";

                    
                        this.Hide();
                        fctcl.Show();
                    }
                    else
                        MessageBox.Show("Invalid Username/Password, please try again!", "Error");
                }
            }
        }
        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid Username please!", "Error");
                return false;
            }
            else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter valid password please!", "Error");
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
