namespace Casting
{
    partial class DetallesRep
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ced = new System.Windows.Forms.MaskedTextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.dir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.MaskedTextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ced);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.dir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 256);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Representante";
            // 
            // ced
            // 
            this.ced.Location = new System.Drawing.Point(92, 203);
            this.ced.Mask = "000-000000-0000L";
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(114, 20);
            this.ced.TabIndex = 9;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(92, 93);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(114, 20);
            this.apellido.TabIndex = 8;
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(92, 131);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(114, 20);
            this.dir.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teléfono";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(92, 169);
            this.tel.Mask = "0000-0000";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(114, 20);
            this.tel.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(92, 52);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(114, 20);
            this.nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(92, 21);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(51, 20);
            this.txId.TabIndex = 11;
            // 
            // DetallesRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(306, 314);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetallesRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.DetallesRep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox ced;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tel;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label label6;
    }
}