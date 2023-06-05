using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBroser
{
    public partial class Form1 : Form
    {

        string hom = null;
        string pesquisa = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void navegador()
        {
            webBrowser1.Navigate(tela.Text);
        }

        private void ir_Click(object sender, EventArgs e)
        {
           if(tela.Text != "")
            {
                navegador();
            }
            else
            {
                MessageBox.Show("Digite algo");
                tela.Focus();
            }
        }

        private void tela_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                navegador();
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            if(hom==null)
            {
                webBrowser1.GoHome();
            }
            else
            {
                webBrowser1.Navigate(hom);
            }
        }

        private void proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void webBrowse1_CanGoForwardChanged(object sender, EventArgs e)
        {
            proximo.Enabled = webBrowser1.CanGoForward;
        }
        private void webBrowse1_CanGoBackChanged(object sender, EventArgs e)
        {
            voltar.Enabled = webBrowser1.CanGoBack;
        }

        private void parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void definir_home_Click(object sender, EventArgs e)
        {
            hom = tela.Text;
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            if (pesquisa == null)
            {
                webBrowser1.GoSearch();
            }
            else
            {
                webBrowser1.Navigate(pesquisa);
            }
        }
    }
}
