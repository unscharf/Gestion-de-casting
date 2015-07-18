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
    public partial class GuardarTutor : Form
    {
        String nombreParametro;
        String apellidoParametro;
        String dirParametro;
        String NacParametro;
        Candidato Cand;
        Image Foto;
        MetodosComunes mc;


        public GuardarTutor(String nombreParametro, String apellidoParametro, String dirParametro, String NacParametro, Image Foto, Candidato Cand)
        {
            InitializeComponent();
            this.nombreParametro = nombreParametro;
            this.apellidoParametro = apellidoParametro;
            this.dirParametro = dirParametro;
            this.NacParametro = NacParametro;
            this.Foto = Foto;
            this.Cand = Cand;

            nombreNin.Enabled = false;
            apellidoNin.Enabled = false;
            dirNin.Enabled = false;
            fechaNac.Enabled = false;

            
            
        }

        public GuardarTutor() { }

        private void GuardarTutor_Load(object sender, EventArgs e)
        {
            nombreNin.Text = nombreParametro;
            apellidoNin.Text = apellidoParametro;
            dirNin.Text = dirParametro;
            fechaNac.Text = NacParametro;
            pictureBox1.Image = Foto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image Foto;
         
            if(nombre.Text.Length==0 || apellido.Text.Length==0 || ced.Text.Trim().Length<16 || dir.Text.Length==0){
                MessageBox.Show("Complete la información del tutor antes de regitrar","Información");
            }else{
            string query = "Select *From Candidatos where nombre='" + nombreNin.Text
                + "' AND apellido= '"+apellidoNin.Text+"' AND dir='"+dirNin.Text
                +"' AND fecha_nac= '"+fechaNac.Text+"' AND Tipo='Niño'";
            
            mc = new MetodosComunes();
            mc.GuardarTutor(nombre.Text, apellido.Text, ced.Text, dir.Text, tel.Text, query);
            this.Dispose();
            


            Candidato cand = new Candidato();
            Camara cam = new Camara("", "", "", "", "", "", "", 0,"", "", "", "", "",cand);

            Foto = cam.Captura.Image;
            Candidato c = new Candidato(Foto, cam, "", "", "", "", "", "","", -1, "", "","","", "");
            c.MdiParent = this.MdiParent;
            c.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea limpiar toda la información de los campos del Padre/Tutor? ", "Advertencia",
              MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            else
            {   mc = new MetodosComunes();
                mc.LimpiarCampos(nombre, apellido, dir);
                ced.Clear();
                tel.Clear();
            }//END IF
        }
        }
}
