using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Casting
{
    public partial class Candidato : Form
    {
        Image Foto;
        Camara C;
        String Nombre;
        String Ap;
        String Fecha_nac;
        String Tel;
        String Dir;
        String Tipo;
        String Ced;
        String Exp;
        String Sexo;
        String Proced;
        String Cpe;
        String Cjs;
        int CbxIndexReceived;

        public Candidato(Image Foto, Camara C, String Nombre, String Ap, String Fecha_nac, String Tel, String Dir, String Tipo, String Ced, int CbxIndexReceived, String Exp, String Sexo, String Proced, String Cpe, String Cjs)
        {
            InitializeComponent();
            this.Foto = Foto;
            this.C = C;
            this.Nombre = Nombre;
            this.Ap = Ap;
            this.Fecha_nac = Fecha_nac;
            this.Tel = Tel;
            this.Dir = Dir;
            this.Tipo = Tipo;
            this.Ced = Ced;
            this.CbxIndexReceived = CbxIndexReceived;
            this.Exp = Exp;
            this.Sexo = Sexo;
            this.Proced = Proced;
            this.Cpe = Cpe;
            this.Cjs = Cjs;
        }

        public Candidato() { }
           
        private void button1_Click(object sender, EventArgs e)
        {
            String radio="";
            String radio1="";
            
            if (radioButton3.Checked == true && radioButton1.Checked==true) { 
            radio = "radio3";
            radio1 = "radio1";
            Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
            c.MdiParent = this.MdiParent;
            c.Show();
            this.Dispose();
         
            } else if (radioButton3.Checked == true && radioButton2.Checked == true)
            {   radio = "radio3";
                radio1 = "radio2";
                Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
                c.MdiParent = this.MdiParent;
                c.Show();
                this.Dispose();
            } else if (radioButton4.Checked == true && radioButton1.Checked==true) { 
                
            radio = "radio4";
            radio1 = "radio1";
            Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
            c.MdiParent = this.MdiParent;
            c.Show();
            this.Dispose();
            }
            else if (radioButton4.Checked == true && radioButton2.Checked == true)
            {   radio = "radio4";
                radio1 = "radio2";
                Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
                c.MdiParent = this.MdiParent;
                c.Show();
                this.Dispose();
            }
            else if (radioButton4.Checked == false && radioButton2.Checked ==false)
            {
                Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
                c.MdiParent = this.MdiParent;
                c.Show();
                this.Dispose();
            }
            else if (radioButton4.Checked == true && radioButton2.Checked==false )
            {
                radio = "radio4";
                radio1 = "";
                Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
                c.MdiParent = this.MdiParent;
                c.Show();
                this.Dispose();
            }
            else if (radioButton3.Checked == true && radioButton2.Checked == false)
            {
                radio = "radio3";
                radio1 = "";
                Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
                c.MdiParent = this.MdiParent;
                c.Show();
                this.Dispose();
            }
            else if (radioButton2.Checked == true && radioButton3.Checked == false)
            {
                radio = "";
                radio1 = "radio2";
                Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
                c.MdiParent = this.MdiParent;
                c.Show();
                this.Dispose();
            }
            else if (radioButton1.Checked == true && radioButton3.Checked == false)
            {
                radio = "";
                radio1 = "radio1";
                Camara c = new Camara(nombre.Text, apellido.Text, fechaNac.Text, tel.Text, dir.Text, tipo.Text, ced.Text, cbxEspc.SelectedIndex, radio, radio1, procedencia.Text, colorpelo.Text, colorojos.Text, this);
                c.MdiParent = this.MdiParent;
                c.Show();
                this.Dispose();
            }

        }//

        public void Temp()
        {
            nombre.Text = Nombre;
            apellido.Text = Ap;
            fechaNac.Text = Fecha_nac;
            tel.Text = Tel;
            dir.Text = Dir;
            tipo.Text = Tipo;
            ced.Text = Ced;
            cbxEspc.SelectedIndex = CbxIndexReceived;
            procedencia.Text = Proced;
            colorpelo.SelectedItem = Cpe;
            colorojos.SelectedItem = Cjs;


            if (Exp == "radio3" && Sexo=="radio1") { 
                radioButton3.Checked = true;
                radioButton1.Checked = true;
 
            } else if (Exp == "radio4" && Sexo== "radio1") { 
                radioButton4.Checked = true;
                radioButton1.Checked = true;
            }
            else if (Exp == "radio3" && Sexo == "radio2")
            {
                radioButton3.Checked = true;
                radioButton2.Checked = true;
            }
            else if (Exp == "radio4" && Sexo == "radio2")
            {
                radioButton4.Checked = true;
                radioButton2.Checked = true;
            }
            else if (Exp == "radio4" && Sexo == "")
            {
                radioButton4.Checked = true;
                
                radioButton1.Checked = false;
            }
            else if (Exp == "radio3" && Sexo == "")
            {
                radioButton3.Checked = true;
            
                radioButton1.Checked = false;
            }
            else if (Exp == "" && Sexo == "radio2")
            {
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton2.Checked = true;
          
            }
            else if (Exp == "" && Sexo == "radio1")
            {
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton1.Checked = true;
            }

            else if (Exp == "" && Sexo == "")
            {
                radioButton4.Checked = false;
                radioButton3.Checked = false;
                radioButton2.Checked = false;
                radioButton1.Checked = false;
            }


        }//

        private void Candidato_Load(object sender, EventArgs e)
        {
            CargarFoto();
            Temp();
            tipo.Enabled = false;
            button6.Enabled = false;
            if (tipo.Text == "Adulto") { ced.Enabled = true; } else { ced.Enabled = false; }
        }

        public void CargarFoto() {
            pictureBox1.Image = Foto;
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.openFileDialog1.ShowDialog();
                this.openFileDialog1.Title = "Seleccione una imagen para la foto de perfil";
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.ToString(), "Recargar la imagen");
            }
        }//Examinar

        private void fechaNac_Leave(object sender, EventArgs e)
        {
            int edad;
            int mes;
            int dia;

            String cpb = fechaNac.Text.Trim();
            try{
                if (cpb.Length==10)
                {
                 String Nac = fechaNac.Text.Substring(6,4);
                 String actual = DateTime.Now.ToString();
                 actual = actual.Substring(6,4);
                 int aNac = Convert.ToInt32(Nac);
                 int aActual = Convert.ToInt32(actual);
                 edad = aActual - aNac;

                 String sbDia = fechaNac.Text.Substring(0, 2);
                 String sbMes = fechaNac.Text.Substring(3,2);
                 dia = Convert.ToInt32(sbDia);
                 mes = Convert.ToInt32(sbMes);

                 if (edad>110) { MessageBox.Show("Ups... la fecha digitada no parece correcta\n"
                     + "¿Y cómo es que sigues vivo?\n"
                     +"¿Seguro que naciste en "+Nac+"?\nRevisa la fecha de nacimiento y vuelve a intentarlo","",
                     MessageBoxButtons.OK, MessageBoxIcon.Question);
                 fechaNac.Focus();
                 }
                 else if (edad <= 0)
                 {
                     MessageBox.Show("Ups... la fecha digitada no parece correcta\n"
                     + "¿Seguro que vienes del futuro?\nRevisa la fecha de nacimiento y vuelve a intentarlo", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Question);
                     fechaNac.Focus();
                 }
                 else{

                     if(dia<=0 || dia>31 || mes>12 || mes<=0){
                         MessageBox.Show("Ups... la fecha digitada no parece correcta\n"
                         + "Revisa la fecha de nacimiento y vuelve a intentarlo", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Question);
                         fechaNac.Focus();
                    }else{
                         if (edad >= 1 && edad <= 17)
                          {
                         tipo.Text = "Niño";
                         ced.Enabled = false;
                         ced.Clear();
                         }else if (edad >= 18 && edad <= 109)
                        {
                         tipo.Text = "Adulto";
                         ced.Enabled = true;

                     }
                   }
                 }//

                }///
                else { MessageBox.Show("Fecha digitada no válida\n El formato para fecha debe ser DD/MM/YYYY");
                fechaNac.Focus();
                }///

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }//Fecha Leave

        private void button3_Click(object sender, EventArgs e)
        {
            if (nombre.Text.Length == 0 || apellido.Text.Length == 0 || fechaNac.Text.Trim().Length<10 || dir.Text.Length==0)
            {
                MessageBox.Show("Complete los campos obligatorios");
            }
            else if (cbxEspc.SelectedIndex == -1 || procedencia.Text.Length == 0 || colorpelo.SelectedIndex == -1 || colorojos.SelectedIndex==-1 || (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                MessageBox.Show("Complete la información del perfil", "Información");

            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Debe cargar una foto al perfil", "Información");
            }
            else
            {
                if (tipo.Text == "Adulto" && ced.Text.Length == 0)
                {
                    MessageBox.Show("Digite la información de la cédula", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tipo.Text == "Niño")
                {
                    try

                    {
                        int experiencia = 1;
                        string s = "";

                        if (radioButton3.Checked == true) { experiencia = 1; }
                        else
                            if (radioButton4.Checked == true) { experiencia = 0; }

                        if (radioButton1.Checked == true) { s = "Masculino"; }
                        else
                            if (radioButton2.Checked == true) { s = "Femenino"; }

                    MetodosCandidato g = new MetodosCandidato();
                    MessageBox.Show(g.InsertarCandidato(nombre.Text, apellido.Text, dir.Text, tel.Text, tipo.Text, fechaNac.Text, procedencia.Text, s, cbxEspc.SelectedItem.ToString(), colorpelo.SelectedItem.ToString(), colorojos.SelectedItem.ToString(), experiencia, pictureBox1));

                    MessageBox.Show("Recuerde registrar al padre/tutor del niño\n"
                            + "De manera obligatoria cada niño tiene que registrar\n"
                            +"la información del padre o tutor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button6.Enabled = true;
                        nombre.Enabled = false;
                        apellido.Enabled = false;
                        fechaNac.Enabled = false;
                        dir.Enabled = false;
                        tel.Enabled = false;
                        tipo.Enabled = false;
                        cbxEspc.Enabled = false;
                        procedencia.Enabled = false;
                        colorpelo.Enabled = false;
                        colorojos.Enabled = false;
                        radioButton1.Enabled = false;
                        radioButton2.Enabled = false;
                        radioButton3.Enabled = false;
                        radioButton4.Enabled = false;

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }

                }
                else if (tipo.Text == "Adulto" && ced.Text.Length != 0)
                {
                    try
                    {

                        int experiencia = 1;
                        string s = "";

                        MetodosCandidato g = new MetodosCandidato();
                        MetodosComunes mc = new MetodosComunes();

                        if (radioButton3.Checked == true) { experiencia = 1; }
                        else
                            if (radioButton4.Checked == true) { experiencia = 0; }

                        if (radioButton1.Checked == true) { s = "Masculino"; }
                        else
                            if (radioButton2.Checked == true) { s = "Femenino"; }

                        MessageBox.Show(g.InsertarCandidatoAdulto(nombre.Text, apellido.Text, dir.Text, tel.Text, tipo.Text, fechaNac.Text, ced.Text, procedencia.Text, s, cbxEspc.SelectedItem.ToString(), colorpelo.SelectedItem.ToString(), colorojos.SelectedItem.ToString(), experiencia, pictureBox1), "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mc.LimpiarCampos(nombre, apellido, dir);
                        colorpelo.SelectedIndex = -1;
                        colorojos.SelectedIndex = -1;
                        procedencia.Clear();
                        cbxEspc.SelectedIndex = -1;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = true;

                        tipo.Clear();
                        tel.Clear();
                        ced.Clear();
                        fechaNac.Clear();
                        pictureBox1.Image = null;

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.Message); }

                }//if abstracto
            }//if principal del botón
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (nombre.Text.Length == 0 || apellido.Text.Length == 0 || fechaNac.Text.Trim().Length < 10 || dir.Text.Length == 0)
            {
                MessageBox.Show("Complete la información los campos obligatorios", "Imposible guardar");
            }else
            {
                if (tipo.Text == "Niño")
                {
                    GuardarTutor st = new GuardarTutor(nombre.Text, apellido.Text, dir.Text, fechaNac.Text, pictureBox1.Image, this);
                    st.MdiParent = this.MdiParent;
                    st.Show();
                    this.Dispose();
                }
                else { MessageBox.Show("El candidato no es niño"); }
            }
        }//botón registrar

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea limpiar toda la información de los campos? ","Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            else
            {
                MetodosComunes mc = new MetodosComunes();
                mc.LimpiarCampos(nombre, apellido, dir);
                colorpelo.SelectedIndex = -1;
                cbxEspc.SelectedIndex = -1;
                colorojos.SelectedIndex = -1;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = true;

                tipo.Clear();
                tel.Clear();
                ced.Clear();
                fechaNac.Clear();
               
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void ced_Leave(object sender, EventArgs e)
        {
            String sbDia = fechaNac.Text.Substring(0, 2);
            String dia = ced.Text.Substring(4,2);
            String sbMes = fechaNac.Text.Substring(3, 2);
            String Mes = ced.Text.Substring(6, 2);
            String sbAnio = fechaNac.Text.Substring(8,2);
            String Anio = ced.Text.Substring(8, 2);
            try
            {
                if (Convert.ToInt32(sbDia) != Convert.ToInt32(dia))
                {
                    MessageBox.Show("El dia de la fecha de nacimiento y la información de la cédula no coinciden", "Cédula no válida");
                }

                else if (Convert.ToInt32(sbMes) != Convert.ToInt32(Mes))
                {
                    MessageBox.Show("El mes de la fecha de nacimiento y la información de la cédula no coinciden", "Cédula no válida");
                }

                else if (Convert.ToInt32(sbAnio) != Convert.ToInt32(Anio))
                {
                    MessageBox.Show("El año de la fecha de nacimiento y la información de la cédula no coinciden", "Cédula no válida");
                }
            }
            catch (NullReferenceException n) { MessageBox.Show(n.ToString()); }

           
        }//

    }//
}