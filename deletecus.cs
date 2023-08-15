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
using System.Text.RegularExpressions;

namespace REDNA_BANK
{
    public partial class deletecus : Form
    {
        public deletecus()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void deletecus_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Transactions where AccountNo= (select AccountID from BankAccount where CusID='" + txt_cus.Text + "') ", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = new SqlCommand("Delete from BankAccount where CusID ='" + txt_cus.Text + "'", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = new SqlCommand("Delete from Customer where CustomerID = '" + txt_cus.Text + "' ", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox1.Show("Data deleted Successfully", "Information");
                else
                    MessageBox2.Show("Cannot Delete Data", "Error");
                con.Close();
                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox1.Show("Data Errors", "Errors");
            }
            catch (Exception)
            {
                MessageBox2.Show("Please Check Again", "Error");
            }
            if (string.IsNullOrEmpty(txt_cus.Text))
            {
                MessageBox1.Show("Customer ID cannot be blank");
                txt_cus.Focus();
            }
            Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");
            if (r.IsMatch(txt_cus.Text))
            {
                MessageBox1.Show("Special characters are not allowed");
                txt_cus.Text = "";
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_cus.Clear();
            txt_fname.Clear();
            txt_iname.Clear();
            txt_nic.Clear();
            txt_addr.Clear();
            txt_tp.Clear();
        }

        private void txt_cus_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CFullname,CInitialtName,NIC,CustomerAddress,TpNo from Customer where CustomerId = '" + txt_cus.Text + "'", con);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txt_fname.Text = da.GetValue(0).ToString();
                txt_iname.Text = da.GetValue(1).ToString();
                txt_nic.Text = da.GetValue(2).ToString();
                txt_addr.Text = da.GetValue(3).ToString();
                txt_tp.Text = da.GetValue(4).ToString();
            }
            con.Close();
            cmd.Dispose();
        }
    }
}
