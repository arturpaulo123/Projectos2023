using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public decimal ANS;
        public decimal num;
        public string tt = "x10^";
        public int operacao;
        public void exp()
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "x10^";
            }
            else
            {
                textBox1.Text = textBox1.Text + "x10^";
            }
        }
        public void EXP(){
            int res = 10;
            int indice = textBox1.Text.IndexOf(tt);
            decimal n;
            string ind= textBox1.Text.Substring(indice + 4);
            if( ind.Length > 1){
                n=Convert.ToDecimal(ind);
            }
            else if( ind.Length ==1 ){
                n = Convert.ToInt32(ind);
            }
            else
            {
                n = 1;
            }
            
            for(int i=1; i<n; i++){
                res *= 10;
            }
            textBox1.Text = (Convert.ToDecimal(textBox1.Text.Substring(0, indice)) * res).ToString();
        }
        public void alterabotoes (int num){
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + num.ToString(); 
            }
            else
            {
                textBox1.Text = textBox1.Text + num.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alterabotoes(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            alterabotoes(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alterabotoes(2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            alterabotoes(8);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alterabotoes(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alterabotoes(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            alterabotoes(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            alterabotoes(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            alterabotoes(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            alterabotoes(0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (operacao==1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = num.ToString();
                    
                }
                else
                {
                    textBox1.Text = (num + Convert.ToDecimal(textBox1.Text)).ToString();
                }
            }
            if (operacao == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = num.ToString();
                }
                else
                {
                    textBox1.Text = (num - Convert.ToInt32(textBox1.Text)).ToString();
                }
            }
            if (operacao == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = num.ToString();
                    ANS = Convert.ToDecimal(textBox1.Text);
                }
                else
                {
                    textBox1.Text = (num * Convert.ToInt32(textBox1.Text)).ToString();
                }
            }
            if (operacao == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = num.ToString();
                }
                else
                {
                    textBox1.Text = (num / Convert.ToInt32(textBox1.Text)).ToString();
                }
            }
            if (operacao == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = num.ToString();
                }
                else
                {
                    textBox1.Text = ((num / 100) * Convert.ToDecimal(textBox1.Text)).ToString();
                }
            }
            if (operacao == 6)
            {
                EXP();

            }
            ANS = Convert.ToDecimal(textBox1.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                string frase = textBox1.Text;
                textBox1.Text = frase.Substring(0, frase.Length - 1);
            }
            }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            exp();
            operacao = 6;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            operacao = 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            operacao = 1;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            operacao = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            operacao = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = Convert.ToDecimal(textBox1.Text);
            textBox1.Clear();
            operacao = 4;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            decimal aux;
            if (textBox1.Text == "" && operacao==0)
            {
                textBox1.Text = textBox1.Text + ANS.ToString();
            }
            else if(textBox1.Text=="" && operacao!=0){
                textBox1.Text = textBox1.Text + ANS.ToString();
            }
            else if(textBox1.Text!="" && operacao==0)
            {
                num = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = textBox1.Text + ANS.ToString();
            }
            else if(textBox1.Text!="" && operacao!=0){
                num = Convert.ToDecimal(textBox1.Text);
                aux = num * ANS;
                textBox1.Text = aux.ToString();
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
