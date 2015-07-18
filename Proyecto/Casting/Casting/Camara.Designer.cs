namespace Casting
{
    partial class Camara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camara));
            this.EspacioCamara = new System.Windows.Forms.PictureBox();
            this.Captura = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cbxDispositivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Captura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EspacioCamara
            // 
            this.EspacioCamara.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EspacioCamara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EspacioCamara.Image = ((System.Drawing.Image)(resources.GetObject("EspacioCamara.Image")));
            this.EspacioCamara.Location = new System.Drawing.Point(32, 40);
            this.EspacioCamara.Name = "EspacioCamara";
            this.EspacioCamara.Size = new System.Drawing.Size(250, 250);
            this.EspacioCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspacioCamara.TabIndex = 0;
            this.EspacioCamara.TabStop = false;
            this.EspacioCamara.Click += new System.EventHandler(this.EspacioCamara_Click);
            // 
            // Captura
            // 
            this.Captura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Captura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Captura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Captura.Image = ((System.Drawing.Image)(resources.GetObject("Captura.Image")));
            this.Captura.Location = new System.Drawing.Point(311, 40);
            this.Captura.Name = "Captura";
            this.Captura.Size = new System.Drawing.Size(250, 250);
            this.Captura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Captura.TabIndex = 1;
            this.Captura.TabStop = false;
            this.Captura.Click += new System.EventHandler(this.Captura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.cbxDispositivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(461, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 77);
            this.button3.TabIndex = 4;
            this.button3.Text = "Guardar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(380, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 77);
            this.button2.TabIndex = 3;
            this.button2.Text = "Capturar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.Location = new System.Drawing.Point(299, 19);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 77);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Encender";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cbxDispositivo
            // 
            this.cbxDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivo.FormattingEnabled = true;
            this.cbxDispositivo.Location = new System.Drawing.Point(86, 45);
            this.cbxDispositivo.Name = "cbxDispositivo";
            this.cbxDispositivo.Size = new System.Drawing.Size(184, 21);
            this.cbxDispositivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispositivos";
            // 
            // Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Captura);
            this.Controls.Add(this.EspacioCamara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara";
            this.Load += new System.EventHandler(this.Camara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Captura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EspacioCamara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cbxDispositivo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Captura;
    }
}