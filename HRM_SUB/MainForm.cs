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
using System.Text.RegularExpressions;

namespace HRM_SUB
{
    public partial class MainForm : Form
    {
        //for clock veriable 
        Timer time = new Timer();
        public class UserInfo
        {
            public string id;
            public string name;
            public string address;
            public string email;
            public string mobile;
            public string depertment;
            public string status;
            public DateTime joinDate;
            public DateTime valideDate;
            public string pass;
        }
        public UserInfo currentUser = new UserInfo();
        //save image verible
        static string fileName = "";
        public string userId;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tabControlEmployee.SelectedIndex = 1; // = 1;
        }


        private void menuItem_exit(object sender, EventArgs e)
        {
            Program.isLoggedOn = false;
            Close();
        }


        // show clock method 
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMR_DBDataSet.Employee_info' table. You can move, or remove it, as needed.
            loadUserProfile(Program.userId);
            txt_user_menu.Text = currentUser.name;                       
            time.Interval = 1000;  //in milliseconds

            time.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            time.Start();
            try
            {
                pictureBoxProfile.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + currentUser.id + ".png");
            }
            catch (Exception ex)
            {
                pictureBoxProfile.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
            }
            splitContainer1.Dock = DockStyle.Fill;
            //tabControlEmployee.Dock = DockStyle.Fill;
            //panelProfile.Parent = splitContainer1.Panel2;
        }

        //load user profile from database
        public void loadUserProfile(string UserId)
        {
            try
            {
                Program.con.Close();
                Program.con.Open();

                SqlCommand cmd = new SqlCommand("select Employee_ID, Employee_Name, Employee_Address, Employee_Mobile, " +
                        " Employee_Email, Employee_JoinDate, Employee_Validity, Employee_Status, Employee_Depertment, " +
                        "Employee_Password from Employee_info where Employee_ID='" + UserId + "'", Program.con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    currentUser.id = reader.GetString(0);
                    currentUser.name = reader.GetString(1);
                    currentUser.address = reader.GetString(2);
                    currentUser.mobile = reader.GetString(3);
                    currentUser.email = reader.GetString(4);
                    currentUser.joinDate = reader.GetDateTime(5);
                    currentUser.valideDate = reader.GetDateTime(6);
                    currentUser.status = reader.GetString(7);
                    currentUser.depertment = reader.GetString(8);
                    currentUser.pass = reader.GetString(9);
                }
                reader.Close();
                Program.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error I", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";
            int am_pm = 0;
            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                if (hh > 12)
                {
                    am_pm = 1;
                    hh -= 12;
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
            }
            else
            {
                time += " PM ";
            }
            //update label
            clock.Text = time;
        }//end of show clock method 

      

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(txt_user_menu, 0, 0);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //panel click color change and action

        EmployeeForm employeeForm;
        EmailAndChat emailAndChat;
        Application notificationForm;
        Report employeeReprt;
        //notification
        private void panel_notificaton_MouseDown(object sender, MouseEventArgs e)
        {
            panelnotification.BackColor = Color.FromArgb(128, 203, 196);
            hideAllTab();

            if (notificationForm == null)
            {
                notificationForm = new Application();
                notificationForm.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(notificationForm);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                notificationForm.Show();
            }
            else
            {
                notificationForm.Activate();
            }
            
        }
        private void panel_notificaton_MouseUp(object sender, MouseEventArgs e)
        {
            panelnotification.BackColor = Color.FromArgb(0, 96, 100);
        }

        //email and chat panel click 
        private void panelEmalAndChatDown(object sender, MouseEventArgs e)
        {
            panelEmailAndChat.BackColor = Color.FromArgb(110, 116, 10);
            hideAllTab();
            if (emailAndChat == null)
            {
                emailAndChat = new EmailAndChat();
                emailAndChat.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(emailAndChat);
                //notification.FormClosed += notification_FormClosed;
                emailAndChat.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }
        private void panelEmalAndChatUp(object sender, MouseEventArgs e)
        {
            panelEmailAndChat.BackColor = Color.FromArgb(10, 116, 10);
        }


        //employee pannel click 
        private void panel_employee_MouseDown_1(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(179, 157, 219);
            hideAllTab();
            //add employee panel on it 
            if (employeeForm == null)
            {
                employeeForm = new EmployeeForm();
                employeeForm.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(employeeForm);
               // employeeForm.FormClosed += employeeForm_FormClosed;
                employeeForm.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }
        private void panel_employee_MouseUp_1(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(26, 35, 126);
        }


        //report panel click 
        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            hideAllTab();
            panel_report.BackColor = Color.FromArgb(206, 147, 216);

            if (employeeReprt == null)
            {
                employeeReprt = new Report();
                employeeReprt.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(employeeReprt);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                employeeReprt.Show();
            }
            else
            {
                employeeReprt.Activate();
            }
        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
            panel_report.BackColor = Color.FromArgb(156, 39, 176);
        }


        //exit pannel click 
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            panel_exit.BackColor = Color.FromArgb(183, 28, 28);
        }


        //sign out on log out press 
        private void signOutToolItem_Click(object sender, EventArgs e)
        {
            Program.isLoggedOn = false;
            Close();
        }
        //hide all tab
        public void hideAllTab()
        {
            if (employeeForm != null) 
            {
                employeeForm.Close();
                employeeForm = null;
            }
            if (emailAndChat != null)
            {
                emailAndChat.Close();
                emailAndChat = null;
            }
            if (notificationForm != null)
            {
                notificationForm.Close();
                notificationForm = null;
            }
            if (employeeReprt != null)
            {
                employeeReprt.Close();
                employeeReprt = null;
            }
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{

        //    var exit = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    e.Cancel = (exit == DialogResult.No);
        //    //base.OnFormClosing(e);
        //}

        private void Log_out(object sender, EventArgs e)
        {
            Program.isLoggedOn = false;
            UserLogIn userlog = new UserLogIn();
            Close();
            userlog.Show();
        }

        private void sendApplicationDown(object sender, MouseEventArgs e)
        {
            panelnotification.BackColor = Color.FromArgb(128, 203, 196);
            hideAllTab();

            if (notificationForm == null)
            {
                notificationForm = new Application();
                notificationForm.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(notificationForm);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                notificationForm.Show();
            }
            else
            {
                notificationForm.Activate();
            }
        }

        private void sendApplicationUp(object sender, MouseEventArgs e)
        {
            panelnotification.BackColor = Color.FromArgb(0, 96, 100);
        }

        private void emailDown(object sender, MouseEventArgs e)
        {
            panelEmailAndChat.BackColor = Color.FromArgb(110, 116, 10);
            hideAllTab();
            if (emailAndChat == null)
            {
                emailAndChat = new EmailAndChat();
                emailAndChat.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(emailAndChat);
                //notification.FormClosed += notification_FormClosed;
                emailAndChat.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }


        private void emailUp(object sender, MouseEventArgs e)
        {
            panelEmailAndChat.BackColor = Color.FromArgb(10, 116, 10);
        }

        private void chatUp(object sender, MouseEventArgs e)
        {
            panelEmailAndChat.BackColor = Color.FromArgb(10, 116, 10);
        }

        private void chatDown(object sender, MouseEventArgs e)
        {
            panelEmailAndChat.BackColor = Color.FromArgb(110, 116, 10);
            hideAllTab();
            if (emailAndChat == null)
            {
                emailAndChat = new EmailAndChat();
                emailAndChat.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(emailAndChat);
                //notification.FormClosed += notification_FormClosed;
                emailAndChat.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }

        private void viewEmployee(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(179, 157, 219);
            hideAllTab();
            //add employee panel on it 
            if (employeeForm == null)
            {
                employeeForm = new EmployeeForm();
                employeeForm.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(employeeForm);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                employeeForm.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }

        private void addEmployee(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(179, 157, 219);
            hideAllTab();
            //add employee panel on it 
            if (employeeForm == null)
            {
                employeeForm = new EmployeeForm();
                employeeForm.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(employeeForm);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                employeeForm.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }

        private void editEmployee(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(179, 157, 219);
            hideAllTab();
            //add employee panel on it 
            if (employeeForm == null)
            {
                employeeForm = new EmployeeForm();
                employeeForm.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(employeeForm);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                employeeForm.Show();
            }
            else
            {
                employeeForm.Activate();
            }
        }

        private void viewEmployeeUp(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(26, 35, 126);
        }

        private void addEmployeeUp(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(26, 35, 126);
        }

        private void editToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(26, 35, 126);
        }

        private void viewReportToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            hideAllTab();
            panel_report.BackColor = Color.FromArgb(206, 147, 216);

            if (employeeReprt == null)
            {
                employeeReprt = new Report();
                employeeReprt.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(employeeReprt);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                employeeReprt.Show();
            }
            else
            {
                employeeReprt.Activate();
            }

        }

        private void attendenceToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            hideAllTab();
            panel_report.BackColor = Color.FromArgb(206, 147, 216);

            if (employeeReprt == null)
            {
                employeeReprt = new Report();
                employeeReprt.MdiParent = this;
                this.splitContainer1.Panel2.Controls.Add(employeeReprt);
                // employeeForm.FormClosed += employeeForm_FormClosed;
                employeeReprt.Show();
            }
            else
            {
                employeeReprt.Activate();
            }

        }

        private void viewReportToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            panel_report.BackColor = Color.FromArgb(156, 39, 176);
        }

        private void attendenceToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            panel_report.BackColor = Color.FromArgb(156, 39, 176);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.isLoggedOn = false;
            UserLogIn userlog = new UserLogIn();
            Close();
            userlog.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailAndChat emp = new EmailAndChat();
            emp.Show();
        }
    }
}
