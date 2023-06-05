namespace Despertador_inédito
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
            this.components = new System.ComponentModel.Container();
            this.labelhora = new System.Windows.Forms.Label();
            this.labeldoispontos = new System.Windows.Forms.Label();
            this.labelminuto = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelsegundo = new System.Windows.Forms.Label();
            this.cmbxhora = new System.Windows.Forms.ComboBox();
            this.cmbxminuto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btntoclose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelhora
            // 
            this.labelhora.AutoSize = true;
            this.labelhora.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhora.Location = new System.Drawing.Point(56, 73);
            this.labelhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(165, 128);
            this.labelhora.TabIndex = 0;
            this.labelhora.Text = "00";
            this.labelhora.Click += new System.EventHandler(this.labelhora_Click);
            // 
            // labeldoispontos
            // 
            this.labeldoispontos.AutoSize = true;
            this.labeldoispontos.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldoispontos.Location = new System.Drawing.Point(186, 59);
            this.labeldoispontos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldoispontos.Name = "labeldoispontos";
            this.labeldoispontos.Size = new System.Drawing.Size(81, 128);
            this.labeldoispontos.TabIndex = 1;
            this.labeldoispontos.Text = ":";
            // 
            // labelminuto
            // 
            this.labelminuto.AutoSize = true;
            this.labelminuto.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelminuto.Location = new System.Drawing.Point(231, 73);
            this.labelminuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelminuto.Name = "labelminuto";
            this.labelminuto.Size = new System.Drawing.Size(165, 128);
            this.labelminuto.TabIndex = 2;
            this.labelminuto.Text = "00";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(375, 59);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 128);
            this.label.TabIndex = 3;
            this.label.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "horas";
            // 
            // labelsegundo
            // 
            this.labelsegundo.AutoSize = true;
            this.labelsegundo.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsegundo.Location = new System.Drawing.Point(429, 73);
            this.labelsegundo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelsegundo.Name = "labelsegundo";
            this.labelsegundo.Size = new System.Drawing.Size(165, 128);
            this.labelsegundo.TabIndex = 5;
            this.labelsegundo.Text = "00";
            // 
            // cmbxhora
            // 
            this.cmbxhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbxhora.FormattingEnabled = true;
            this.cmbxhora.Location = new System.Drawing.Point(78, 222);
            this.cmbxhora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbxhora.Name = "cmbxhora";
            this.cmbxhora.Size = new System.Drawing.Size(116, 45);
            this.cmbxhora.TabIndex = 6;
            this.cmbxhora.SelectedIndexChanged += new System.EventHandler(this.cmbxhora_SelectedIndexChanged);
            // 
            // cmbxminuto
            // 
            this.cmbxminuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbxminuto.FormattingEnabled = true;
            this.cmbxminuto.Location = new System.Drawing.Point(253, 222);
            this.cmbxminuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbxminuto.Name = "cmbxminuto";
            this.cmbxminuto.Size = new System.Drawing.Size(116, 45);
            this.cmbxminuto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "minutos";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncancelar.Location = new System.Drawing.Point(78, 411);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(128, 48);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = " Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btniniciar.Location = new System.Drawing.Point(397, 221);
            this.btniniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(163, 46);
            this.btniniciar.TabIndex = 10;
            this.btniniciar.Text = "Ativar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            // 
            // btntoclose
            // 
            this.btntoclose.BackColor = System.Drawing.Color.MintCream;
            this.btntoclose.Location = new System.Drawing.Point(567, 18);
            this.btntoclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntoclose.Name = "btntoclose";
            this.btntoclose.Size = new System.Drawing.Size(62, 35);
            this.btntoclose.TabIndex = 11;
            this.btntoclose.Text = "X";
            this.btntoclose.UseVisualStyleBackColor = false;
            this.btntoclose.Click += new System.EventHandler(this.btntoclose_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(207, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(78, 297);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(482, 84);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(646, 502);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntoclose);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxminuto);
            this.Controls.Add(this.cmbxhora);
            this.Controls.Add(this.labelsegundo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelminuto);
            this.Controls.Add(this.labeldoispontos);
            this.Controls.Add(this.labelhora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelhora;
        private System.Windows.Forms.Label labeldoispontos;
        private System.Windows.Forms.Label labelminuto;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelsegundo;
        private System.Windows.Forms.ComboBox cmbxhora;
        private System.Windows.Forms.ComboBox cmbxminuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btntoclose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

