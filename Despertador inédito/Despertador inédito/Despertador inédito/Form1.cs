using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despertador_inédito
{
    public partial class Form1 : Form
    {
        int hora, minuto;
        int segundo;
        string hora_alarme, minuto_alarme, desligar;

        public Form1()
        {

            InitializeComponent();
            timer1.Enabled = true;


        }
        SoundPlayer player = new SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 24; i++)
            {
                cmbxhora.Items.Add(i);
            }

            for (int j = 0; j < 60; j++)
            {
                cmbxminuto.Items.Add(j);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }
        private void Stop()
        {
            throw new NotImplementedException();
        }

        private void btntoclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbxhora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void labelhora_Click(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            hora_alarme = cmbxhora.Text;
            minuto_alarme = cmbxminuto.Text;
            listBox1.Items.Add(hora_alarme + " : " + minuto_alarme);  
            MessageBox.Show("Alarme marcado para as " + "" + hora_alarme + "h e " + "" + minuto_alarme + "min");
            {
               /* MessageBox.Show("Alarme marcado para as " + "" + hora + "h e " + "" + minuto + "min");
                /*if (labelhora.Text == cmbxhora.Text && labelminuto.Text == cmbxminuto.Text)
                 {
                     player.SoundLocation = @"S:\KMW_TREX.wav";
                     player.PlayLooping();
                 }
                 */
            }
        }

        //Ativar alarme//
        private void timer1_Tick(object sender, EventArgs e)
        {
            //código de las horas
            segundo = DateTime.Now.Second;
            minuto = DateTime.Now.Minute;
            hora = DateTime.Now.Hour;
            labelhora.Text = hora.ToString();
            labelminuto.Text = minuto.ToString();
            labelsegundo.Text = segundo.ToString();

           /* hora_alarme = cmbxhora.Text;
            minuto_alarme = cmbxminuto.Text;*/ 
            if (labelhora.Text == cmbxhora.Text && labelminuto.Text == cmbxminuto.Text && labelsegundo.Text=="0")
            {
                btncancelar.Visible = true;
                /*btniniciar.Visible = false;*/
                player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                player.PlayLooping();

            }
        }
    }
}
      

     /*   private void RingAlarm()
        {
            throw new NotImplementedException();
        }
      
        void Ring_Alarm()
            {
            if (hora_alarme == hora.ToString() && minuto_alarme == min.ToString() && seg.ToString() == "0")
            {

                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    player.PlayLooping();
                    MessageBox.Show("");
                    Application.Exit();
                }

                catch (Exception ex)
                {

          /*  if (hora == DateTime.Now.Hour && minuto == DateTime.Now.Minute)
            {
                timer1.Enabled = false;
                MessageBox.Show("Alarme");
            }
        }
        */
