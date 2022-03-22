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
    public partial class userSubs : Form
    {
        public userSubs()
        {
            InitializeComponent();
        }

        private void userSubsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userSubsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet4);

        }

        private void userSubs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.userSubs' table. You can move, or remove it, as needed.
            this.userSubsTableAdapter.Fill(this.dataSet4.userSubs);
            dataGridViewTextBoxColumn1.Visible = false;

        }

        private void userSubsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Data reset
            //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\userSubs.mdf;Integrated Security=True");

            //string sqlStatement = "DELETE FROM userSubs";

            //try
            //{
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand(sqlStatement, connection);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.ExecuteNonQuery();

            //}
            //finally
            //{
            //    connection.Close();
            //}
            studentAccess stdacc = new studentAccess();
            this.Hide();
            stdacc.Show();
        }
    }
}
