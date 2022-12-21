using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool lux = false, spec = false, orig = false, cake = false;

        public int lux_qty, spec_qty, orig_qty, cake_qty;

        public int lux_price = 13, special_price = 20, original_price = 9;

        public string cake_type, cake_size;

        public int cake_size_price;

        public int sum;

        public void show_recipt()
        {
            sum = 0;
            
            if (lux)
            {
                textBox1.Text += "- Lux = " + lux_qty + " * " + lux_price + " = " + (lux_qty * lux_price) + "\r\n\n";
                sum += lux_qty * lux_price;
            }

            if (spec)
            {
                textBox1.Text += "- Special = " + spec_qty + " * " + special_price + " = " + (spec_qty * special_price) + "\r\n\n";
                sum += spec_qty * special_price;
            }

            if (orig)
            {
                textBox1.Text += "- Original = " + orig_qty + " * " + original_price + " = " + (orig_qty * original_price) + "\r\n\n";
                sum += orig_qty * original_price;
            }

            if (cake)
            {
                textBox1.Text += "- Cake :" + "\r\nType: " + cake_type + "\r\nSize:" + cake_size + "\r\n" + cake_qty + " * " +
                    cake_size_price + " = " + (cake_qty * cake_size_price) + "\r\n\n";
                sum += cake_qty * cake_size_price;
            }

            textBox1.Text += "Total = " + sum;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(0, 1000000000);
            MessageBox.Show("Your Order ID Is " + x, "Thank You for Your Purchase", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.Show();
        }
    }
}
