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
    public partial class view_customer : Form
    {
        public view_customer()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;

        private void view_customer_Load(object sender, EventArgs e)
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
        void validate_msg(string error)
        {
            validationmsgbx.Show(error, "Error");
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_no_nic.Text) && radb_nic.Checked == false && rdb_accno.Checked == false)
            {
                con.Open();
                da = new SqlDataAdapter("Select * from Customer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagridview_cus.DataSource = dt;
                con.Close();
            }

            else if (radb_nic.Checked == false && rdb_accno.Checked == false)
            {
                if (!string.IsNullOrEmpty(txt_no_nic.Text))
                    validate_msg("Please check radio button");

            }
            else
            {
                try
                {
                    if (radb_nic.Checked == true)
                    {
                        con.Open();
                        da = new SqlDataAdapter("Select * from Customer where NIC = '" + txt_no_nic.Text + "' ", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagridview_cus.DataSource = dt;
                        con.Close();
                    }
                    else if (rdb_accno.Checked == true)
                    {
                        con.Open();
                        da = new SqlDataAdapter("select * from Customer where CustomerID = (select CusID from BankAccount where AccountID = '" + txt_no_nic.Text + "')", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        datagridview_cus.DataSource = dt;
                        con.Close();
                    }
                }
                catch (SqlException)
                {
                    databaseerroor.Show("DataBase Errors", "Error");
                }
                catch (Exception)
                {
                    exceptionmessageform.Show("Errors", "Error");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            datagridview_cus.DataSource = null;
            txt_no_nic.Clear();
            radb_nic.Checked = false;
            rdb_accno.Checked = false;
        }
    }
}
