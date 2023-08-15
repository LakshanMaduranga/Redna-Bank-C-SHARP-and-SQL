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
    public partial class AdminHomePage : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        public string count(string command)
        {
            string x = "";
            con.Open();
            cmd = new SqlCommand(command, con);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                x = data.GetValue(0).ToString();
            }
            cmd.Dispose();
            con.Close();
            return x;
        }
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;Persist Security Info=True;User ID=lakshan;Password=Redna@12");
                admin_c.Text = count("select count(AdminId) from admin;");
                staff_c.Text = count("select count(StaffID) from staff;");
                customer_c.Text = count("select count(CustomerID) from customer;");
                Trans_c.Text = count("select count(ID) from Transactions;");

                con.Open();
                cmd = new SqlCommand("select AccountNo ,Amount from Transactions where TransactionType = 'Debit'", con);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    Trans.Series["Debit"].Points.AddXY(data.GetValue(0), data.GetValue(1));
                }
                con.Close();
                cmd.Dispose();
                con.Open();
                cmd = new SqlCommand("select AccountNo ,Amount from Transactions where TransactionType = 'Credit'", con);
                SqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    Trans.Series["Credit"].Points.AddXY(dt.GetValue(0), dt.GetValue(1));
                }
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                error_msg.Show("Database Error");
            }
            catch (Exception)
            {
                error_msg.Show("Error");
            }
        }
    }
}
