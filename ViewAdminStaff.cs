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
    public partial class ViewAdminStaff : Form
    {
        public ViewAdminStaff()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;

        private void ViewAdminStaff_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtype.SelectedIndex == 0 && txt_id.Text.Length == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Admin ", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataGridView.DataSource = dt;
                    con.Close();
                }
                else if (cmbtype.SelectedIndex == 0)
                {
                    if (!Regex.IsMatch(this.txt_id.Text, @"\A[ADMIN]+[0-9]{3}"))
                    {
                        guna2MessageDialog3.Show();
                    }
                    else
                    {
                        con.Open();
                        da = new SqlDataAdapter("Select * from Admin where AdminId='" + txt_id.Text + "' ", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataGridView.DataSource = dt;
                        con.Close();
                    }
                }
                else if (cmbtype.SelectedIndex == 1 && txt_id.Text.Length == 0)
                {
                    con.Open();
                    da = new SqlDataAdapter("Select * from Staff ", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataGridView.DataSource = dt;
                    con.Close();
                }
                else if (cmbtype.SelectedIndex == 1)
                {
                    if (!Regex.IsMatch(this.txt_id.Text, @"\A[ST]+[0-9]{3}"))
                    {
                        guna2MessageDialog3.Show();
                    }
                    else
                    {
                        con.Open();
                        da = new SqlDataAdapter("Select * from Staff where StaffID='" + txt_id.Text + "' ", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataGridView.DataSource = dt;
                        con.Close();
                    }
                }
            }
            catch (SqlException)
            {
                guna2MessageDialog1.Show();
            }
            catch (Exception)
            {
                guna2MessageDialog2.Show();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmbtype.SelectedIndex = -1;
            txt_id.Clear();
            DataGridView.DataSource = "";
        }
    }
}
