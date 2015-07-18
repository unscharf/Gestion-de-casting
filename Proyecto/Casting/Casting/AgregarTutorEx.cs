using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting.Repositorio
{
    public partial class AgregarTutorEx : Form
    {
        int idCand;
        VerCandidatos c;
        public AgregarTutorEx(int idCand, VerCandidatos c)
        {
            InitializeComponent();
            this.idCand = idCand;
            this.c = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombre.Text.Length == 0 || apellido.Text.Length == 0 || ced.Text.Trim().Length < 16 || dir.Text.Length == 0)
            {
                MessageBox.Show("Complete la información del tutor antes de regitrar", "Información");
            }
            else
            {
                MetodosComunes m = new MetodosComunes();
                m.GuardarTutorEx(idCand, nombre.Text, apellido.Text, ced.Text, dir.Text, tel.Text);
                this.Hide();
            }


        }
    }
}
