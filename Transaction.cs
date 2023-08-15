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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void Transaction_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=rednabank.database.windows.net;Initial Catalog=RednaBank_DB;User ID=lakshan;Password=Redna@12;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            txt_AccountNumber.Select();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AccountNumber.Text) || !Regex.IsMatch(txt_AccountNumber.Text, @"(^[0-9]{8}$)"))
            {
                guna2MessageDialog10.Show();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Select AccountID,CusID,AccType,AccountBalance from BankAccount where AccountID='" + txt_AccountNumber.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txt_AccNo.Text = dr.GetValue(0).ToString();
                        txt_CusID.Text = dr.GetValue(1).ToString();
                        txt_AccType.Text = dr.GetValue(2).ToString();
                        txt_Balance.Text = dr.GetValue(3).ToString();
                    }
                    cmd.Dispose(); dr.Close();
                    con.Close();
                }
                catch (FormatException)
                { guna2MessageDialog9.Show(); }
                catch (SqlException)
                { guna2MessageDialog3.Show(); }
                catch (Exception)
                { guna2MessageDialog4.Show(); }
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amountdeposit.Text) || !Regex.IsMatch(txt_amountdeposit.Text, "^[0-9]*$"))
            {
                guna2MessageDialog11.Show();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("update BankAccount set AccountBalance=AccountBalance+" + txt_amountdeposit.Text + " where AccountID='" + txt_AccNo.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new SqlCommand("Insert into Transactions(PreFix,AccountNo,TransactionType,Amount,TransactionDateTime) values('T', '" + txt_AccNo.Text + "', 'Debit'," + txt_amountdeposit.Text + ", '" + DateTime.Now + "')", con);
                    int c = cmd.ExecuteNonQuery();
                    if (i == 1 && c == 1) 
                    { 
                        guna2MessageDialog1.Show();
                    }
                    else
                        guna2MessageDialog2.Show();
                    cmd.Dispose();
                    cmd = new SqlCommand("select AccountBalance from BankAccount where AccountID='" + txt_AccNo.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    { txt_Balance.Text = dr.GetValue(0).ToString(); 
                    }
                    if (i == 1 && c == 1)
                    {
                        // Email Start
                        Database db = new Database();
                        String to_email = db.dataScalar("select Email from Customer where CustomerID = (select CusID from BankAccount where AccountID = '" + txt_AccNo.Text + "')");
                        emailsender email = new emailsender();
                        email.to(to_email);
                        email.subject("Deposit Successful");
                        email.msg("Dear User,\n\nYour Account " + txt_AccNo.Text + " is debited Rs." + txt_amountdeposit.Text + " on " + DateTime.Now + "\nInformation : Total available balance is : Rs." + txt_Balance.Text + "\n\nThanks & Best Regards,\nRedna Bank.");
                        email.send();
                        // Email End
                    }
                    cmd.Dispose(); dr.Close();
                    con.Close();
                    txt_amountdeposit.Clear();
                }
                catch (FormatException)
                { guna2MessageDialog9.Show(); }
                catch (SqlException)
                { guna2MessageDialog3.Show(); }
                catch (Exception)
                { guna2MessageDialog4.Show(); }
            }
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_amountwithdraw.Text) || !Regex.IsMatch(txt_amountwithdraw.Text, "^[0-9]*$"))
            {
                guna2MessageDialog11.Show();
            }
            else if (Convert.ToDouble(txt_Balance.Text) < 1000 || Convert.ToDouble(txt_Balance.Text)<Convert.ToDouble(txt_amountwithdraw.Text))
            {
                guna2MessageDialog12.Show();
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("update BankAccount set AccountBalance=AccountBalance-" + txt_amountwithdraw.Text + " where AccountID='" + txt_AccNo.Text + "'", con);
                    int i = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = new SqlCommand("Insert into Transactions(PreFix,AccountNo,TransactionType,Amount,TransactionDateTime) values('T', '" + txt_AccNo.Text + "', 'Credit'," + txt_amountwithdraw.Text + ", '" + DateTime.Now + "')", con);
                    int c = cmd.ExecuteNonQuery();
                    if (i == 1 && c == 1)
                    {
                        guna2MessageDialog5.Show();
                    }
                    else
                        guna2MessageDialog6.Show();
                    cmd.Dispose();
                    cmd = new SqlCommand("select AccountBalance from BankAccount where AccountID='" + txt_AccNo.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txt_Balance.Text = dr.GetValue(0).ToString();
                    }

                    if (i == 1 && c == 1)
                    {
                        // Email Start
                        Database db = new Database();
                        String to_email = db.dataScalar("select Email from Customer where CustomerID = (select CusID from BankAccount where AccountID = '" + txt_AccNo.Text + "')");
                        emailsender email = new emailsender();
                        email.to(to_email);
                        email.subject("Withdrawal Successful");
                        email.msg("Dear User,\n\nYour Account " + txt_AccNo.Text + " is credited Rs." + txt_amountwithdraw.Text + " on " + DateTime.Now + "\nInformation : Total available balance is : Rs." + txt_Balance.Text + "\n\nThanks & Best Regards,\nRedna Bank.");
                        email.send();
                        // Email End
                    }

                    cmd.Dispose(); dr.Close();
                    con.Close();
                    txt_amountwithdraw.Clear();
                }
                catch (FormatException)
                { guna2MessageDialog9.Show(); }
                catch (SqlException)
                { guna2MessageDialog3.Show(); }
                catch (Exception)
                { guna2MessageDialog4.Show(); }
            }
        }

        private void btn_clearmain_Click(object sender, EventArgs e)
        {
            txt_AccountNumber.Clear();
            txt_AccNo.Clear();
            txt_CusID.Clear();
            txt_AccType.Clear();
            txt_Balance.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_AccountType.SelectedIndex == 0) //Children's Savings Account
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update BankAccount set AccountBalance=AccountBalance+(AccountBalance*" + txt_Interest.Text + "), Intrest=Intrest+(AccountBalance*" + txt_Interest.Text + ") where AccType='Children Savings Account' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                        guna2MessageDialog8.Show();
                    else
                        guna2MessageDialog7.Show();
                    con.Close();
                    cmd.Dispose();
                }
                catch (FormatException)
                { guna2MessageDialog9.Show(); }
                catch (SqlException)
                { guna2MessageDialog3.Show(); }
                catch (Exception)
                { guna2MessageDialog4.Show(); }
            }
            else if (cb_AccountType.SelectedIndex == 1) //Youth Savings Account
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update BankAccount set AccountBalance=AccountBalance+(AccountBalance*" + txt_Interest.Text + "), Intrest=Intrest+(AccountBalance*" + txt_Interest.Text + ") where AccType='Youth Savings Account' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                        guna2MessageDialog8.Show();
                    else
                        guna2MessageDialog7.Show();
                    con.Close();
                    cmd.Dispose();
                }
                catch (FormatException)
                { guna2MessageDialog9.Show(); }
                catch (SqlException)
                { guna2MessageDialog3.Show(); }
                catch (Exception)
                { guna2MessageDialog4.Show(); }
            }
            else if (cb_AccountType.SelectedIndex == 2) //Senior Citizen Savings Account
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update BankAccount set AccountBalance=AccountBalance+(AccountBalance*" + txt_Interest.Text + "), Intrest=Intrest+(AccountBalance*" + txt_Interest.Text + ") where AccType='Senior Citizen Savings Account' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 0)
                        guna2MessageDialog8.Show();
                    else
                        guna2MessageDialog7.Show();
                    con.Close();
                    cmd.Dispose();
                }
                catch (FormatException)
                { guna2MessageDialog9.Show(); }
                catch (SqlException)
                { guna2MessageDialog3.Show(); }
                catch (Exception)
                { guna2MessageDialog4.Show(); }
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            cb_AccountType.SelectedIndex = -1;
            txt_Interest.Clear();
        }
    }
}
