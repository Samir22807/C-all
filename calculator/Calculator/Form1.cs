using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, tot;

            num1 = Convert.ToInt16(txt_nm1.Text);
            num2 = Convert.ToInt16(txt_nm2.Text);
            tot = num1 + num2;

            lbl_fin.Text = "Your Addition Is :" + tot.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, tot;

            num1 = Convert.ToInt16(txt_nm1.Text);
            num2 = Convert.ToInt16(txt_nm2.Text);
            tot = num1 - num2;

            lbl_fin.Text = "Your Substraction Is :" + tot.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, tot;

            num1 = Convert.ToInt16(txt_nm1.Text);
            num2 = Convert.ToInt16(txt_nm2.Text);
            tot = num1 * num2;

            lbl_fin.Text = "Your Multiplication Is :" + tot.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, tot;

            num1 = Convert.ToInt16(txt_nm1.Text);
            num2 = Convert.ToInt16(txt_nm2.Text);
            tot = num1 / num2;

            lbl_fin.Text = "Your Division Is :" + tot.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_nm1.Text = "";
            txt_nm2.Text = "";
            lbl_fin.Text = "";
        }
    }
}
