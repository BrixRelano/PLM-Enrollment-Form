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
    public partial class fctClass : Form
    {
        public static string fctLog;
        public fctClass()
        {
            InitializeComponent();
        }

        private void fctClassBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fctClassBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet5);

        }

        private void fctClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.fctClass' table. You can move, or remove it, as needed.
            this.fctClassTableAdapter.Fill(this.dataSet5.fctClass);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fctProfile fctpr = new fctProfile();
            fctLog = facultyLogin.user1;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\fctProfile.mdf;Integrated Security=True");
            con.Open();
            if (fctLog != "")
            {
                SqlCommand cmd = new SqlCommand("Select Name, Address, ContactNumber, Sex, Status, Department from fctProfile where Name = @Name", con);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = fctLog;
                SqlDataReader da1 = cmd.ExecuteReader();
               
                while (da1.Read())
                {

                    fctpr.nameTextBox.Text = (string)da1.GetValue(0);
                    fctpr.addressTextBox.Text = (string)da1.GetValue(1);
                    fctpr.contactNumberTextBox.Text = (string)da1.GetValue(2);
                    fctpr.sexTextBox.Text = (string)da1.GetValue(3);
                    fctpr.statusTextBox.Text = (string)da1.GetValue(4);
                    fctpr.departmentTextBox.Text = (string)da1.GetValue(5);

                }


                con.Close();
            }
            else MessageBox.Show("error");
            this.Hide();
            fctpr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm lgf = new loginForm();
            this.Hide();
            lgf.Show();
        }
    }
}
