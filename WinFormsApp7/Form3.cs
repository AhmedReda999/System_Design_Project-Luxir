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
    public partial class Form3 : Form
    {
        Form2 f = new Form2();

        public bool lux = false, spec = false, orig = false, cake = false;

        public int lux_qty, spec_qty, orig_qty, cake_qty;

        public int lux_price = 13, special_price = 20, original_price = 9;

        public string cake_type, cake_size;

        public int cake_size_price;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("You Haven't Selected Anything", "", MessageBoxButtons.OK);
                
            }

            else if((checkBox1.Checked == true && comboBox1.SelectedItem == null) || (checkBox2.Checked == true && comboBox2.SelectedItem == null) ||
                (checkBox3.Checked == true  && comboBox6.SelectedItem == null) || (checkBox4.Checked == true && comboBox4.SelectedItem == null && 
                comboBox5.SelectedItem == null && comboBox6.SelectedItem == null))
            {
                MessageBox.Show("You Haven't Selected an Item In a Combobox For a Checked Item", "", MessageBoxButtons.OK);
            }

            else
            {
                if(checkBox1.Checked == true  && comboBox1.SelectedItem != null)
                {
                    f.lux = true;
                    lux_qty = int.Parse(comboBox1.SelectedItem.ToString());
                    f.lux_qty = lux_qty;
                }

                if (checkBox2.Checked == true  && comboBox2.SelectedItem != null)
                {
                    f.spec = true;
                    spec_qty = int.Parse(comboBox2.SelectedItem.ToString());
                    f.spec_qty = spec_qty;
                }

                if (checkBox3.Checked == true  && comboBox6.SelectedItem != null)
                {
                    f.orig= true;
                    orig_qty = int.Parse(comboBox6.SelectedItem.ToString());
                    f.orig_qty = orig_qty;
                }

                if (checkBox4.Checked == true  && comboBox4.SelectedItem != null && comboBox5.SelectedItem != null && comboBox6.SelectedItem != null)
                {
                    f.cake = true;
                    cake_type = comboBox4.SelectedItem.ToString();
                    f.cake_type = cake_type;

                    if(comboBox5.SelectedIndex == 0)
                    {
                        cake_size = "Small";
                        f.cake_size = cake_size;
                        cake_size_price = 150;
                    }

                    else if (comboBox5.SelectedIndex == 1)
                    {
                        cake_size = "Medium";
                        f.cake_size = cake_size;
                        cake_size_price = 250;
                    }

                    else
                    {
                        cake_size = "Large";
                        f.cake_size = cake_size;
                        cake_size_price = 300;
                    }

                    cake_qty = int.Parse(comboBox6.SelectedItem.ToString());
                    f.cake_qty = cake_qty;
                }

                this.Hide();
                f.Show();
                f.show_recipt();
            }
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
