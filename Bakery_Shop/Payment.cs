using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_Shop
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        Card cd= new Card();
        upi up = new upi();
        public double bal1;

        private void card_CheckedChanged(object sender, EventArgs e)
        {
            cd.Show();
            card.Checked = false;
            
        }

        private void upi_CheckedChanged(object sender, EventArgs e)
        {
            up.Show();
            
            upi.Checked = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (bal1 > 0)
            {
                string s = "Transaction Successful! \nYour Balance Amount is = " + txt_bal.Text;

                MessageBox.Show(s);
                
            }
            else
            {
                string s = "Oops! Transaction Failed! \nPlease Add Amount = " + txt_bal.Text;

                MessageBox.Show(s);
               
            }

        }

        private void txt_bal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (txt_amount.Text.Length > 0)
            {
                txt_bal.Text = (Math.Round((Convert.ToDouble(txt_amount.Text) - Convert.ToDouble(Form1.net)), 2)).ToString();
                bal1 = Convert.ToDouble(txt_bal.Text);
            }
            else
            {
                txt_bal.Text = "-"+Form1.net;
                bal1 = Convert.ToDouble(txt_bal.Text);

            }
        }

       
    }
}
