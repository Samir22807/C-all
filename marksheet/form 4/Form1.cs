using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3 ,t=0;
            float p;

            s1=Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            s3 = Convert.ToInt16(textBox5.Text);
            t = s1+ s2+s3;
            textBox6.Text=t.ToString();
            p = t / 3;
            textBox7.Text=p.ToString();

            if(p>=90)
            {
                textBox8.Text = "A";
            }
           else if (p >= 80 && p<90)
            {
                textBox8.Text = "B";
            }
            else if (p >= 70 && p < 80)
            {
                textBox8.Text = "C";
            }
            else if (p >= 60 && p < 70)
            {
                textBox8.Text = "D";
            }
            else
            {
                textBox8.Text = "F";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
