using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;

namespace HRM_SUB
{
    public partial class UserLogIn : Form
    {
        //for clock value
        Timer time = new Timer();
        Boolean show_date = false;

        public UserLogIn()
        {
            InitializeComponent();
            btnLogin.Focus();
            txtPassword.PasswordChar='*';
        }

        //save id password formate
        public class CustomerData
        {
            public string id;
            public string pass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user_validity())
            {
               
                try
                {
                    //save user id pass
                    if (checkBox_save_password.Checked == true)
                    {
                        CustomerData customer = new CustomerData();
                        customer.id = txtUserId.Text;
                        customer.pass = txtPassword.Text;
                        // Create and XmlSerializer to serialize the data to a file
                        XmlSerializer xs = new XmlSerializer(typeof(CustomerData));
                        using (FileStream fs = new FileStream("login.xml", FileMode.Create))
                        {
                            xs.Serialize(fs, customer);
                        }
                    }
                    else 
                    {                        
                        CustomerData customer = new CustomerData();
                        customer.id = "";
                        customer.pass = "";
                        // Create and XmlSerializer to serialize the data to a file
                        XmlSerializer xs = new XmlSerializer(typeof(CustomerData));
                        using (FileStream fs = new FileStream("login.xml", FileMode.Create))
                        {
                            xs.Serialize(fs, customer);
                        }
                    }
                    Program.userId = txtUserId.Text;                                                                                        
                    //open home page 
                    Program.isLoggedOn = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The username or password you entered do not match any accounts on record", "Username or Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //for login goto SQL database
        Boolean user_validity() {
            try
            {
                //connect with database
                //SqlConnection con = new SqlConnection();  
                //con.ConnectionString = "Data Source=Emi\\IMRANKST1221;Initial Catalog=HMR_DB;User Id=sa;Password=1221";  
                //con.Open();  
                Program.connectDB();

                string userid = txtUserId.Text;
                string password = txtPassword.Text;  

                SqlCommand cmd = new SqlCommand("select Employee_ID,Employee_Password from Employee_info where Employee_ID='" + userid + "'and Employee_Password='" +password+ "'", Program.con);  
                SqlDataAdapter da = new SqlDataAdapter(cmd);  
                DataTable dt = new DataTable();  
                da.Fill(dt);
               // Program.con.Close();   
                if (dt.Rows.Count > 0)  
                {  
                    return true;
                }  
                else  
                {  
                    return false;
                }  
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            return false;
        }



        //show clock method 
        private void UserLogIn_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();
            //show user id and pass if save 
            try
            {
                CustomerData customer;
                XmlSerializer xs = new XmlSerializer(typeof(CustomerData));
                using (FileStream fs = new FileStream("login.xml", FileMode.Open))
                {
                    customer = xs.Deserialize(fs) as CustomerData;
                }
                if (customer != null)
                {
                    txtUserId.Text = customer.id;
                    txtPassword.Text = customer.pass;
                    checkBox_save_password.Checked = true;
                }                
               
            }
            catch (Exception ex) 
            {
               
            }            
            time.Interval = 1000;  //in milliseconds

            time.Tick += new EventHandler(this.t_Tick);

            time.Start();  //this will use t_Tick() method
        }
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";
            int am_pm= 0;
            //padding leading zero
            if (hh < 10){
                time += "0" + hh;
            }
            else
            {
                if (hh > 12) 
                {
                    am_pm = 1;
                    hh -=12;
                }
                if (hh < 10)
                {
                    time += "0";
                }
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            if (am_pm == 0) 
            {
                time += " AM ";
            }else
            {
                time += " PM ";
            }
            //update label
            clock.Text = time;
            if (!show_date)
            {
                date.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
                show_date = true;
            }
        }//end of show clock method 


        //close button click 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Program.isLoggedOn = false;
            Close();
        }

        //press enter goto next 
        private void textBox_UserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) txtPassword.Focus();
        }

        private void password_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) btnLogin.Focus();

        }
    }
}
