using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace REDNA_BANK
{
    public partial class AddNewCustomer : Form
    {
        string cus_id; //cus_acc_no;
        public AddNewCustomer()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void btn_save_Click(object sender, EventArgs e)
        {
            void validate_massage(string error)
            {
                msg_bx.Show(error, "Information");
            }
            if (string.IsNullOrEmpty(txt_fullname.Text))
                validate_massage("Frist name Can not blank");
            else if (txt_fullname.Text.Any(char.IsDigit))
                validate_massage("Frist name Can not blank");
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
                validate_massage("address Can not blank");
            else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                validate_massage("address Can not blank");
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_fd.Text, "[^0-9]"))
                validate_massage("Please enter only numbers.");
            else
            {
                try
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("EXEC Add_Customer '"+txt_cusId.Text+"','"+txt_fullname.Text+"' ,'"+txt_ininame.Text+"' ,'"+txt_nic.Text+"' ,'"+cmb_gender.Text+"' ,'"+picker_dt.Value+"', "+txt_age.Text+" ,'"+txt_address.Text+"', "+txt_tp.Text+" ,'"+txt_email.Text+"' ,'"+txt_accno.Text+"' ,'"+cmb_type.Text+"' ,"+txt_fd.Text+",0;", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                        validate_massage("Data Cannot Save");
                    else
                    {
                        validate_massage("Data save Successfully");
                        // Email Start
                        emailsender em = new emailsender();
                        em.to(txt_email.Text);
                        em.subject("Your Redna Bank Account Has Been Created Successfully");
                        em.msg("Welcome To Redna Bank!\n\nDear " + txt_ininame.Text + ",\n\nThank you for becoming a member of Redna Bank!\n\nThanks & Best Regards,\nRedna Bank.");
                        em.send();
                        // Email End
                    }
                    con.Close();
                    cmd.Dispose();

                    con.Open();
                }
                catch (SqlException)
                {
                    MessageBox.Show(cmd.ToString());
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

        private void picker_dt_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - picker_dt.Value.Year).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fullname.Clear();
            txt_ininame.Clear();
            txt_age.Clear();
            txt_email.Clear();
            txt_tp.Clear();
            txt_address.Clear();
            txt_nic.Clear();
            txt_fd.Clear();
            cmb_gender.SelectedIndex = -1;
            cmb_type.SelectedIndex = -1;
            Autoinc();

        }
        public void Autoinc()
        {
            SqlConnection con1 = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
            SqlCommand cmd1;



            con1.Open();
            cmd1 = new SqlCommand("select max (CustomerID) from Customer", con1);
            var max_id = cmd1.ExecuteScalar() as string;
            if (max_id == null)
                txt_cusId.Text = "C001";
            else
            {
                int intval = int.Parse(max_id.Substring(1, 3));
                intval++;
                txt_cusId.Text = String.Format("C{0:000}", intval);
                cus_id = ("C00" + intval).ToString();
            }
            con1.Close();



            //===================================================
            con1.Open();
            cmd1 = new SqlCommand("select max (AccountId) from BankAccount", con1);
            var max_Id = cmd1.ExecuteScalar() as string;
            if (max_Id == null)
                txt_accno.Text = "25000001";



            else
            {
                int A = (Convert.ToInt32(max_Id));
                A++;
                txt_accno.Text = A.ToString();



            }
            con1.Close();



        }

        private void AddNewCustomer_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12");
            //SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("select max (CustomerID) from Customer", con);
            var max_id = cmd.ExecuteScalar() as string;
            if (max_id == null)
                txt_cusId.Text = "C001";
            else
            {
                int intval = int.Parse(max_id.Substring(1, 3));
                intval++;
                txt_cusId.Text = String.Format("C{0:000}", intval);
                cus_id = ("C00" + intval).ToString();
            }
            con.Close();

            //===================================================
            con.Open();
            cmd = new SqlCommand("select max (AccountId) from BankAccount", con);
            var max_Id = cmd.ExecuteScalar() as string;
            if (max_Id == null)
                txt_accno.Text = "25000001";

            else
            {
                int A = (Convert.ToInt32(max_Id));
                A++;
                txt_accno.Text = A.ToString();

            }
            con.Close();
            cmd.Dispose();
        }
    }
}
