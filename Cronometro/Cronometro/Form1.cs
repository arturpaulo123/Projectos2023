using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        private Stopwatch time; 
        public Form1()
        {
            InitializeComponent();
            Continuar.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time.Start();
            button1.Visible = false;
            Continuar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time.Stop();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            time.Reset();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", time.Elapsed);  
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            time.Start();
            Continuar.Visible = true;
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
