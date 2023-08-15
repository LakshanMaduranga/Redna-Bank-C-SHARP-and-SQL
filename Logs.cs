using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REDNA_BANK
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            staffrt.Hide();
            adminrt.Hide();
        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtype.SelectedIndex == 0)
            {
                staffrt.Hide();
                adminrt.Show();
            }
            else if (cmbtype.SelectedIndex == 1)
            {
                adminrt.Hide();
                staffrt.Show();
            }
        }
        void validate_msg(string error)
        {
            validationmsgbx.Show(error, "Error");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
                validate_msg("User ID Cannot be Empty");
            else if (cmbtype.Text.Length == 0)
                validate_msg("Please Select a Type");
            else

                if (cmbtype.SelectedIndex == 0)
            {
                // TODO: This line of code loads data into the 'logreports.AdminLogs' table. You can move, or remove it, as needed.
                this.AdminLogsTableAdapter.Fill(this.logreports.AdminLogs,txt_id.Text);
                this.adminrt.RefreshReport();
            }
            else if (cmbtype.SelectedIndex == 1)
            {
                // TODO: This line of code loads data into the 'logreports.StaffLogs' table. You can move, or remove it, as needed.
                this.StaffLogsTableAdapter.Fill(this.logreports.StaffLogs,txt_id.Text);
                this.staffrt.RefreshReport();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            cmbtype.SelectedIndex = -1;
            staffrt.Clear();
            adminrt.Clear();
        }
    }
}
