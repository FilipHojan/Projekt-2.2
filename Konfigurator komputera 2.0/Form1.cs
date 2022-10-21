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
    public partial class Form1 : Form
    {

        public static int GlobalKomputer = 0;
        public static int GlobalMonitor = 0;
        public static int GlobalCalosc = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form3();
            myForm1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.GlobalKomputer == 0 ^ GlobalMonitor == 0 ^ GlobalCalosc == 0)
            {
                label3.ForeColor = Color.Red;
            }
            else if (GlobalKomputer != 0 && GlobalMonitor != 0 && GlobalCalosc != 0)
            {
                label3.ForeColor = Color.Green;
            }
            Form1.GlobalCalosc = Form1.GlobalKomputer + Form1.GlobalMonitor;
            label3.Text = Form1.GlobalCalosc.ToString();
        }
    }
    
}
