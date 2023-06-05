namespace WebBroser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tela = new System.Windows.Forms.TextBox();
            this.pesquisar = new System.Windows.Forms.PictureBox();
            this.definir_home = new System.Windows.Forms.PictureBox();
            this.actualizar = new System.Windows.Forms.PictureBox();
            this.parar = new System.Windows.Forms.PictureBox();
            this.ir = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.PictureBox();
            this.voltar = new System.Windows.Forms.PictureBox();
            this.proximo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.definir_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 36);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(692, 325);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted);
            // 
            // tela
            // 
            this.tela.Location = new System.Drawing.Point(150, 1);
            this.tela.Multiline = true;
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(320, 29);
            this.tela.TabIndex = 3;
            this.tela.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tela_KeyDown);
            // 
            // pesquisar
            // 
            this.pesquisar.Image = global::WebBroser.Properties.Resources._1684617115629;
            this.pesquisar.Location = new System.Drawing.Point(602, 1);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(40, 29);
            this.pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pesquisar.TabIndex = 11;
            this.pesquisar.TabStop = false;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // definir_home
            // 
            this.definir_home.Image = global::WebBroser.Properties.Resources._612265ee10aa310004f39836;
            this.definir_home.Location = new System.Drawing.Point(648, 1);
            this.definir_home.Name = "definir_home";
            this.definir_home.Size = new System.Drawing.Size(40, 29);
            this.definir_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.definir_home.TabIndex = 10;
            this.definir_home.TabStop = false;
            this.definir_home.Click += new System.EventHandler(this.definir_home_Click);
            // 
            // actualizar
            // 
            this.actualizar.Image = global::WebBroser.Properties.Resources._1684785751742;
            this.actualizar.Location = new System.Drawing.Point(104, 1);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(40, 29);
            this.actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actualizar.TabIndex = 9;
            this.actualizar.TabStop = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // parar
            // 
            this.parar.Image = global::WebBroser.Properties.Resources._7;
            this.parar.Location = new System.Drawing.Point(556, 1);
            this.parar.Name = "parar";
            this.parar.Size = new System.Drawing.Size(40, 29);
            this.parar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.parar.TabIndex = 8;
            this.parar.TabStop = false;
            this.parar.Click += new System.EventHandler(this.parar_Click);
            // 
            // ir
            // 
            this.ir.Image = global::WebBroser.Properties.Resources._4;
            this.ir.Location = new System.Drawing.Point(464, 1);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(40, 29);
            this.ir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ir.TabIndex = 7;
            this.ir.TabStop = false;
            this.ir.Click += new System.EventHandler(this.ir_Click);
            // 
            // home
            // 
            this.home.Image = global::WebBroser.Properties.Resources._8655278;
            this.home.Location = new System.Drawing.Point(510, 1);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(40, 29);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home.TabIndex = 6;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // voltar
            // 
            this.voltar.Image = global::WebBroser.Properties.Resources._0;
            this.voltar.Location = new System.Drawing.Point(12, 1);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(40, 29);
            this.voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.voltar.TabIndex = 5;
            this.voltar.TabStop = false;
            this.voltar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // proximo
            // 
            this.proximo.Image = global::WebBroser.Properties.Resources._6;
            this.proximo.Location = new System.Drawing.Point(58, 1);
            this.proximo.Name = "proximo";
            this.proximo.Size = new System.Drawing.Size(40, 29);
            this.proximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proximo.TabIndex = 4;
            this.proximo.TabStop = false;
            this.proximo.Click += new System.EventHandler(this.proximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(692, 361);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.definir_home);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.parar);
            this.Controls.Add(this.ir);
            this.Controls.Add(this.home);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.proximo);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.definir_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tela;
        private System.Windows.Forms.PictureBox proximo;
        private System.Windows.Forms.PictureBox voltar;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.PictureBox ir;
        private System.Windows.Forms.PictureBox parar;
        private System.Windows.Forms.PictureBox actualizar;
        private System.Windows.Forms.PictureBox definir_home;
        private System.Windows.Forms.PictureBox pesquisar;
    }
}

