using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Guna.UI2.WinForms;

namespace WhatsappMessege
{
    public partial class Form1 : Form
    {
        private const string TwilioAccountSid = "AC291ba0b26f9d67dee6fe08e7f2952cd7";
        private const string TwilioAuthToken = "9287a0d11da2c8de2f2bd35a8d7067ec";
        private const string TwilioWhatsAppNumber = "+14155238886"; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string numero = "+244" + txtPhone.Text;
            string mensagem = txtMessage.Text;
            //942031240
            TwilioClient.Init(TwilioAccountSid, TwilioAuthToken);

            //numero = "+244953179690";


            var message = MessageResource.Create(
                body: mensagem,
                from: new Twilio.Types.PhoneNumber("whatsapp:" + TwilioWhatsAppNumber),
                to: new Twilio.Types.PhoneNumber("whatsapp:" + numero)
               ); 
            
             
            MessageBox.Show("Mensagem enviada com sucesso!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged_1(object sender, EventArgs e)
        {

        } 
    }
}
