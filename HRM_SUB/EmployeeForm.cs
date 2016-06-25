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
    public partial class EmployeeForm : Form
    {
        static string fileName = "";
        public string userId;
        
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMR_DBDataSet2.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hMR_DBDataSet2.Department);
            // TODO: This line of code loads data into the 'hMR_DBDataSet1.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.hMR_DBDataSet1.Status);
            // TODO: This line of code loads data into the 'hMR_DBDataSet.Employee_info' table. You can move, or remove it, as needed.
            this.employee_infoTableAdapter.Fill(this.hMR_DBDataSet.Employee_info);
            // TODO: This line of code loads data into the 'hMR_DBDataSet5.Department' table. You can move, or remove it, as needed.
            try
            {
                textBoxId.Text = getEmployeeID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //save button on click save new employee
        private void btnSave_newEmployee_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string id = textBoxId.Text;
            string address = textBoxAddress.Text;
            string mobile = textBoxMobile.Text;
            string email = textBoxEmail.Text;
            string status = comboBoxStatus.SelectedValue.ToString();
            string depertment = comboBoxDepertment.SelectedValue.ToString();
            string password = textBoxPassword.Text;
            //string joinDate = dateTimePickerJoinDate.Value.ToString("dd-MM-yyyy");
            DateTime joinDate = dateTimePickerJoinDate.Value.Date;
            DateTime validityDate = dateTimePickerValidity.Value.Date;

            if (name.Length < 1 || id.Length < 1 || address.Length < 1 || mobile.Length < 1 || email.Length < 1 || status.Length < 1 || depertment.Length < 1 || password.Length < 1)
            {
                MessageBox.Show("All information is required. Please enter all information.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (joinDate.Date >= validityDate.Date)
            {
                MessageBox.Show("Please select different Join Date and Validity Date.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (userIdTest(id))
            {
                MessageBox.Show("This ID already used. Please select another ID", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (new Regex(@"^([01]|\+88)?\d{10}").IsMatch(mobile) == false)
            {
                MessageBox.Show("Mobile number is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fileName.Length < 3)
            {
                MessageBox.Show("Please select user profile picture", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //add new employee in database
                try
                {
                    Program.con.Close();
                    Program.con.Open();

                    string query = "INSERT INTO Employee_info (Employee_ID, Employee_Name, Employee_Address, Employee_Mobile, " +
                        " Employee_Email, Employee_JoinDate, Employee_Validity, Employee_Status, Employee_Depertment, Employee_Password ) " +
                        "VALUES (@id, @name, @address, @mobile, @email, @joinDate, @Validity, @status,  @depertment, @password)";

                    SqlCommand cmd = new SqlCommand(query, Program.con);

                    cmd.Parameters.Add("@id", id);
                    cmd.Parameters.Add("@name", name);
                    cmd.Parameters.Add("@address", address);
                    cmd.Parameters.Add("@mobile", mobile);
                    cmd.Parameters.Add("@email", email);
                    cmd.Parameters.Add("@status", status);
                    cmd.Parameters.Add("@depertment", depertment);
                    cmd.Parameters.Add("@password", "123");
                    cmd.Parameters.Add("@joinDate", dateTimePickerJoinDate.Value.Date);
                    cmd.Parameters.Add("@Validity", dateTimePickerValidity.Value.Date);

                    cmd.ExecuteNonQuery();
                   // Program.con.Close();
                    MessageBox.Show("New Employee added. Setting user access permission.", "Employee Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //save employee photo

                    System.Drawing.Image image = System.Drawing.Image.FromFile(fileName);
                    image.Save("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + id + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    textBoxName.Text = "";
                    textBoxId.Text = "";
                    textBoxPassword.Text = "";
                    textBoxMobile.Text = "";
                    textBoxEmail.Text = "";
                    textBoxAddress.Text = "";                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //get new employee id 
        string getEmployeeID()
        {
            string appId = "";// "EMP_01";
            try
            {
                Program.con.Close();
                Program.con.Open();

                SqlCommand cmd = new SqlCommand("select max(Employee_ID) from Employee_info", Program.con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appId = reader.GetString(0);
                }
                reader.Close();
                //Program.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            if (appId.Length < 4)
            {
                appId = "EMP_00";
            }
            int id = int.Parse("" + appId[appId.Length - 2] + appId[appId.Length - 1]);
            id++;
            if (id <= 9)
            {
                return "EMP_0" + id;
            }
            return "EMP_" + id;
        }

        //user id id valid or not 
        Boolean userIdTest(string userid)
        {
            try
            {
                Program.con.Close();
                Program.con.Open();

                SqlCommand cmd = new SqlCommand("select Employee_ID from Employee_info where Employee_ID='" + userid + "'", Program.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Program.con.Close();
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


        //clear button on click clear all
        private void btnClear_newEmployee_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxId.Text = "";
            textBoxPassword.Text = "";
            textBoxMobile.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
        }


        //upload a employee photo 
        private void btnEmployee_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox5.Image = new Bitmap(dlg.FileName);

                    fileName = dlg.FileName;
                }
            }
        }

        //delete a employee info into databse
        private void buttonEditDelete_Click(object sender, EventArgs e)
        {
            String userid = comboBoxEditId.Text;
            try
            {
                Program.con.Close();
                Program.con.Open();

                string query = "DELETE from Employee_info WHERE Employee_ID='" + userid + "'";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(userid + " deleted successfully.", "Employee Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //Program.con.Close();
                pictureBox7.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
                textBoxEditName.Text = "";
                textBoxEditAddress.Text = "";
                textBoxEditMobile.Text = "";
                textBoxEditEmail.Text = "";
                textBoxEditPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditSave_Click(object sender, EventArgs e)
        {
            string name = textBoxEditName.Text;
            string id = comboBoxEditId.Text;
            string address = textBoxEditAddress.Text;
            string mobile = textBoxEditMobile.Text;
            string email = textBoxEditEmail.Text;
            string status = comboBoxEditStatus.SelectedValue.ToString();
            string depertment = comboBoxEditDep.SelectedValue.ToString();
            string password = textBoxEditPass.Text;
            //string joinDate = dateTimePickerJoinDate.Value.ToString("dd-MM-yyyy");
            DateTime joinDate = dateTimePickerEditJoin.Value.Date;
            DateTime validityDate = dateTimePickerEditValide.Value.Date;

            if (name.Length < 1 || id.Length < 1 || address.Length < 1 || mobile.Length < 1 || email.Length < 1 || status.Length < 1 || depertment.Length < 1 || password.Length < 1)
            {
                MessageBox.Show("All information is required. Please enter all information.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (joinDate.Date >= validityDate.Date)
            {
                MessageBox.Show("Please select different Join Date and Validity Date.", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (new Regex(@"^([01]|\+88)?\d{10}").IsMatch(mobile) == false)
            {
                MessageBox.Show("Mobile number is not valide", "All information is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //add new employee in database
                try
                {
                    Program.con.Close();
                    Program.con.Open();

                    string query = "UPDATE Employee_info SET Employee_ID = @id, Employee_Name = @name, Employee_Address = @address, Employee_Mobile = @mobile, " +
                        " Employee_Email = @email , Employee_JoinDate =  @joinDate, Employee_Validity = @Validity, Employee_Status = @status, " +
                        " Employee_Depertment = @depertment , Employee_Password = @password WHERE Employee_ID='" + editUserId + "'";

                    SqlCommand cmd = new SqlCommand(query, Program.con);

                    cmd.Parameters.Add("@id", id);
                    cmd.Parameters.Add("@name", name);
                    cmd.Parameters.Add("@address", address);
                    cmd.Parameters.Add("@mobile", mobile);
                    cmd.Parameters.Add("@email", email);
                    cmd.Parameters.Add("@status", status);
                    cmd.Parameters.Add("@depertment", depertment);
                    cmd.Parameters.Add("@password", "123");
                    cmd.Parameters.Add("@joinDate", dateTimePickerJoinDate.Value.Date);
                    cmd.Parameters.Add("@Validity", dateTimePickerValidity.Value.Date);

                    cmd.ExecuteNonQuery();
                    //Program.con.Close();
                    //System.IO.File.Copy(fileName, "E:\\Desktop\\HRM_SUB\\img\\User Photo\\" + id + ".png");
                    MessageBox.Show("Updated Employee info.", "Employee Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    System.Drawing.Image image = System.Drawing.Image.FromFile(fileName);
                    image.Save("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + id + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    textBoxName.Text = "";
                    textBoxId.Text = "";
                    textBoxPassword.Text = "";
                    textBoxMobile.Text = "";
                    textBoxEmail.Text = "";
                    textBoxAddress.Text = "";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox7.Image = new Bitmap(dlg.FileName);

                    fileName = dlg.FileName;
                }
            }
        }

        String editUserId = "";
        //get all employee info from databse using id 
        private void editOnChange(object sender, EventArgs e)
        {
            editUserId = comboBoxEditId.Text;
            try
            {
                Program.con.Close();
                Program.con.Open();

                string query = "SELECT Employee_ID, Employee_Name, Employee_Address, Employee_Mobile, " +
                    " Employee_Email, Employee_JoinDate, Employee_Validity, Employee_Status, Employee_Depertment, Employee_Password  " +
                    "from Employee_info WHERE Employee_ID='" + editUserId + "'";

                SqlCommand cmd = new SqlCommand(query, Program.con);
                int result = cmd.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxEditName.Text = String.Format("{0}", reader["Employee_Name"]);
                        textBoxEditAddress.Text = String.Format("{0}", reader["Employee_Address"]);
                        textBoxEditMobile.Text = String.Format("{0}", reader["Employee_Mobile"]);
                        textBoxEditEmail.Text = String.Format("{0}", reader["Employee_Email"]);
                        textBoxEditPass.Text = String.Format("{0}", reader["Employee_Password"]);
                        comboBoxEditStatus.SelectedIndex = comboBoxEditStatus.FindStringExact(String.Format("{0}", reader["Employee_Status"]));
                        comboBoxEditDep.SelectedIndex = comboBoxEditDep.FindStringExact(String.Format("{0}", reader["Employee_Depertment"]));
                        dateTimePickerEditJoin.Value = DateTime.Parse(reader["Employee_JoinDate"].ToString());
                        dateTimePickerEditValide.Value = DateTime.Parse(reader["Employee_Validity"].ToString());
                    }
                }
                //Program.con.Close();
                //System.IO.File.Copy(fileName, "E:\\Desktop\\HRM_SUB\\img\\User Photo\\" + id+".png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                pictureBox7.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\" + editUserId + ".png");
            }
            catch (Exception ex)
            {
                pictureBox7.Image = new Bitmap("E:\\Desktop\\HRM_SUB\\HRM_SUB\\img\\User Photo\\default.png");
            }

        }

        //clear all value of edit/delete from
        private void buttonEditClear_Click(object sender, EventArgs e)
        {
            textBoxEditName.Text = "";
            textBoxEditAddress.Text = "";
            textBoxEditMobile.Text = "";
            textBoxEditEmail.Text = "";
            textBoxEditPass.Text = "";
        }

        private void searchEmployeeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employee_infoTableAdapter.searchEmployee(this.hMR_DBDataSet.Employee_info, textSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                this.employee_infoTableAdapter.searchData1(this.hMR_DBDataSet.Employee_info, textSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employee_infoTableAdapter.FillBy(this.hMR_DBDataSet.Employee_info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void searchOnChange(object sender, EventArgs e)
        {
            try
            {
                this.employee_infoTableAdapter.searchData1(this.hMR_DBDataSet.Employee_info, textSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
