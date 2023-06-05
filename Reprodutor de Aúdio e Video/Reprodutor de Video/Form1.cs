using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reprodutor_de_video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WMPLib.IWMPPlaylist playList;
        private void abrir_Click(object sender, EventArgs e)
        {

         
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void carregar_Click(object sender, EventArgs e)
        {
        }

        private void lst_DoubleClick(object sender, EventArgs e)
        {
            if(lst11.Items.Count > 0)
            {
                axWindowsMediaPlayer1.URL = lst11.SelectedItem.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            open.Title = "Abrir mídea";
            open.Filter = "Arquivo mp4|*.mp4|Arquivo mp3|*.mp3";
            open.Filter = "Mp3 Files|*.mp3|M4A|*.m4a";
            if (open.ShowDialog() == DialogResult.OK)
            {
                playList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Lista");
                foreach (var arquivo in open.FileNames)
                {
                    playList.appendItem(axWindowsMediaPlayer1.newMedia(arquivo));
                    lst11.Items.Add(arquivo);
                    axWindowsMediaPlayer1.currentPlaylist = playList;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open.Title = "Abrir Playlist";
            open.Filter = "Arquivo texto|*.txt";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(open.FileName);
                while (arquivo.Peek() != -1)
                {
                    lst11.Items.Add(arquivo.ReadLine());
                }
                arquivo.Close();
            }
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lst11.Items.Count > 0)
            {
                save.Title = "Salvar";
                save.Filter = "arquivo texto|*.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter arquivo = new StreamWriter(save.FileName, false);
                    for (int i = 0; i < lst11.Items.Count; i++)
                    {
                        arquivo.WriteLine(lst11.Items[i].ToString());
                    }
                    arquivo.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            lst11.Items.Clear();
        }
    }
}
