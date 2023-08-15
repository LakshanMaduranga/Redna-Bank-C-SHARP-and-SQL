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
    public partial class AddStaffAdmin : Form
    {
        public AddStaffAdmin()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        string x_table, x_id, x_dob, x_gender;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            type_selector.SelectedIndex = -1; id.Clear(); fname.Clear(); name_with_i.Clear();
            dob_picker.Format = DateTimePickerFormat.Custom;
            age.Clear(); nic.Clear(); gender.SelectedIndex = -1; address.Clear(); t_no.Clear(); email.Clear(); password.Clear();
        }

        private void AddStaffAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
            }
            catch (SqlException)
            {
                error_msg("Database Connection Errors");
            }
            catch (Exception)
            {
                error_msg("Errors");
            }
        }

        private void type_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_selector.SelectedIndex == 0)
            {
                cmd = new SqlCommand("select MAX(AdminId) from Admin", conn);
                conn.Open();
                var max_id = cmd.ExecuteScalar() as string;
                if (max_id == null)
                {
                    id.Text = "ADMIN001";
                    x_table = "Admin"; x_id = "ADMIN001";
                }
                else
                {
                    int intval = int.Parse(max_id.Substring(5, 3));
                    intval++;
                    id.Text = String.Format("ADMIN{0:000}", intval);
                    x_table = "Admin"; x_id = ("ADMIN00" + intval).ToString();
                }
                conn.Close();

            }
            else if (type_selector.SelectedIndex == 1)
            {
                cmd = new SqlCommand("select MAX(StaffID) from Staff", conn);
                conn.Open();
                var max_id = cmd.ExecuteScalar() as string;
                if (max_id == null)
                {
                    id.Text = "ST001";
                    x_table = "Staff"; x_id = "ST001";
                }
                else
                {
                    int intval = int.Parse(max_id.Substring(2, 3));
                    intval++;
                    id.Text = String.Format("ST{0:000}", intval);
                    x_table = "Staff"; x_id = ("ST00" + intval).ToString();
                }
                conn.Close();
            }
        }

        private void dob_picker_ValueChanged(object sender, EventArgs e)
        {
            int xage = DateTime.Now.Year - dob_picker.Value.Year;
            age.Text = xage.ToString();
            x_dob = (dob_picker.Value.Year + "-" + dob_picker.Value.Month + "-" + dob_picker.Value.Day).ToString();
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
           // x_gender = gender.SelectedItem.ToString();
        }

        void error_msg(string error)
        {
            error_msg_box.Show(error);
        }
        private void btn_add_staff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text))
                error_msg("Full Name cannot be blank");
            else if (fname.Text.Any(char.IsDigit))
                error_msg("Full Name cannot have numbers");
            else if (string.IsNullOrEmpty(name_with_i.Text))
                error_msg("Name With Initials cannot be blank");
            else if (name_with_i.Text.Any(char.IsDigit))
                error_msg("Name With Initials cannot have numbers");
            else if (type_selector.Text.Length == 0)
                error_msg("Please Select a Type");
            else if (string.IsNullOrEmpty(age.Text))
                error_msg("Age cannot be blank");
            else if (Convert.ToInt32(age.Text) < 0)
                error_msg("Birthday cannot be Minus");
            else if (string.IsNullOrEmpty(nic.Text))
                error_msg("NIC cannot be blank");
            else if (gender.Text.Length == 0)
                error_msg("Please Select A Gender");
            else if (string.IsNullOrEmpty(address.Text))
                error_msg("Address cannot be blank");
            else if (t_no.Text.Length != 10 || !Regex.IsMatch(t_no.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                error_msg("Please Enter Phone Number Correctly");
            else if (email.Text.Length == 0)
                error_msg("Please Enter Email Address");
            else if (!Regex.IsMatch(email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                error_msg("Enter a valid email. Ex:name@gmail.com");
            else if (password.Text.Length == 0)
                error_msg("Please Enter A Password");
            else if (password.Text.Length < 8)
                error_msg("Please Enter Password Longer Than 8 Characters");
            else
            {
               try
               {
                    conn.Open();
                    cmd = new SqlCommand("insert into " + x_table + " values ('" + x_id + "','" + fname.Text + "','" + name_with_i.Text + "','" + nic.Text + "','" + gender.Text + "','" + x_dob + "'," + age.Text + ",'" + address.Text + "'," + t_no.Text + ",'" + email.Text + "','" + password.Text + "');", conn);
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                    {
                        successful_msg_box.Show("Account Created Successfully");
                        
                        // Email Start
                        try
                        { 
                            emailsender em = new emailsender();
                            em.to(email.Text);
                            em.subject("Account Created Successfully");
                            em.msg("Welcome To Redna Bank!\n\nDear " + name_with_i.Text + ",\n\nYour User ID : " + x_id + "\nYour Password : " + password.Text + "\n\nThanks & Best Regards,\nRedna Bank.");
                            em.send();
                        }
                        catch(Exception)
                        {
                            error_msg("Email Send Failed");
                        }
                        // Email End*/
                    }
                    else
                        error_msg("Data Cannot Save");
                    conn.Close();
                    cmd.Dispose();
                }
                catch (SqlException)
               {
                    error_msg("Database Errors");
                }
                catch (Exception)
                {
                   error_msg("Errors");
               }
            }
        }
    }
}
