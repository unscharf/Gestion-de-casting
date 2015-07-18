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
    public partial class DetallesRepresentante : Form
    {
        MetodosRepresentante m;
        DetallesCandidato dCand;
        int Id;
        

        public DetallesRepresentante(int Id, DetallesCandidato dCand)
        {
            InitializeComponent();
            this.Id = Id;
            this.dCand = dCand;

        }//Constructor parametrizado

        public DetallesRepresentante() { }//Constructor no parametrizado

        private void DetallesRepresentante_Load(object sender, EventArgs e)
        {
            txEnabledFalse();
            txId.Enabled = false;
            m = new MetodosRepresentante();
            m.DetallesRepresentante(Id, txId, nombre, apellido, dir, tel, ced);
            
            
        }

        public void txEnabledFalse()
        {   
            nombre.Enabled = false;
            apellido.Enabled = false;
            dir.Enabled = false;
            tel.Enabled = false;
            ced.Enabled = false;
        }

/******************************************Checks**********************************************/
        private void checkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNombre.Checked == true) { nombre.Enabled = true; }
            else if (checkNombre.Checked == false) { nombre.Enabled = false; }
        }

        private void checkApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (checkApellido.Checked == true) { apellido.Enabled = true; }
            else if (checkApellido.Checked == false) { apellido.Enabled = false; }
        }

        private void checkDir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDir.Checked == true) { dir.Enabled = true; }
            else if (checkDir.Checked == false) { dir.Enabled = false; }
        }

        private void checkTel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTel.Checked == true) { tel.Enabled = true; }
            else if (checkTel.Checked == false) { tel.Enabled = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdRep = Convert.ToInt32(txId.Text);
            MetodosRepresentante m = new MetodosRepresentante();
            if (nombre.Text.Length == 0 || apellido.Text.Length == 0 || dir.Text.Length == 0 || tel.Text.Length == 0)
            {
                MessageBox.Show("Complete los campos y luego actualice", "");

            }
            else
            {  
                m.ActualizarRepresentante(IdRep, nombre.Text, apellido.Text, dir.Text, tel.Text);
                this.Dispose();
            }
        }
/****************************************************************************************************/

    }
}
