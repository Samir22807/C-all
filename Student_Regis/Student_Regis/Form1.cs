using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Regis
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            if(comboBox1.SelectedIndex == 0)
            {
                label12.Text = "BCA";
            }
            if(comboBox1.SelectedIndex==1){
                label12.Text = "BBA";
            }
            if(comboBox1.SelectedIndex == 2)
            {
                label12.Text = "B.COM";
            }

            label13.Text = textBox4.Text;   
            label14.Text = textBox5.Text;
            label15.Text = radioButton1.Checked ? "Male" : "Female";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
