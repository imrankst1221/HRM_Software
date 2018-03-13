using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_SUB
{
    public partial class Application : Form
    {
        public class UserInfo
        {
            public string id;
            public string name;
            public string address;
            public string email;
            public string mobile;            
        }
        public UserInfo currentUser = new UserInfo();
        /*
         * Status A = Approve
         *        R = Reject
         *        M = Modifi
         *        N = New
         */
        public Application()
        {
            InitializeComponent();
            loadUserProfile(Program.userId);
            textBox1.Text = DateTime.Now.Date.ToString();
        }


        private void Notification_Load(object sender, EventArgs e)
        {
            if (currentUser.id.CompareTo("Admin") != 0)
            {
                Boolean dataFound = false;
                try
                {
                    Program.con.Close();
                    Program.con.Open();

                    SqlCommand cmd = new SqlCommand("select appno, Employee_ID, Employee_Name, from_date, to_date, leave_type, location, contact, " +
                            " app_date, status from Employee_application where Employee_ID = '" + currentUser.id+"' ", Program.con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    //MessageBox.Show(""+reader,"");
                    while (reader.Read())
                    {
                        dataFound  = true;
                        labelAppId.Text = reader.GetString(0);
                        labelId.Text = reader.GetString(1);
                        labelEmployeeName2.Text = reader.GetString(2);
                        labelFromdate.Text = "" + reader.GetDateTime(3).Date.ToString();
                        labelToDate.Text = "" + reader.GetDateTime(4).Date.ToString();
                        labelType.Text = reader.GetString(5);
                        labelLocation.Text = reader.GetString(6);
                        labelContact.Text = reader.GetString(7);
                        labelApplicationDate.Text = "" + reader.GetDateTime(8).Date.ToString();
                        labelStatus.Text = "" + reader.GetDateTime(9).Date.ToString();
                        labelApplicationFor.Text = "Your Leave Application ID approved";
                    }
                    reader.Close();
                    //Program.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(!dataFound)
                {
                    tabControl1.TabPages.Remove(viewNotification);
                }
            }
            else
            {
                Boolean dataFound = false;
                try
                {
                    Program.con.Close();
                    Program.con.Open();

                    SqlCommand cmd = new SqlCommand("select appno, Employee_ID, Employee_Name, from_date, to_date, leave_type, location, contact, " +
                            " app_date from Employee_application where status='new'", Program.con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    //MessageBox.Show(""+reader,"");
                    while (reader.Read())
                    {
                        dataFound = true;
                        labelAppId.Text = reader.GetString(0);
                        labelId.Text = reader.GetString(1);                        
                        labelEmployeeName2.Text = reader.GetString(2);
                        labelFromdate.Text = ""+reader.GetDateTime(3).Date.ToString();
                        labelToDate.Text = ""+reader.GetDateTime(4).Date.ToString();
                        labelType.Text = reader.GetString(5);
                        labelLocation.Text = reader.GetString(6);
                        labelContact.Text = reader.GetString(7);
                        labelApplicationDate.Text = ""+reader.GetDateTime(8).Date.ToString();                       
                    }
                    reader.Close();
                   // Program.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(!dataFound)
                {
                    tabControl1.TabPages.Remove(viewNotification);
                }
                
                try
                {
                    pictureBoxUser.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + labelId.Text + ".png");
                }
                catch (Exception ex)
                {
                    pictureBoxUser.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
                }

            }

            try
            {
                textAppNo.Text = getApplicationID();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Surver Connection Error I", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String applicationNo = textAppNo.Text;
            String leaveLocation = textLeaveLoc.Text;
            String contact = textContact.Text;
            String leaveType = comboBox1.Text;
            DateTime fromDate = dateTimeFrom.Value.Date;
            DateTime toDate = dateTimeTo.Value.Date;            

            if (applicationNo.Length < 1 || leaveLocation.Length < 1 || contact.Length < 1 || leaveType.Length < 1 )
            {
                MessageBox.Show("All information is required. Please enter all information.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (fromDate.Date >= toDate.Date)
            {
                MessageBox.Show("Please select different Join Date and Validity Date.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Program.con.Close();
                    Program.con.Open();

                    string query = "INSERT INTO Employee_application (appno,app_date,Employee_ID,Employee_name,from_date,to_date,leave_type," +
                        "location, contact, status)" +
                                    "VALUES (@appno, @app_date, @Employee_ID, @Employee_name, @from_date, @to_date, @leave_type,@location,@contact,@status)";

                    SqlCommand cmd = new SqlCommand(query, Program.con);
                    cmd.Parameters.Add("@appno", applicationNo);
                    cmd.Parameters.Add("@app_date", DateTime.Now.Date);
                    cmd.Parameters.Add("@Employee_ID", currentUser.id);
                    cmd.Parameters.Add("@Employee_name", currentUser.name);
                    cmd.Parameters.Add("@from_date", fromDate);
                    cmd.Parameters.Add("@to_date", toDate);
                    cmd.Parameters.Add("@leave_type", leaveType);
                    cmd.Parameters.Add("@location", leaveLocation);
                    cmd.Parameters.Add("@contact", contact);
                    cmd.Parameters.Add("@status", "new");
                    cmd.ExecuteNonQuery();

                    //Program.con.Close();
                    MessageBox.Show("All Notification send Successfully.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    try
                    {
                        textAppNo.Text = getApplicationID();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textLeaveLoc.Clear();
                    textContact.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Surver Connection Error II", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //get new employee id 
        string getApplicationID()
        {
            string appId = "";// "ApplicationId_01";
            try
            {
                Program.con.Close();
                Program.con.Open();

                SqlCommand cmd = new SqlCommand("select max(appno) from Employee_application", Program.con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appId= reader.GetString(0);
                }
                reader.Close();                
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (appId.Length<5) {
                appId = "ApplicationId_00";
            }
            int id = int.Parse(""+appId[appId.Length - 2] + appId[appId.Length - 1]);
            id++;
            if (id <= 9) {
                return "ApplicationId_0" + id;
            }
            return "ApplicationId_" + id;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textAppNo.Clear();
            textLeaveLoc.Clear();
            textContact.Clear();
            
        }

       public void loadUserProfile(string UserId)
        {
            try
            {
                Program.con.Close();
                Program.con.Open();

                SqlCommand cmd = new SqlCommand("select Employee_ID, Employee_Name, Employee_Address, Employee_Mobile, " +
                        " Employee_Email from Employee_info where Employee_ID='" + UserId + "'", Program.con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                        currentUser.id = reader.GetString(0);
                        currentUser.name = reader.GetString(1);
                        currentUser.address = reader.GetString(2);
                        currentUser.mobile = reader.GetString(3);
                        currentUser.email = reader.GetString(4);       
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Close();
                Program.con.Open();

                SqlCommand cmd = new SqlCommand("update Employee_application set status = 'Approve' where appno = '"+labelAppId.Text+"' ", Program.con);
                cmd.ExecuteNonQuery();
               // Program.con.Close();

                MessageBox.Show("Application no " + labelAppId.Text+" is approved.", "Successfully Approved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tabControl1.TabPages.Remove(viewNotification);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Close();
                Program.con.Open();

                SqlCommand cmd = new SqlCommand("update Employee_application set status = 'Reject' where appno = '" + labelAppId.Text + "' ", Program.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Application no " + labelAppId.Text + " is Rejected.", "Successfully Rejected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tabControl1.TabPages.Remove(viewNotification);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
