using System;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.IO;

namespace REDNA_BANK
{
    public partial class Admindashboard : Form
    {
        public Admindashboard()
        {
            InitializeComponent();
            Thread counter = new Thread(start_count);
            counter.Start();
        }
        string id;

        SqlConnection con;
        SqlCommand cmd;

        editstaff_admin edit = new editstaff_admin() { TopLevel = false, TopMost = true };
        view_customer view_cus = new view_customer() { TopLevel = false, TopMost = true };
        AddStaffAdmin addstadmin = new AddStaffAdmin() { TopLevel = false, TopMost = true };
        ViewAdminStaff viewstaffadmin = new ViewAdminStaff() { TopLevel = false, TopMost = true };
        AddNewCustomer add_cus = new AddNewCustomer() { TopLevel = false, TopMost = true };
        EditCustomerDetails edit_cus = new EditCustomerDetails() { TopLevel = false, TopMost = true };
        deleteadminstaff deleteadst = new deleteadminstaff() { TopLevel = false, TopMost = true };
        AdminHomePage admin_home_p = new AdminHomePage() { TopLevel = false, TopMost = true };
        deletecus deletecustomer = new deletecus () { TopLevel = false, TopMost = true };
        Email  e_mail= new Email() { TopLevel = false, TopMost = true };
        Logs as_logs = new Logs() { TopLevel = false, TopMost = true };
        private void moveSidePanel(Control btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
            clsoe_forms();
            admin_home_p.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(admin_home_p);
            admin_home_p.Show();
        }

        private void btn_addstaff_adm_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_addstaff_adm);
            clsoe_forms();
            addstadmin.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(addstadmin);
            addstadmin.Show();
        }

        private void btn_editstaff_adm_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_editstaff_adm);
            clsoe_forms();
            edit.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(edit);
            edit.Show();
        }

        private void btn_deletestaff_adm_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_deletestaff_adm);
            clsoe_forms();
            deleteadst.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(deleteadst);
            deleteadst.Show();
        }

        private void btn_view_ad_staff_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_view_ad_staff);
            clsoe_forms();
            viewstaffadmin.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(viewstaffadmin);
            viewstaffadmin.Show();
        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_addCus);
            clsoe_forms();
            add_cus.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(add_cus);
            add_cus.Show();
        }

        private void btn_editCus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_editCus);
            clsoe_forms();
            edit_cus.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(edit_cus);
            edit_cus.Show();
        }

        private void btn_deleteCus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_deleteCus);
            clsoe_forms();
            deletecustomer.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(deletecustomer);
            deletecustomer.Show();
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
            e_mail.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(e_mail);
            e_mail.Show();
        }
        private void btn_logs_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_logs);
            clsoe_forms();
            as_logs.FormBorderStyle = FormBorderStyle.None;
            this.panelform.Controls.Add(as_logs);
            as_logs.Show();
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
            as_logs.Hide();
            e_mail.Hide();
            edit_cus.Hide();
            add_cus.Hide();
            viewstaffadmin.Hide();
            addstadmin.Hide();
            view_cus.Hide();
            edit.Hide();
            deleteadst.Hide();
            admin_home_p.Hide();
            deletecustomer.Hide();
        }
        
        private void Admindashboard_Load(object sender, EventArgs e)
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
            cmd = new SqlCommand("Insert into AdminLogs (AdID,ALogType, ALogDateTime) values ('"+id+"','Logout','" + DateTime.Now + "')", con);
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
