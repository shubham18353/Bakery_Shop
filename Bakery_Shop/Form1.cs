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

namespace Bakery_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Payment pay =new Payment();
        public static string net;


        // Non Veg Pizzas
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

                // Creating Connection  
                SqlConnection con = new SqlConnection("data source=.; initial catalog=PizzaOrdering; integrated security=true");

            cmb_items.Items.Clear();
            SqlCommand cmd = new SqlCommand("select pizzaName from nonVegPizza",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_items.Items.Add(dr["pizzaName"]);
            }
            con.Close();   

            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string x = txt_qty.Text;
            if (x.Length > 0)
            {
                txt_total.Text = Convert.ToString(Convert.ToDouble(x) * Convert.ToDouble(txt_price.Text));
            }
            
        }
        // Veg Pizzas
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_items.Items.Clear();
            SqlConnection con = new SqlConnection("data source=.; initial catalog=PizzaOrdering; integrated security=true");
            SqlCommand cmd = new SqlCommand("select pizzaName from vegPizza",con);
           con.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            
            while (dr1.Read())
            {
                cmb_items.Items.Add(dr1["pizzaName"]);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                string selectedItem=cmb_items.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("data source=.; initial catalog=PizzaOrdering; integrated security=true");
                SqlCommand cmd = new SqlCommand("select price from vegPizza where pizzaName=@selectedItem", con);
                con.Open();
                cmd.Parameters.AddWithValue("@selectedItem", selectedItem);
                object result = cmd.ExecuteScalar();
                con.Close();
                txt_price.Text = result.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                string selectedItem1 = cmb_items.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("data source=.; initial catalog=PizzaOrdering; integrated security=true");
                SqlCommand cmd = new SqlCommand("select price from nonVegPizza where pizzaName=@selectedItem1", con);
                con.Open();
                cmd.Parameters.AddWithValue("@selectedItem1", selectedItem1);
                object result = cmd.ExecuteScalar();
                con.Close();
                txt_price.Text = result.ToString();
            }
           else if (radioButton3.Checked == true)
            {
                string selectedItem2 = cmb_items.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("data source=.; initial catalog=PizzaOrdering; integrated security=true");
                SqlCommand cmd = new SqlCommand("select price from coke where drink=@selectedItem2", con);
                con.Open();
                cmd.Parameters.AddWithValue("@selectedItem2", selectedItem2);
                object result = cmd.ExecuteScalar();
                con.Close ();
                txt_price.Text = result.ToString();
            }
            txt_qty.Text = "0";
            txt_total.Text = "0";
        }



        private void txt_dis_TextChanged(object sender, EventArgs e)
        {
            if (txt_dis.Text.Length > 0)
            {
                double sub = Convert.ToDouble(txt_sub.Text);
                double disc = Convert.ToDouble(txt_dis.Text);
                txt_net.Text = (Math.Round((sub - disc * 0.01 * sub),2)).ToString();
                net=txt_net.Text;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (Convert.ToInt16(txt_qty.Text)> 0)
            {
                string[] arr = new string[4];
                arr[0] = cmb_items.SelectedItem.ToString();
                arr[1] = txt_qty.Text;
                arr[2] = txt_price.Text;
                arr[3] = txt_total.Text;

                ListViewItem lv = new ListViewItem(arr);
                listView1.Items.Add(lv);

                txt_sub.Text = (Convert.ToDouble(lv.SubItems[3].Text) + Convert.ToDouble(txt_sub.Text)).ToString();
            }

            if (txt_dis.Text.Length > 0)
            {
                double sub = Convert.ToDouble(txt_sub.Text);
                double disc = Convert.ToDouble(txt_dis.Text);
                txt_net.Text = (Math.Round((sub - disc * 0.01 * sub), 2)).ToString();
                net=txt_net.Text;
            }
        }

    

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for(int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_sub.Text=(Convert.ToDouble(txt_sub.Text) - Convert.ToDouble(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
            if (txt_dis.Text.Length > 0)
            {
                double sub = Convert.ToDouble(txt_sub.Text);
                double disc = Convert.ToDouble(txt_dis.Text);
                txt_net.Text = (Math.Round((sub - disc * 0.01 * sub), 2)).ToString();
                net = txt_net.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pay.Show();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
//cokeList
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cmb_items.Items.Clear();
            SqlConnection con = new SqlConnection("data source=.; initial catalog=PizzaOrdering; integrated security=true");
            SqlCommand cmd = new SqlCommand("select drink from coke", con);
            con.Open();
            SqlDataReader dr1 = cmd.ExecuteReader();
            
            while (dr1.Read())
            {
                cmb_items.Items.Add(dr1["drink"]);
            }
            con.Close();
        }

        private void txt_qty_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_qty.Value);
            if (x >= 0)
            {
                txt_total.Text = Convert.ToString(Convert.ToDouble(x) * Convert.ToDouble(txt_price.Text));
            }
        }

        private void txt_net_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
