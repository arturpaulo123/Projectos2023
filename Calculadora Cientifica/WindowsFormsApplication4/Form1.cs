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
        double Contido1;
            double Contido2;
        double resultado;
            double memoria;
        bool inicio;

        string operador;

        public Form1()
        {
            InitializeComponent();
        }
        char[] Valor_V = new char[]
   {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',','
   };


        private void button40_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "1";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "2";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "3";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "4";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "5";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "9";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + "0";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            txt_Resultado.Text = txt_Resultado.Text + ".";
           // btn_Virgula.Enabled = false;

        }

        private void button32_Click(object sender, EventArgs e)
        {
            operador = "+";
            Contido1 = double.Parse(txt_Resultado.Text);
            txt_Resultado.Clear();

        }

        private void button43_Click(object sender, EventArgs e)
        {
            operador = "-";
            Contido1 = double.Parse(txt_Resultado.Text);
            txt_Resultado.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operador = "*";
            Contido1 = double.Parse(txt_Resultado.Text);
            txt_Resultado.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operador = "/";
            Contido1 = double.Parse(txt_Resultado.Text);
            txt_Resultado.Clear();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Contido2 = double.Parse(txt_Resultado.Text);
            switch (operador)
            {
                case "+" :
                    resultado =Contido1+ Contido2;
                    txt_Resultado.Text = resultado.ToString();
                    break;
                case "-":
                    resultado =Contido1- Contido2;
                    txt_Resultado.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = Contido1 *Contido2;
                    txt_Resultado.Text = resultado.ToString();
                    break;
                case "/":
                    resultado =Contido1/ Contido2;
                    txt_Resultado.Text = resultado.ToString();
                    break;


            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Contido1 = double.Parse(txt_Resultado.Text);
            resultado = Contido1;
            txt_Resultado.Text = Math.Sqrt(Contido1).ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            operador = "%";
            Contido2 = double.Parse(txt_Resultado.Text);
            resultado = Contido1 + Contido2;
            txt_Resultado.Text = Convert.ToString((Contido1 * Contido2) / 100);
            txt_Resultado.Clear();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Contido1 = double.Parse(txt_Resultado.Text);
            resultado = Contido1;
            txt_Resultado.Text = Math.Pow(Contido1,3).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Contido1 = double.Parse(txt_Resultado.Text);
            resultado = Contido1;
            txt_Resultado.Text = Math.Pow(Contido1, 2).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Contido1 = double.Parse(txt_Resultado.Text);
            resultado = Contido1;
            txt_Resultado.Text = Math.Pow(Contido1, -1).ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Contido1 = double.Parse(txt_Resultado.Text);
            resultado = Contido1;
            txt_Resultado.Text = Math.Pow(10, Contido1).ToString();

        }

       
      
       
        private void button6_Click(object sender, EventArgs e)
        {
            txt_Resultado.Clear();
        }

    

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_Resultado.TextLength > 1)
            {
                txt_Resultado.Text = txt_Resultado.Text.Remove(txt_Resultado.Text.Length-1,1);
            }
            if (txt_Resultado.Text.Length == 1)
            {
                txt_Resultado.Text = "0";
                inicio = true;
                

                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_Resultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (char chaves in Valor_V)
            {
                if (e.KeyChar == chaves || e.KeyChar == '\b')
                    return;
            }

            e.Handled = true;
        }

        private void maisoumenos_Click(object sender, EventArgs e)
        {
            double ver = double.Parse(txt_Resultado.Text);
            ver *= -1;
            txt_Resultado.Text = ver.ToString();
  
        }
    }
}
