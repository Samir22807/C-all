using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nm.Text=textBox1.Text;
            id.Text=textBox2.Text;
            if(radioButton3.Checked==true )
            {
                rate.Text = radioButton3.Text;
            }
            if (radioButton4.Checked == true)
            {
                rate.Text = radioButton4.Text;
            }
            if (radioButton5.Checked == true)
            {
                rate.Text = radioButton5.Text;
            }
            if (radioButton6.Checked == true)
            {
                rate.Text = radioButton6.Text;
            }
            if (radioButton7.Checked == true)
            {
                rate.Text = radioButton7.Text;
            }
            feed.Text=richTextBox1.Text;
            if (radioButton1.Checked == true)
            {
                rec.Text = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                rec.Text = radioButton2.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nm.Text = "";
            id.Text = "";
            rate.Text = "";
            feed.Text = "";
            rec.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
