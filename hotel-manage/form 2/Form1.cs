using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total=0;
            nm.Text=textBox1.Text;
            no.Text=textBox2.Text;
            ino.Text=dateTimePicker1.Text;
            outo.Text=dateTimePicker2.Text;
            if (radioButton1.Checked == true)
            {
                room.Text=radioButton1.Text;
                total += 1000;
            }
            if (radioButton2.Checked == true)
            {
                room.Text = radioButton2.Text;
                total += 2000;
            }
            if (radioButton3.Checked == true)
            {
                room.Text = radioButton3.Text;
                total += 3000;
            }
            if (radioButton4.Checked == true)
            {
                room.Text = radioButton4.Text;
                total += 15000;
            }
            days.Text=textBox3.Text;
            if(checkBox1.Checked == true)
            {
                total += 100;
            }
            if (checkBox2.Checked == true)
            {
                total += 1500;
            }
            if (checkBox3.Checked == true)
            {
                total += 0;
            }
            if (checkBox4.Checked == true)
            {
                total += 100;
            }
            if (checkBox5.Checked == true)
            {
                total += 1000;
            }
            if (checkBox6.Checked == true)
            {
                total += 6000;
            }

            textBox4.Text = total.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            nm.Text = "";
            no.Text = "";
            ino.Text = "";
            outo.Text = "";
            days.Text = "";
            room.Text = "";
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
