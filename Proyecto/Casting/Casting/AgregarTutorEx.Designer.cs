namespace Casting.Repositorio
{
    partial class AgregarTutorEx
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ced = new System.Windows.Forms.MaskedTextBox();
            this.tel = new System.Windows.Forms.MaskedTextBox();
            this.dir = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.ced);
            this.groupBox2.Controls.Add(this.tel);
            this.groupBox2.Controls.Add(this.dir);
            this.groupBox2.Controls.Add(this.apellido);
            this.groupBox2.Controls.Add(this.nombre);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(34, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Padre/Tutor";
            // 
            // ced
            // 
            this.ced.Location = new System.Drawing.Point(120, 79);
            this.ced.Mask = "000-000000-0000L";
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(117, 20);
            this.ced.TabIndex = 10;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(120, 135);
            this.tel.Mask = "0000-0000";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(117, 20);
            this.tel.TabIndex = 9;
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(120, 105);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(117, 20);
            this.dir.TabIndex = 8;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(120, 51);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(117, 20);
            this.apellido.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(120, 23);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(117, 20);
            this.nombre.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cédula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarTutorEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(336, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AgregarTutorEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox ced;
        private System.Windows.Forms.MaskedTextBox tel;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}