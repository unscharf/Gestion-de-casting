namespace Casting
{
    partial class DetallesRepresentante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesRepresentante));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkTel = new System.Windows.Forms.CheckBox();
            this.checkDir = new System.Windows.Forms.CheckBox();
            this.checkApellido = new System.Windows.Forms.CheckBox();
            this.checkNombre = new System.Windows.Forms.CheckBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(22, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(192, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkTel);
            this.groupBox1.Controls.Add(this.checkDir);
            this.groupBox1.Controls.Add(this.checkApellido);
            this.groupBox1.Controls.Add(this.checkNombre);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Representante";
            // 
            // checkTel
            // 
            this.checkTel.AutoSize = true;
            this.checkTel.Location = new System.Drawing.Point(214, 173);
            this.checkTel.Name = "checkTel";
            this.checkTel.Size = new System.Drawing.Size(53, 17);
            this.checkTel.TabIndex = 13;
            this.checkTel.Text = "Editar";
            this.checkTel.UseVisualStyleBackColor = true;
            this.checkTel.CheckedChanged += new System.EventHandler(this.checkTel_CheckedChanged);
            // 
            // checkDir
            // 
            this.checkDir.AutoSize = true;
            this.checkDir.Location = new System.Drawing.Point(212, 131);
            this.checkDir.Name = "checkDir";
            this.checkDir.Size = new System.Drawing.Size(53, 17);
            this.checkDir.TabIndex = 12;
            this.checkDir.Text = "Editar";
            this.checkDir.UseVisualStyleBackColor = true;
            this.checkDir.CheckedChanged += new System.EventHandler(this.checkDir_CheckedChanged);
            // 
            // checkApellido
            // 
            this.checkApellido.AutoSize = true;
            this.checkApellido.Location = new System.Drawing.Point(212, 92);
            this.checkApellido.Name = "checkApellido";
            this.checkApellido.Size = new System.Drawing.Size(53, 17);
            this.checkApellido.TabIndex = 11;
            this.checkApellido.Text = "Editar";
            this.checkApellido.UseVisualStyleBackColor = true;
            this.checkApellido.CheckedChanged += new System.EventHandler(this.checkApellido_CheckedChanged);
            // 
            // checkNombre
            // 
            this.checkNombre.AutoSize = true;
            this.checkNombre.Location = new System.Drawing.Point(214, 53);
            this.checkNombre.Name = "checkNombre";
            this.checkNombre.Size = new System.Drawing.Size(53, 17);
            this.checkNombre.TabIndex = 10;
            this.checkNombre.Text = "Editar";
            this.checkNombre.UseVisualStyleBackColor = true;
            this.checkNombre.CheckedChanged += new System.EventHandler(this.checkNombre_CheckedChanged);
            // 
            // ced
            // 
            this.ced.Location = new System.Drawing.Point(92, 206);
            this.ced.Mask = "000-000000-0000L";
            this.ced.Name = "ced";
            this.ced.Size = new System.Drawing.Size(114, 20);
            this.ced.TabIndex = 9;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(92, 90);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(114, 20);
            this.apellido.TabIndex = 8;
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(92, 129);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(114, 20);
            this.dir.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teléfono";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(92, 170);
            this.tel.Mask = "0000-0000";
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(114, 20);
            this.tel.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(92, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(114, 20);
            this.nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(92, 20);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(46, 20);
            this.txId.TabIndex = 15;
            // 
            // DetallesRepresentante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetallesRepresentante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles/Editar";
            this.Load += new System.EventHandler(this.DetallesRepresentante_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.CheckBox checkTel;
        private System.Windows.Forms.CheckBox checkDir;
        private System.Windows.Forms.CheckBox checkApellido;
        private System.Windows.Forms.CheckBox checkNombre;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label label6;
    }
}