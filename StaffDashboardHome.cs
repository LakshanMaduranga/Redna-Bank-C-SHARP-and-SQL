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

namespace REDNA_BANK
{
    public partial class StaffDashboardHome : Form
    {
        public StaffDashboardHome()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        
        private void StaffDashboardHome_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select COUNT(AccountID) from BankAccount where AccType='Senior Citizen Savings Account'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                guna2HtmlLabel1.Text = dr.GetValue(0).ToString();
            }
            cmd.Dispose();
            dr.Close();
            cmd = new SqlCommand("select COUNT(AccountID) from BankAccount where AccType='Youth Savings Account'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                guna2HtmlLabel2.Text = dr.GetValue(0).ToString();
            }
            cmd.Dispose();
            dr.Close();
            cmd = new SqlCommand("select COUNT(AccountID) from BankAccount where AccType='Children Savings Account'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                guna2HtmlLabel3.Text = dr.GetValue(0).ToString();
            }
            cmd.Dispose();
            dr.Close();
        }
    }
}
