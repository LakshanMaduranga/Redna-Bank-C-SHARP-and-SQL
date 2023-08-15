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
    public partial class EditCustomerDetails : Form
    {
        SqlCommand cmd;
        public EditCustomerDetails()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_fullname.Clear();
            txt_ininame.Clear();
            txt_age.Clear();
            txt_email.Clear();
            txt_tp.Clear();
            txt_address.Clear();
            txt_nic.Clear();

            txt_search.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            void validate_massage(string error)
            {
                validationmsgbox.Show(error, "ERROR");
            }
            if (string.IsNullOrEmpty(txt_fullname.Text))
                validate_massage("First Name Can not blank");
            else if (txt_fullname.Text.Any(char.IsDigit))
                validate_massage("First name Can not blank");
            else if (string.IsNullOrEmpty(txt_ininame.Text))
                validate_massage("initial name Can not blank");
            else if (txt_ininame.Text.Any(char.IsDigit))
                validate_massage("initial name Can not blank");
            else if (Convert.ToInt32(txt_age.Text) < 0)
                validate_massage("Birthday cannot be Minus");
            else if (txt_email.Text.Length == 0)
                validate_massage("Email error");
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                validate_massage("Email error");
            else if (string.IsNullOrEmpty(txt_address.Text))
                validate_massage("Address Can not blank");
            else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                validate_massage("Address Can not blank");
            else
            {
                SqlConnection con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
                try
                {
                    if (rdb_nic.Checked == true)
                    {
                        con.Open();
                        cmd = new SqlCommand("Update Customer set CFullname='" + txt_fullname.Text + "',CInitialtName = '" + txt_ininame.Text + "', NIC = '" + txt_nic.Text + "', Gender= '" + cmb_gender.Text + "', DOB= '" + DateTimePicker_date.Value + "', Age= '" + txt_age.Text + "',CustomerAddress='" + txt_address.Text + "',TpNo= '" + txt_tp.Text + "', Email='" + txt_email.Text + "'where NIC = '" + txt_search.Text + "'", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            validate_massage("Data save Successfully");
                        else
                            validate_massage("Data Cannot Save");
                        con.Close();
                        cmd.Dispose();
                    }
                    else if (rdb_BankAcc.Checked == true)
                    {
                        con.Open();
                        cmd = new SqlCommand("Update Customer set CFullname='" + txt_fullname.Text + "',CInitialtName = '" + txt_ininame.Text + "', NIC = '" + txt_nic.Text + "', Gender= '" + cmb_gender.Text + "', DOB= '" + DateTimePicker_date.Value + "', Age= '" + txt_age.Text + "',CustomerAddress='" + txt_address.Text + "',TpNo= '" + txt_tp.Text + "', Email='" + txt_email.Text + "'where CustomerID = '" + txt_search.Text + "'", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                            validate_massage("Data save Successfully");
                        else
                            validate_massage("Data Cannot Save");
                        con.Close();
                        cmd.Dispose();
                    }


                }
                catch (SqlException)
                {
                    validate_massage("Database Errors");
                }

                catch (FormatException)
                {
                    validate_massage("Format Errors");
                }

                catch (Exception)
                {
                    validate_massage("  An Errors");
                }


            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
            con.Open();

            SqlCommand cmd = new SqlCommand("select CFullname,CInitialtName,NIC,Gender,DOB,Age,CustomerAddress,TpNo,Email from Customer where NIC = '" + txt_search.Text + "'", con);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txt_fullname.Text = da.GetValue(0).ToString();

                txt_ininame.Text = da.GetValue(1).ToString();

                txt_nic.Text = da.GetValue(2).ToString();

                cmb_gender.Text = da.GetValue(3).ToString();

                DateTimePicker_date.Text = da.GetValue(4).ToString();

                txt_age.Text = da.GetValue(5).ToString();

                txt_address.Text = da.GetValue(6).ToString();

                txt_tp.Text = da.GetValue(7).ToString();

                txt_email.Text = da.GetValue(8).ToString();

            }
            con.Close();
        }
    }
}
