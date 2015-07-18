using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting.Pwd
{
    public partial class Recuperacion1 : Form
    {
        Login log;
        public Recuperacion1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosPwd m = new MetodosPwd();
            
            Recuperacion2 r = new Recuperacion2(textBox1.Text, this);
            if (m.BuscarUsuario(this, textBox1.Text) == false)
            {
                textBox1.Focus();
            }
            else
            {
                r.Show();
            }
         
            
        }//

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            log = new Login();
            log.Show();
            
        }

        private void Recuperacion1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
            }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length <1 || textBox1.Text.Length<= 4)
            {
                label2.Text = "No parece ser un nombre de usuario válido";
                label2.ForeColor = Color.DarkRed;
                label2.Visible = true;
            }
            else if (textBox1.Text.Length > 4)
            {
                label2.Text = "";
                label2.ForeColor = Color.DarkRed;
                label2.Visible = false;

            }

        }//


        }
    }

