using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_SUB
{
    static class Program
    {
        static public string userId = "";
        public static Boolean isLoggedOn = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

                if (!validateUser()) return;

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        public static SqlConnection con = new SqlConnection();
        public static void connectDB()
        {
            try {
                con.ConnectionString = "Data Source=VIRUS\\IMRANKST1221;Initial Catalog=HMR_DB; Trusted_Connection=true";
                con.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("" + ex.Message.ToString(), "Main Database Problem");
            }            
        }

        private static Boolean validateUser()
        {
            try
            {
                UserLogIn ul = new UserLogIn();
                ul.ShowDialog();

                if (isLoggedOn)
                {
                    System.Windows.Forms.Application.Run(new MainForm());
                    return true;
                }
                else {

                    return false;
                }
                
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
