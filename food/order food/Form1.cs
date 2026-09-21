using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_food
{
    public partial class Form1 : Form
    {
      public  int total = 0,total2=0,total3=0;
        public Form1()
        {
            InitializeComponent();
        }
        // PUNJABI FOOD SELECTION TYPE
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (select_item_p.SelectedIndex == 0)
            {
                total = 250;
                price_p.Text = total.ToString();
            }
            if (select_item_p.SelectedIndex == 1)
            {
                total = 300;
                price_p.Text = total.ToString();

            }
            if (select_item_p.SelectedIndex == 2)
            {
                total = 150;
                price_p.Text = total.ToString();

            }
            if (select_item_p.SelectedIndex == 3)
            {
                total = 100;
                price_p.Text = total.ToString();

            }
            if (select_item_p.SelectedIndex == 4)
            {
                total = 250;
                price_p.Text = total.ToString();

            }
            if (select_item_p.SelectedIndex == 5)
            {
                total = 15;
                price_p.Text = total.ToString();

            }
            if (select_item_p.SelectedIndex == 6)
            {
                total = 10;
                price_p.Text = total.ToString();

            }
        }

        // TOTAL AMOUNT CALCULATION OF PUNJABI FOOD
        private void button1_Click(object sender, EventArgs e)
        {
            int q = 0;
            q = Convert.ToInt16(qua_p.Text);
            total = total * q;
            if(cheese_p.Checked==true)
            {
                total += 30;
            }
            if (drink_p.Checked == true)
            {
                total += 50;
            }
            if (paneer_p.Checked == true)
            {
                total += 10;
            }
            if (take_p.Checked == true)
            {
                total += 20;
            }
            amt_p.Text= total.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // TOTAL AMOUNT CALCULATION OF CHINESE FOOD
        private void button2_Click(object sender, EventArgs e)
        {
            int q = 0;
            q = Convert.ToInt16(qua_c.Text);
            total2 = total2 * q;
            if (cheese_c.Checked == true)
            {
                total2 += 30;
            }
            if (drink_c.Checked == true)
            {
                total2 += 50;
            }
            if (souc_c.Checked == true)
            {
                total2 += 10;
            }
            if (take_c.Checked == true)
            {
                total2 += 20;
            }
            amt_c.Text = total2.ToString();
        }
        // FAST FOOD SELECTION TYPE
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_item_f.SelectedIndex == 0)
            {
                total3 = 250;
                price_f.Text = total3.ToString();
            }
            if (select_item_f.SelectedIndex == 1)
            {
                total3 = 300;
                price_f.Text = total3.ToString();

            }
            if (select_item_f.SelectedIndex == 2)
            {
                total3 = 150;
                price_f.Text = total3.ToString();

            }
            if (select_item_f.SelectedIndex == 3)
            {
                total3 = 100;
                price_f.Text = total3.ToString();

            }
        }

        // TOTAL AMOUNT CALCULATION OF FAST FOOD
        private void button3_Click(object sender, EventArgs e)
        {
            int q = 0;
            q = Convert.ToInt16(qua_f.Text);
            total3 = total3 * q;
            if (cheese_f.Checked == true)
            {
                total3 += 30;
            }
            if (drink_f.Checked == true)
            {
                total3 += 50;
            }
            if (ketchp_f.Checked == true)
            {
                total3 += 10;
            }
            if (take_f.Checked == true)
            {
                total3 += 20;
            }
            amt_f.Text = total3.ToString();
        }

        // CHOOSE TYPE VISIBILITY
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(choose_food.SelectedIndex==0)
            {
                punjabi.Visible = true;
                chinese.Visible = false;
                fastfood.Visible = false;
            }
            if (choose_food.SelectedIndex == 1)
            {
                chinese.Visible = true;
                punjabi.Visible = false;
                fastfood.Visible = false;
            }
            if (choose_food.SelectedIndex == 2)
            {
                fastfood.Visible = true;
                punjabi.Visible = false;
                chinese.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // EXIT BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear all the fields and reset the form
        private void button4_Click(object sender, EventArgs e)
        {
            choose_food.Text = "";
            select_item_p.Text = "";
            select_item_c.Text = "";
            select_item_f.Text = "";
            price_p.Text = "";
            price_c.Text = "";
            price_f.Text = "";
            qua_p.Text = "";
            qua_c.Text = "";
            qua_c.Text = "";
            cheese_p.Text = "";
            cheese_c.Text = "";
            cheese_f.Text = "";
            drink_p.Text = "";
            drink_c.Text = "";
            drink_f.Text = "";
            paneer_p.Text = "";
            souc_c.Text = "";
            ketchp_f.Text = "";
            charge_p.Text = "";
            charge_c.Text = "";
            charge_f.Text = "";
            take_p.Text = "";
            take_c.Text = "";
            take_f.Text = "";
            amt_p.Text = "";
            amt_c.Text = "";
            amt_f.Text = "";
            punjabi.Visible = false;
            chinese.Visible = false;
            fastfood.Visible = false;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        // CHINESE FOOD SELECTION TYPE
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_item_c.SelectedIndex == 0)
            {
                total2 = 250;
                price_c.Text = total2.ToString();
            }
            if (select_item_c.SelectedIndex == 1)
            {
                total2 = 300;
                price_c.Text = total2.ToString();

            }
            if (select_item_c.SelectedIndex == 2)
            {
                total2 = 150;
                price_c.Text = total2.ToString();

            }
            if (select_item_c.SelectedIndex == 3)
            {
                total2 = 100;
                price_c.Text = total2.ToString();

            }
        }
    }
}
