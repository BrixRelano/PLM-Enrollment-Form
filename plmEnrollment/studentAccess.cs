using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace plmEnrollment
{
    public partial class studentAccess : Form
    {
        public static string userLog, fctLog;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\userSubs.mdf;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\Enrollment.mdf;Integrated Security=True");
        public studentAccess()
        {
            InitializeComponent();


        }

        private void stdEnrollmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stdEnrollmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet3);

        }

        private void enrollmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.stdEnrollment' table. You can move, or remove it, as needed.
            this.stdEnrollmentTableAdapter.Fill(this.dataSet3.stdEnrollment);

        }

        private void stdEnrollmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\fctClass.mdf;Integrated Security=True");
            userLog = studentLogin.user;
            
            con.Open();
            con2.Open();
            con3.Open();
            SqlCommand cm3 = con3.CreateCommand();
            SqlCommand cmd = con.CreateCommand();
            int i=1;
            if (textBox1.Text != "")
            {
                SqlCommand cmd2 = new SqlCommand("Select SubjectCode, SubjectName, Professor, Schedule, Section, Slots from stdEnrollment where SubjectCode = @SubjectCode", con2);
                cmd2.Parameters.Add("@SubjectCode", SqlDbType.VarChar).Value = textBox1.Text;
                SqlDataReader da = cmd2.ExecuteReader();
                cmd.CommandType = CommandType.Text;
                cm3.CommandType = CommandType.Text; 

                while (da.Read())
                {
                    string a1, a2, a3, a4, a5;
                    a1 = (string)da.GetValue(0);
                    a2 = (string)da.GetValue(1);
                    a3 = (string)da.GetValue(2);
                    a4 = (string)da.GetValue(3);
                    a5 = (string)da.GetValue(4);
                    cmd.CommandText = "insert into userSubs values ('" + userLog + "','" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "')";
                    
                    cm3.CommandText = "insert into fctClass values ('" + a3 + "','" + a1 + "','" + a2 + "','" + a4 + "','" + a5 + "')";
                    DataTable dt = new DataTable();
                    string a6 = (string)da.GetValue(5);
                    i = Convert.ToInt32(a6);
                    
                }

                cmd.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                con.Close();
                con2.Close();

                if (i <= 0)
                {
                    dataGridViewTextBoxColumn3.Visible = false;
                }
                else
                {
                    i--;
                    string newI = Convert.ToString(i);
                    con2.Open();
                    SqlCommand cmd3 = con2.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "update stdEnrollment set Slots = '" + newI + "' where SubjectCode = '" + textBox1.Text + "'";
                    cmd3.ExecuteNonQuery();
                    con2.Close();
                }

                
                displaydata();
                MessageBox.Show("Subject added successfully.");

                
            }
            else MessageBox.Show("error");
            textBox1.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            stdProfile stdprof = new stdProfile();
            userLog = studentLogin.user;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brixr\source\repos\plmEnrollment\plmEnrollment\stdInfo.mdf;Integrated Security=True");
            con.Open();
            if (userLog != "")
            {
                SqlCommand cmd = new SqlCommand("Select studentID, lastName, firstName, middleName, address, contactNo, sex, YearLevel, Status from stdInfo where studentID = @studentID", con);
                cmd.Parameters.Add("@studentID", SqlDbType.VarChar).Value = userLog;
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    
                    stdprof.studentIDTextBox.Text = (string)da.GetValue(0);
                    stdprof.lastNameTextBox.Text = (string)da.GetValue(1);
                    stdprof.firstNameTextBox.Text = (string)da.GetValue(2);
                    stdprof.middleNameTextBox.Text = (string)da.GetValue(3);
                    stdprof.addressTextBox.Text = (string)da.GetValue(4);
                    stdprof.contactNoTextBox.Text = (string)da.GetValue(5);
                    stdprof.sexTextBox.Text = (string)da.GetValue(6);
                    stdprof.year_LevelTextBox.Text = (string)da.GetValue(7);
                    stdprof.statusTextBox.Text = (string)da.GetValue(8);

                }

                
                con.Close();
            }
            else MessageBox.Show("error");
            this.Hide();
            stdprof.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con2.Open();
            SqlCommand cmd = con2.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stdEnrollment where SubjectCode = '" + textBox1.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            stdEnrollmentDataGridView.DataSource = dt;
            con2.Close();

            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            con2.Open();
            SqlCommand cmd = con2.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stdEnrollment";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            stdEnrollmentDataGridView.DataSource = dt;
            con2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userSubs uss = new userSubs();
            this.Hide();
            uss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loginForm logf = new loginForm();
            this.Hide();
            logf.Show();
        }
    }
}
