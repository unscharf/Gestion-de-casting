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
    public partial class DetallesRep : Form
    {
        int Id;
        DetallesPerfil d;
        
        public DetallesRep(int Id, DetallesPerfil d)
        {
            InitializeComponent();
            this.Id = Id;
            this.d = d;
        }

        private void DetallesRep_Load(object sender, EventArgs e)
        {
           MetodosRepresentante m = new MetodosRepresentante();
            m.DetallesRepresentante(Id, txId, nombre, apellido, dir, tel, ced);
            txId.Enabled = false;
            nombre.Enabled = false;
            apellido.Enabled = false;
            dir.Enabled = false;
            tel.Enabled = false;
            ced.Enabled = false;
        }
    }
}
