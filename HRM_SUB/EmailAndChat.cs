using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Web;
using System.Net.Mail;
using System.IO;

namespace HRM_SUB
{
    public partial class EmailAndChat : Form
    {
        //send local notification
        Socket sck;
        EndPoint epLocal, epRemote;
        String smtp, attachment="";
        public class UserInfo
        {
            public string id;
            public string name;
            public string port;
            public string email;
            public string mobile;            
        }
        public UserInfo currentUser = new UserInfo();
        public UserInfo secendUser = new UserInfo();

        public EmailAndChat()
        {
            InitializeComponent();
            //send notification
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            loadUserProfile(Program.userId,0);

            //set pc ip adderss for chat
            groupBox1.Text = currentUser.name;
            textLocalIp.Text = GetLocalIp();
            textFriendIp.Text = GetLocalIp();
            textLocalPort.Text = currentUser.port;
            textFriendPort.Text = "81";

            //set value for email
            textCurrentUserName.Text = currentUser.name;
            textCurrentUserEmail.Text = currentUser.email;
            textBoxPassword.PasswordChar = '*';

            smtp = "";
            for (int i = currentUser.email.Length - 1; i > 0; i--)
            {
                if (currentUser.email[i] == '@')
                {
                    for (int j = i + 1; j < currentUser.email.Length; j++)
                    {
                        if (currentUser.email[j] == '.')
                        {
                            break;
                        }
                        smtp += currentUser.email[j];
                    }
                    break;
                }
            }
        }

        //start notification 
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {   
                //IPAddress.Parse(ip) if use other computer then set ip in there
                epLocal  = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);
                
                //connect another ip
                epRemote  = new IPEndPoint(IPAddress.Parse(textFriendIp.Text), Convert.ToInt32(textFriendPort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                buttonSend.Enabled = true;
                textMessage.Focus();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }

        //get pc ip address 
        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            { 
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                { 
                    byte[] recivedData = new byte [1500];
                    recivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recivedMessage = eEncoding.GetString(recivedData);
                    listMessage.Items.Add(secendUser.name+": "+recivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                sck.Send(msg);
                listMessage.Items.Add("You: " + textMessage.Text);
                textMessage.Clear();

            }catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void EmailAndChat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMR_DBDataSet.Employee_info' table. You can move, or remove it, as needed.
            this.employee_infoTableAdapter.Fill(this.hMR_DBDataSet.Employee_info);
            // TODO: This line of code loads data into the 'hMR_DBDataSet.Employee_info' table. You can move, or remove it, as needed.
            this.employee_infoTableAdapter.Fill(this.hMR_DBDataSet.Employee_info);
            // TODO: This line of code loads data into the 'hMR_DBDataSet3.Employee_info' table. You can move, or remove it, as needed.
            try
            {
                pictureBox2.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + currentUser.id + ".png");
                pictureCurrentUser.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + currentUser.id + ".png");
            }
            catch (Exception ex)
            {
                pictureBox2.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
                pictureCurrentUser.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
            }
        }

        public void loadUserProfile(string UserId,int x)
        {
            try
            {
                Program.con.Close();
                Program.con.Open();
                
                SqlCommand cmd = new SqlCommand("select Employee_ID, Employee_Name, Employee_port, Employee_Mobile, " +
                        " Employee_Email from Employee_info where Employee_ID='" + UserId + "'", Program.con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (x == 0)
                    {
                        currentUser.id = reader.GetString(0);
                        currentUser.name = reader.GetString(1);
                        currentUser.port = reader.GetString(2);
                        currentUser.mobile = reader.GetString(3);
                        currentUser.email = reader.GetString(4);
                    }
                    else
                    {
                        secendUser.id = reader.GetString(0);
                        secendUser.name = reader.GetString(1);
                        secendUser.port = reader.GetString(2);
                        secendUser.mobile = reader.GetString(3);
                        secendUser.email = reader.GetString(4);
                    }
                }
                reader.Close();
                //Program.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        //get select user
        private void userInfoGet(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb != null)
            {
                loadUserProfile(lb.SelectedValue.ToString(),1);
                groupBox2.Text = secendUser.name;
                textFriendPort.Text = secendUser.port;
                try
                {
                    pictureBox1.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + secendUser.id + ".png");
                }
                catch (Exception ex)
                {
                    pictureBox1.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
                }
            }
        }

        private void editOnChange(object sender, EventArgs e)
        {
            loadUserProfile(comboBoxEditId.Text, 1);
            textBoxUserName2.Text = secendUser.name;
            textBoxUserEmail2.Text = secendUser.email;
            try
            {
                pictureSecendUser.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + secendUser.id + ".png");
            }
            catch (Exception ex)
            {
                pictureSecendUser.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
            }
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {

            string result = "Message Sent Successfully..!!";
            string senderID = textCurrentUserEmail.Text;// use sender’s email id here..
            string senderPassword = textBoxPassword.Text.ToString() ; // sender password here…
            
            if (textBoxUserEmail2.Text.Length < 1)
            {
                MessageBox.Show("Please select user ID", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxSubject.Text.Length < 1)
            {
                MessageBox.Show("Subject is empty.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (richTextBoxBody.Text.Length < 1)
            {
                MessageBox.Show("Message is empty.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                        SmtpClient smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com", // smtp server address here…
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                            Timeout = 30000,
                        };
                    MailMessage message = new MailMessage(textCurrentUserEmail.Text, textBoxUserEmail2.Text, textBoxSubject.Text, richTextBoxBody.Text);
                    smtp.Send(message);
                    textBoxSubject.Text = "";
                    richTextBoxBody.Text = "";
                    MessageBox.Show("Email send Successfully to " + secendUser.email, "Email Successfully Send", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Email send failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open File";
                //dlg.Filter = "pdf file (*.pdf)|*.pdf|png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    attachment = dlg.FileName;
                    labelFileName.Text = Path.GetFileName(dlg.FileName);
                }
            }
        }
    }
}
