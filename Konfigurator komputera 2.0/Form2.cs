using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konfigurator_komputera_2._0
{
    public partial class Form2 : Form
    {

        public static int procesor = 0;
        public static int ram = 0;
        public static int pamiec = 0;
        public static int kartagraficzna = 0;
        public static int system = 0;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                Form2.procesor = 0;
            }
            if (radioButton1.Checked == true && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                Form2.procesor = 500;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == true && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                Form2.procesor = 700;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == true && radioButton4.Checked == false)
            {
                Form2.procesor = 1200;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == true)
            {
                Form2.procesor = 1700;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }






        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }







        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }








        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form2.procesor == 0 ^ Form2.ram == 0 ^ Form2.pamiec == 0 ^ Form2.kartagraficzna == 0 ^ Form2.system == 0)
            {
                label7.ForeColor = Color.Red;
            }
            else if (Form2.procesor != 0 ^ Form2.ram != 0 ^ Form2.pamiec != 0 ^ Form2.kartagraficzna != 0 ^ Form2.system == 0)
            {
                label7.ForeColor = Color.Orange;
            }
            else if (Form2.procesor != 0 ^ Form2.ram != 0 ^ Form2.pamiec != 0 ^ Form2.kartagraficzna == 0 ^ Form2.system != 0)
            {
                label7.ForeColor = Color.Orange;
            }
            else if (Form2.procesor != 0 ^ Form2.ram != 0 ^ Form2.pamiec == 0 ^ Form2.kartagraficzna != 0 ^ Form2.system != 0)
            {
                label7.ForeColor = Color.Orange;
            }
            else if (Form2.procesor != 0 ^ Form2.ram == 0 ^ Form2.pamiec != 0 ^ Form2.kartagraficzna != 0 ^ Form2.system != 0)
            {
                label7.ForeColor = Color.Orange;
            }
            else if (Form2.procesor == 0 ^ Form2.ram != 0 ^ Form2.pamiec != 0 ^ Form2.kartagraficzna != 0 ^ Form2.system != 0)
            {
                label7.ForeColor = Color.Orange;
            }
            else if (Form2.procesor != 0 ^ Form2.ram != 0 ^ Form2.pamiec != 0 ^ Form2.kartagraficzna != 0 ^ Form2.system != 0)
            {
                label7.ForeColor = Color.Green;
            }

            Form1.GlobalKomputer = Form2.procesor + Form2.ram + Form2.pamiec + Form2.kartagraficzna + Form2.system;
            label7.Text = Form1.GlobalKomputer.ToString();
        }
    }
}
