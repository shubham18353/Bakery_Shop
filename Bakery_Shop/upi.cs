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
    public partial class upi : Form
    {
        public upi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_vpa.Text.Length > 0)
            {
                if (txt_name.Text.Length > 0)
                {

                    string s = "Trasaction Complete! \n Amount Debited = "+ Form1.net;
                    MessageBox.Show(s);
                    
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
