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
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (txt_cvv.Text.Length > 0)
                {
                    if (textBox2.Text.Length > 0)
                    {
                        string s = "Transaction Complete! \nAmount Debited = " + Form1.net;
                       MessageBox.Show(s);
                       
                    }
                }
            }
            else
            {
                string s = "Oops! Transaction Failed!";

                MessageBox.Show(s);
                
            }
        }
    }
}
