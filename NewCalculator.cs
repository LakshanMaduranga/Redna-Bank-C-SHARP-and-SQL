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
    
    public partial class NewCalculator : Form
    {
        double FirstNumber;
        string Operation;
        public NewCalculator()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "1";
            }
            else
            {
                txt_display.Text = txt_display.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "2";
            }
            else
            {
                txt_display.Text = txt_display.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "3";
            }
            else
            {
                txt_display.Text = txt_display.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "4";
            }
            else
            {
                txt_display.Text = txt_display.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "5";
            }
            else
            {
                txt_display.Text = txt_display.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "6";
            }
            else
            {
                txt_display.Text = txt_display.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "7";
            }
            else
            {
                txt_display.Text = txt_display.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "8";
            }
            else
            {
                txt_display.Text = txt_display.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "9";
            }
            else
            {
                txt_display.Text = txt_display.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (txt_display.Text == "0" && txt_display.Text != null)
            {
                txt_display.Text = "0";
            }
            else
            {
                txt_display.Text = txt_display.Text + "0";
            }
        }

        private void ndot_Click(object sender, EventArgs e)
        {
            txt_display.Text = txt_display.Text + ".";
        }

        private void nplus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_display.Text);
            txt_display.Text = "0";
            Operation = "+";
        }

        private void nmines_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_display.Text);
            txt_display.Text = "0";
            Operation = "-";
        }

        private void ndevide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_display.Text);
            txt_display.Text = "0";
            Operation = "/";
        }

        private void nmulti_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt_display.Text);
            txt_display.Text = "0";
            Operation = "*";
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txt_display.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txt_display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txt_display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txt_display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txt_display.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txt_display.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}
