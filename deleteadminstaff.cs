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
    public partial class deleteadminstaff : Form
    {
        public deleteadminstaff()
        {
            InitializeComponent();
        }
        SqlConnection con;//Initiate Pipline
        SqlCommand cmd;//Initiate Capsule

        private void deleteadminstaff_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (cmb_ty.SelectedIndex == 0)
            {
                try
                {
                    con.Open(); //open the Pipeline
                    cmd = new SqlCommand("Delete from StaffLogs where StID = '" + txt_sdtype.Text + "'", con);
                    int c = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new SqlCommand("Delete from Staff where StaffID = '" + txt_sdtype.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageDialog1.Show("Data Deleted Successfully", "Information");
                    else
                        MessageDialog2.Show("Data Cannot Delete", "Error");
                    con.Close();
                    cmd.Dispose();
                }
                catch (SqlException)
                {
                    MessageDialog1.Show("Data Errors", "Error");
                }
                catch (Exception)
                {
                    MessageDialog2.Show("Please Check Again", "Error");
                }
                if (string.IsNullOrEmpty(txt_sdtype.Text))
                {
                    MessageDialog1.Show("Staff ID cannot be blank");
                    txt_sdtype.Focus();
                }
                Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");
                if (r.IsMatch(txt_sdtype.Text))
                {
                    MessageDialog2.Show("Special characters are not allowed");
                    txt_sdtype.Text = "";
                }
            }
            else if (cmb_ty.SelectedIndex == 1)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Delete from AdminLogs where AdID = '" + txt_sdtype.Text + "'", con);
                    int c = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new SqlCommand("Delete from Admin where AdminId ='" + txt_sdtype.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageDialog1.Show("Data Deleted Successfully", "Information");
                    else
                        MessageDialog2.Show("Data Cannot Delete", "Error");
                    con.Close();
                    cmd.Dispose();
                }
                catch (SqlException)
                {
                    MessageDialog1.Show("Data Errors", "Errors");
                }
                catch (Exception)
                {
                    MessageDialog2.Show("Please Check again", "Error");
                }

                if (string.IsNullOrEmpty(txt_sdtype.Text))
                {
                    MessageDialog1.Show(" Admin ID cannot be blank");
                    txt_sdtype.Focus();
                }
                Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");
                if (r.IsMatch(txt_sdtype.Text))
                {
                    MessageDialog2.Show("Special characters are not allowed");
                    txt_sdtype.Text = "";
                }

            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            cmb_ty.SelectedIndex = -1;
            txt_sdtype.Clear();
            txt_fname.Clear();
            txt_iname.Clear();
            txt_nic.Clear();
            txt_tp.Clear();
            txt_eml.Clear();
        }

        private void txt_sdtype_TextChanged(object sender, EventArgs e)
        {
            if (cmb_ty.SelectedIndex == 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select SFullname,SIniName,SNIC,StaffTP,StaffEmail from Staff where StaffID = '" + txt_sdtype.Text + "'", con);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txt_fname.Text = da.GetValue(0).ToString();
                    txt_iname.Text = da.GetValue(1).ToString();
                    txt_nic.Text = da.GetValue(2).ToString();
                    txt_tp.Text = da.GetValue(3).ToString();
                    txt_eml.Text = da.GetValue(4).ToString();
                }
                con.Close();
                cmd.Dispose();
            }
            else if (cmb_ty.SelectedIndex == 1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select AFullname,AIniName,ANIC,AdTP,AdEmail from Admin where AdminId = '" + txt_sdtype.Text + "'", con);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txt_fname.Text = da.GetValue(0).ToString();
                    txt_iname.Text = da.GetValue(1).ToString();
                    txt_nic.Text = da.GetValue(2).ToString();
                    txt_tp.Text = da.GetValue(3).ToString();
                    txt_eml.Text = da.GetValue(4).ToString();
                }
                con.Close();
                cmd.Dispose();
            }
        }
    }
}
