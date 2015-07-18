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
    public partial class GuardarRepresentantes : Form
    {
        int Id;
        VerCandidatos Cand;

        public GuardarRepresentantes(int Id, VerCandidatos Cand)
        {
            InitializeComponent();
            this.Id = Id;
            this.Cand = Cand;

        }

        public GuardarRepresentantes() { }

        private void Representantes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosRepresentante r = new MetodosRepresentante();
            r.AgregarRep(Id, ced.Text,nombre.Text, apellido.Text, dir.Text, tel.Text);

        }
    }
}
