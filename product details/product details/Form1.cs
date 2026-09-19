using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            label8.Text = textBox2.Text;
            label4.Text = textBox3.Text;
            
            label3.Text = textBox4.Text;
            label2.Text = textBox5.Text;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int price = Convert.ToInt32(textBox3.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                int fullp = price * qty;
                int dis = Convert.ToInt32(textBox5.Text);
                int total = fullp * dis / 100;
                int finalp = fullp - total;
                label1.Text = finalp.ToString();
                textBox6.Text = finalp.ToString();
            }
            catch 
            {
                textBox6.Text = "plese enter all data";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label8.Text = "";
            label9.Text = "";

        }
    }
}
