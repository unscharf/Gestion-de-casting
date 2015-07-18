using Casting.Pwd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting
{
    public partial class Login : Form
    {
      
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("¿Desea abrir un nuevo formularios\n"
            +"de recuperación de contraseña?","Información",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {

                return;
            }
            else {

                Recuperacion1 r = new Recuperacion1();
                this.Hide();
                r.Show();
                
            
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Entrar(this, textBox1, textBox2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Entrar(this, textBox1, textBox2);
        }
    }
}
