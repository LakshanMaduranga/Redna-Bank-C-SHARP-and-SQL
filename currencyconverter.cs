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
    public partial class currencyconverter : Form
    {
        public currencyconverter()
        {
            InitializeComponent();
        }

        private void currencyconverter_Load(object sender, EventArgs e)
        {
            try
            {
                currencyweb.Navigate("https://wise.com/gb/currency-converter/gbp-to-lkr-rate?amount=1000");
            }
            catch (Exception)
            {
                MessageBox.Show("Internet Connection Needed");
            }
        }
    }
}
