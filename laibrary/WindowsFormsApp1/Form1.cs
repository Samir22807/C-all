using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_is_Click(object sender, EventArgs e)
        {
         lb_ido.Text = textBox1.Text; 
         lb_nmo.Text = textBox2.Text;
         lb_bio.Text = textBox3.Text;
         lb_tio.Text = textBox4.Text;
         lb_auto.Text = textBox5.Text;
         lb_iso.Text = dateTimePicker1.Text;
         lb_reto.Text = dateTimePicker2.Text;
            if (rd_text.Checked == true)
            {
                lb_booko.Text=rd_text.Text;
            }
            if (rd_ref.Checked == true)
            {
                lb_booko.Text = rd_ref.Text;
            }
            if (rd_no.Checked == true)
            {
                lb_booko.Text = rd_no.Text;
            }
            if (rd_mag.Checked == true)
            {
                lb_booko.Text = rd_mag.Text;
            }
            panel2.Visible = true;
            
        }

        private void bt_cl_Click(object sender, EventArgs e)
        {
              textBox1.Text = "";
              textBox2.Text = "";
             textBox3.Text = "";
             textBox4.Text = "";
             textBox5.Text = "";
             dateTimePicker1.Text = "";
             dateTimePicker2.Text = "";
            panel2.Visible = false;
            lb_booko.Text = "";
            rd_text.Checked = false;
            rd_ref.Checked = false;
            rd_no.Checked = false;
            rd_mag.Checked = false;
                
        }

        private void bt_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
