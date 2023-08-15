using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;

namespace REDNA_BANK
{
    public partial class RednaLogin : Form
    {
        public RednaLogin()
        {
            Thread t = new Thread(new ThreadStart(startfrom));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

        }
        public void startfrom()
        {
            Application.Run(new Loading());
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void RednaLogin_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;Persist Security Info=True;User ID=lakshan;Password=Redna@12");
            }
            catch (SqlException)
            {
                databaseerroor.Show("Database Connection Errors", "Error");
            }
            catch (Exception)
            {
                exceptionmessageform.Show("Please Check Again", "Error");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (r_admin.Checked == true)
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Admin where AdminId = '" + txt_ID.Text + "' AND AdminPassword = '" + txt_password.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 1)
                {
                    //TextFile
                    using (StreamWriter streamWriter = new StreamWriter("Userid.txt"))
                    {
                        streamWriter.WriteLine(txt_ID.Text);
                    }
                    //TextFile

                    // Email Start
                    Database db = new Database();
                    String to_email = db.dataScalar("Select AdEmail from Admin where AdminId = '" + txt_ID.Text + "'");
                    emailsender email = new emailsender();
                    email.to(to_email);
                    email.subject("Successful login");
                    email.msg("Dear User,\n\nYou have successfully accessed your Redna Bank account.\nIf it was not you, Please contact the bank immediately.\n\nThanks & Best Regards,\nRedna Bank.");
                    email.send();
                    // Email End*/

                    con.Open();
                    cmd = new SqlCommand("Insert into AdminLogs (AdID,ALogType, ALogDateTime) values ('" + txt_ID.Text + "','Login','"+DateTime.Now+"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.Dispose();

                    Admindashboard obj = new Admindashboard();
                    this.Hide();
                    obj.Show();
                }
                else
                {
                    incorrect.Show("Check your UserID and Password or Login Type Again", "Error");
                }

            }

            else if (r_staff.Checked == true)
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Staff where StaffID = '" + txt_ID.Text + "' AND StaffPassword = '" + txt_password.Text + "' ", con);
                DataTable dat = new DataTable();
                da.Fill(dat);
                con.Close();
                if (dat.Rows.Count == 1)
                {
                    /*StaffDashboard obj = new StaffDashboard();
                    this.Hide();
                    obj.Show();*/

                    //TextFile
                    using (StreamWriter streamWriter = new StreamWriter("Userid.txt"))
                    {
                        streamWriter.WriteLine(txt_ID.Text);
                    }
                    //TextFile

                    // Email Start
                    Database db = new Database();
                    String to_email = db.dataScalar("Select StaffEmail from Staff where StaffID = '" + txt_ID.Text + "'");
                    emailsender email = new emailsender();
                    email.to(to_email);
                    email.subject("Successful login");
                    email.msg("Dear User,\n\nYou have successfully accessed your Redna Bank account.\nIf it was not you, Please contact the bank immediately.\n\nThanks & Best Regards,\nRedna Bank.");
                    email.send();
                    // Email End*/

                    con.Open();
                    cmd = new SqlCommand("Insert into StaffLogs (StID,SLogType, SLogDateTime) values ('" + txt_ID.Text + "','Login','" + DateTime.Now + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.Dispose();

                    StaffDashboard obj = new StaffDashboard();
                    this.Hide();
                    obj.Show();
                }
                else
                {
                    incorrect.Show("Check your UserID and Password or Login Type Again", "Error");
                }
            }
            else if (r_admin.Checked == false || r_staff.Checked == false)
                selecttypeerror.Show("Please Select a Login Type");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
