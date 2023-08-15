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
    public partial class ViewTransactionDetails : Form
    {
        public ViewTransactionDetails()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text) || !Regex.IsMatch(txt_id.Text, @"(^[0-9]{8}$)"))
            {
                guna2MessageDialog1.Show();
            }
            else
            {
                try
                {
                    // TODO: This line of code loads data into the 'TransactionsData.Transactions' table. You can move, or remove it, as needed.
                    this.TransactionsTableAdapter.Fill(this.TransactionsData.Transactions,txt_id.Text);

                    this.reportViewer1.RefreshReport();
                }
                catch (SqlException)
                {
                    guna2MessageDialog2.Show();
                }
                catch (Exception)
                {
                    guna2MessageDialog3.Show();
                }
            }
        }

        private void ViewTransactionDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            reportViewer1.Clear();
        }
    }
}
