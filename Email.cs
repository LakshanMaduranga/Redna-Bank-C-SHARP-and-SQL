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

namespace REDNA_BANK
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }
        emailsender em = new emailsender();
        private void btn_send_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (string.IsNullOrEmpty(to.Text))
            {
                email_msg_error.Show("Please enter a receiver email address");
                error = 1;
            }
            if (!Regex.IsMatch(to.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                email_msg_error.Show("Enter a valid email address. Ex:name@gmail.com");
                error = 1;
            }
            if (bcc.Text.Length != 0)
            {
                if (!Regex.IsMatch(bcc.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    email_msg_error.Show("Enter a valid BCC email address. Ex:name@gmail.com");
                    error = 1;
                }
                else
                    em.bcc(bcc.Text);
            }
            if (cc.Text.Length != 0)
            {
                if (!Regex.IsMatch(cc.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    email_msg_error.Show("Enter a valid CC email address. Ex:name@gmail.com");
                    error = 1;
                }
                else
                    em.cc(cc.Text);
            }
            if (string.IsNullOrEmpty(subject.Text))
            {
                email_msg_error.Show("Please enter a subject");
                error = 1;
            }
            if (error == 0)
            {
                try
                {
                    em.to(to.Text);
                    em.subject(subject.Text);
                    em.msg(body.Text);
                    em.send();
                    to.Clear(); cc.Clear(); bcc.Clear(); subject.Clear(); body.Clear(); file_location.Clear();
                    file_location.Visible = false;
                    email_msg_ok.Show("Email sent successfully");
                }
                catch (Exception)
                {
                    email_msg_error.Show("Error");
                }
            }
        }

        private void btn_attach_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    file_location.Visible = true;
                    file_location.Text = dlg.FileName.ToString();
                    em.Attachment(file_location.Text);
                }
            }
            catch (Exception)
            {
                email_msg_error.Show("Error");
            }
        }
    }
}
