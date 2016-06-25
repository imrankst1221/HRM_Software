using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_SUB
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }


        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMR_DBDataSet3.Employee_Attendance' table. You can move, or remove it, as needed.
            this.employee_AttendanceTableAdapter.Fill(this.hMR_DBDataSet3.Employee_Attendance);
            // TODO: This line of code loads data into the 'hMR_DBDataSet.Employee_info' table. You can move, or remove it, as needed.
            this.employee_infoTableAdapter.Fill(this.hMR_DBDataSet.Employee_info);

        }

        DateTime Employee_JoinDate, Employee_Validity;



        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                this.employee_AttendanceTableAdapter.searchData(this.hMR_DBDataSet3.Employee_Attendance, textSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchData(object sender, EventArgs e)
        {
            try
            {
                this.employee_AttendanceTableAdapter.searchData(this.hMR_DBDataSet3.Employee_Attendance, textSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxEditId_SelectedIndexChanged(object sender, EventArgs e)
        {
            String editUserId = comboBoxEditId.Text;
            try
            {
                Program.con.Close();
                Program.con.Open();

                string query = "SELECT Employee_Name, Employee_JoinDate,Employee_Validity,Employee_Status,Employee_Depertment from Employee_info WHERE Employee_ID='" + editUserId + "'";

                SqlCommand cmd = new SqlCommand(query, Program.con);
                int result = cmd.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxEditName.Text = String.Format("{0}", reader["Employee_Name"]);
                        Employee_JoinDate = DateTime.Parse(reader["Employee_JoinDate"].ToString());
                        Employee_Validity = DateTime.Parse(reader["Employee_Validity"].ToString());
                        textDepertment.Text = String.Format("{0}", reader["Employee_Depertment"]);
                        textStatus.Text = String.Format("{0}", reader["Employee_Status"]);

                    }
                }
                Program.con.Close();
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

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            DateTime currentDate = DateTime.Now.Date;
            TimeSpan difference = Employee_Validity.Subtract(currentDate);
            TimeSpan difference1 = Employee_Validity.Subtract(Employee_JoinDate);

            chart1.ChartAreas[0].AxisY.Maximum = 30;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            this.chart1.Series["Total Agreement"].Points.AddXY(0, Math.Ceiling(difference1.TotalDays / 365) % 100);
            this.chart1.Series["Current Agreement"].Points.AddXY(0, Math.Ceiling(difference.TotalDays / 365) % 100);

            float totalTime = 0;
            try
            {
                Program.con.Close();
                Program.con.Open();

                string query = "SELECT Start_Time,End_Time from Employee_Attendance WHERE Employee_ID ='" + editUserId + "'";
                SqlCommand cmd = new SqlCommand(query, Program.con);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    DateTime startTime = Convert.ToDateTime(result.GetString(0));
                    DateTime endTime = Convert.ToDateTime(result.GetString(1));

                    TimeSpan span = startTime - endTime;
                    totalTime += (float)span.TotalMilliseconds / 2592000;
                }
                Program.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Surver Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            chart2.ChartAreas[0].AxisY.Maximum = 30 * 6;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            this.chart2.Series["Total Work Hour"].Points.AddXY(0, 25 * 6);
            this.chart2.Series["Employee Work Hour"].Points.AddXY(0, (int)totalTime);
        }
    }
}
