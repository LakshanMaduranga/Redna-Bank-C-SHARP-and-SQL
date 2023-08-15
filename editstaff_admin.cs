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
    public partial class editstaff_admin : Form
    {
        public editstaff_admin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        private void editstaff_admin_Load(object sender, EventArgs e)
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
        string selectTable, userID, xfname, xIname, xnic, xgender, xdob, xage, xaddress, xtp, xemail, xpassword;

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtype.SelectedIndex == 0)
            {
                selectTable = cmbtype.SelectedItem.ToString();
                userID = "AdminId";
                xfname = "AFullName"; xIname = "AIniName"; xnic = "ANIC"; xgender = "AGender"; xdob = "ADOB"; xage = "AdAge"; xaddress = "AdminAddress"; xtp = "AdTP"; xemail = "AdEmail"; xpassword = "AdminPassword";
            }
            else if (cmbtype.SelectedIndex == 1)
            {
                selectTable = cmbtype.SelectedItem.ToString();
                userID = "StaffID";
                xfname = "SFullName"; xIname = "SIniName"; xnic = "SNIC"; xgender = "SGender"; xdob = "SDOB"; xage = "SAge"; xaddress = "StaffAddress"; xtp = "StaffTP"; xemail = "StaffEmail"; xpassword = "StaffPassword";
            }
        }
        private void txt_userID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select " + xfname + ", " + xIname + ", " + xnic + ", " + xgender + ", " + xdob + ", " + xaddress + ", " + xtp + ", " + xemail + ", " + xpassword + " from " + selectTable + " where " + userID + " = '" + txt_userID.Text + "'", con);
                SqlDataReader da = cmd.ExecuteReader();


                while (da.Read())
                {
                    txt_fname.Text = da.GetValue(0).ToString();
                    txt_ininame.Text = da.GetValue(1).ToString();
                    txt_nic.Text = da.GetValue(2).ToString();
                    cmb_gender.Text = da.GetValue(3).ToString();
                    datetimepicker.Text = da.GetValue(4).ToString();
                    txt_address.Text = da.GetValue(5).ToString();
                    txt_mobile_no.Text = da.GetValue(6).ToString();
                    txt_email.Text = da.GetValue(7).ToString();
                    txt_password.Text = da.GetValue(8).ToString();
                }
                con.Close();
                cmd.Dispose();



            }
            catch (SqlException)
            {
                updatebtnsqlerror.Show("Database Errors", "Error");
            }
            catch (Exception)
            {
                updatebtnexception.Show("Errors", "Error");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_userID.Clear();
            cmbtype.SelectedIndex = -1;
            txt_fname.Clear();
            txt_ininame.Clear();
            txt_nic.Clear();
            cmb_gender.SelectedIndex = -1;
            datetimepicker.Value = DateTime.Now;
            txt_address.Clear();
            txt_mobile_no.Clear();
            txt_email.Clear();
            txt_password.Clear();
        }
        void validate_msg(string error)
        {
            validationmsgbx.Show(error, "Error");
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fname.Text))
                validate_msg("Full Name cannot be blank");
            else if (txt_fname.Text.Any(char.IsDigit))
                validate_msg("Full Name cannot have numbers");
            else if (string.IsNullOrEmpty(txt_ininame.Text))
                validate_msg("Name With Initials cannot be blank");
            else if (txt_ininame.Text.Any(char.IsDigit))
                validate_msg("Name With Initials cannot have numbers");
            else if (string.IsNullOrEmpty(txt_age.Text))
                validate_msg("Age cannot be blank. Please select the birthday from Date Time Picker");
            else if (Convert.ToInt32(txt_age.Text) < 0)
                validate_msg("Birthday cannot be Minus");
            else if (string.IsNullOrEmpty(txt_nic.Text))
                validate_msg("NIC cannot be blank");
            else if (cmb_gender.Text.Length == 0)
                validate_msg("Please Select a Gender");
            else if (string.IsNullOrEmpty(txt_address.Text))
                validate_msg("Address cannot be blank");
            else if (txt_mobile_no.Text.Length != 10 || !Regex.IsMatch(txt_mobile_no.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                validate_msg("Please Enter Phone Number Correctly");
            else if (txt_email.Text.Length == 0)
                validate_msg("Please Enter Email Address");
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                validate_msg("Enter a valid email. Ex:name@gmail.com");
            else if (txt_password.Text.Length == 0)
                validate_msg("Please Enter a Password");
            else if (txt_password.Text.Length < 8)
                validate_msg("Please Enter Password Longer Than 8 Characters");
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update " + selectTable + " set " + xfname + " = '" + txt_fname.Text + "'," + xIname + " ='" + txt_ininame.Text + "', " + xnic + "='" + txt_nic.Text + "'," + xgender + "='" + cmb_gender.Text + "'," + xdob + "='" + datetimepicker.Value + "'," + xage + "='" + txt_age.Text + "', " + xaddress + "='" + txt_address.Text + "'," + xtp + "='" + txt_mobile_no.Text + "'," + xemail + "='" + txt_email.Text + "'," + xpassword + "='" + txt_password.Text + "' where " + userID + "='" + txt_userID.Text + "' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        adminsuccessfullmessagebox.Show("Data Updated Successfully!", "Information");
                    else
                        adminerrormessage.Show("Data Updated Unsuccessfully!", "Error");
                    con.Close();
                    cmd.Dispose();
                }
                catch (SqlException)
                {
                    updatebtnsqlerror.Show("Database Errors", "Error");
                }
                catch (Exception)
                {
                    updatebtnexception.Show("Errors", "Error");
                }
            }
        }
        private void datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - datetimepicker.Value.Year).ToString();
        }
    }
}
