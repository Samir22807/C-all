using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void label3_Click(object sender, EventArgs e)
        {

        }
        int total = 0;

        

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label6.Text = comboBox1.Text;
            label5.Text = textBox4.Text;
            int amt = Convert.ToInt32(textBox6.Text);
            if (comboBox2.SelectedIndex == 0)
            {
                if (amt > 0)
                {
                    total += amt;
                }
            }

            label3.Text = textBox6.Text;
            textBox7.Text = total.ToString();
            label2.Text = textBox7.Text;





        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 2;
            axWindowsMediaPlayer1.uiMode = "none";
            bindingNavigator1.Visible = false;
            axWindowsMediaPlayer1.URL = @"C:\Users\pc\Downloads\gemini_generated_video_4c572952.mp4";
            

            // Video play karein
            axWindowsMediaPlayer1.Ctlcontrols.play();

            await Task.Delay(10000);

            // 3 second ke baad player stop aur hide ho jayega
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 2)
            {
                lbwitha.Visible = false;
                textBox6.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                lbwitha.Visible = true;
                textBox6.Visible = true;
                lbwitha.Text = "Deposit Amount :";
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                lbwitha.Visible = true;
                textBox6.Visible = true;
                lbwitha.Text = "Withdraw Amount :";
                button1.Visible= false;
                button2.Visible = true;
                button3.Visible= false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label6.Text = comboBox1.Text;
            label5.Text = textBox4.Text;
            int amt = Convert.ToInt32(textBox6.Text);
            if (comboBox2.SelectedIndex == 1)
            {
                if (amt < total || amt == total)
                {
                    total -= amt;
                }
            }

            label3.Text = textBox6.Text;
            textBox7.Text = total.ToString();
            label2.Text = textBox7.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label6.Text = comboBox1.Text;
            label5.Text = textBox4.Text;
            int amt = Convert.ToInt32(textBox6.Text);
            if (comboBox2.SelectedIndex == 2)
            {
                lbwitha.Visible = false;
                textBox6.Visible = false;
            }

            label3.Text = textBox6.Text;
            textBox7.Text = total.ToString();
            label2.Text = textBox7.Text;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
