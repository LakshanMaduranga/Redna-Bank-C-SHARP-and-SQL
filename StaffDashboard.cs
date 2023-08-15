using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace REDNA_BANK
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            Thread counter = new Thread(start_count);
            counter.Start();
        }
        string id;

        SqlConnection con;
        SqlCommand cmd;

        AddNewCustomer new_cus  = new AddNewCustomer() { TopLevel = false, TopMost = true };
        EditCustomerDetails edit_cus = new EditCustomerDetails() { TopLevel = false, TopMost = true };
        deletecus deletecustomer = new deletecus() { TopLevel = false, TopMost = true };
        Transaction trans = new Transaction() { TopLevel = false, TopMost = true };
        ViewTransactionDetails new_trans = new ViewTransactionDetails() { TopLevel = false, TopMost = true };
        view_customer view_cus = new view_customer() { TopLevel = false, TopMost = true };
        Email send_mail = new Email() { TopLevel = false, TopMost = true };
        currencyconverter currencycon = new currencyconverter() { TopLevel = false, TopMost = true };
        StaffDashboardHome staffhome = new StaffDashboardHome() { TopLevel = false, TopMost = true };
        private void panelslide_Paint(object sender, PaintEventArgs e)
        {

        }
        private void moveSidePanel(Control btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;
        }

        private void btn_staffhome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_staffhome);
            clsoe_forms();
            staffhome.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(staffhome);
            staffhome.Show();
        }

        private void btn_addcus_stf_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_addcus_stf);
            clsoe_forms();
            new_cus.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(new_cus);
            new_cus.Show();
        }

        private void btn_editcus_stf_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_editcus_stf);
            clsoe_forms();
            edit_cus.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(edit_cus);
            edit_cus.Show();
        }

        private void btn_deletestaff_stf_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_deletestaff_stf);
            clsoe_forms();
            deletecustomer.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(deletecustomer);
            deletecustomer.Show();
        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_transaction);
            clsoe_forms();
            trans.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(trans);
            trans.Show();
        }
        private void btn_currency_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_currency);
            clsoe_forms();
            currencycon.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(currencycon);
            currencycon.Show();
        }
        private void btn_accountdetails_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_accountdetails);
            clsoe_forms();
            new_trans.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(new_trans);
            new_trans.Show();
        }
        private void btn_view_cus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_view_cus);
            clsoe_forms();
            view_cus.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(view_cus);
            view_cus.Show();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_email);
            clsoe_forms();
            send_mail.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(send_mail);
            send_mail.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void clsoe_forms()
        {
            send_mail.Hide();
            view_cus.Hide();
            new_trans.Hide();
            trans.Hide();
            edit_cus.Hide();
            new_cus.Hide();
            currencycon.Hide();
            deletecustomer.Hide();
            staffhome.Hide();
        }
        

        private void btn_cal_Click(object sender, EventArgs e)
        {
            NewCalculator cal = new NewCalculator();
            cal.Show();
        }

        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            using (StreamReader streamreader = new StreamReader("Userid.txt"))
            {
                id = streamreader.ReadLine();
            }


            con.Open();
            cmd = new SqlCommand("Insert into StaffLogs (StID,SLogType, SLogDateTime) values ('" + id + "','Logout','" + DateTime.Now + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();


            this.Close();
            RednaLogin login = new RednaLogin();
            login.Show();
        }
        public void start_count()
        {
            timer.Start();
        }
        DateTime start = DateTime.UtcNow;
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime end = DateTime.UtcNow;
            TimeSpan timeDiff = end - start;
            time_d.Text = ("Duration - " + timeDiff.Days + ":" + timeDiff.Hours + ":" + timeDiff.Minutes + ":" + timeDiff.Seconds).ToString();
        }
    }

}
