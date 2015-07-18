using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Casting
{
    public partial class Camara : Form
    {

        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoVideo;
        private VideoCaptureDevice FuenteVideo = null;
        private bool Foto = false;
        String Name;
        String Apellido;
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
        int CbxIndex;
        Candidato C;
        /*************Objetos*********************/
        public Camara(String Name, String Apellido, String Fecha_nac, String Tel, String Dir, String Tipo, String Ced, int CbxIndex, String Exp, String Sexo, String Proced, String Cpe, String Cjs, Candidato C)
        {
            InitializeComponent();
            BuscarDispositivos();
            this.Name = Name;
            this.Apellido = Apellido;
            this.Fecha_nac = Fecha_nac;
            this.Tel = Tel;
            this.Dir = Dir;
            this.Tipo = Tipo;
            this.Ced = Ced;
            this.C = C;
            this.CbxIndex = CbxIndex;
            this.Exp = Exp;
            this.Sexo = Sexo;
            this.Proced = Proced;
            this.Cpe = Cpe;
            this.Cjs = Cjs;
        }//Constructor parametrizado
        public Camara() { }//Constructor sin parámetros

        private void Camara_Load(object sender, EventArgs e)
        {
            
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;
            cbxDispositivo.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivo.Items[0].ToString();
        }//

        public void BuscarDispositivos()
        {
            DispositivoVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoVideo.Count == 0) { ExisteDispositivo = false; }
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoVideo);
               
            }//Condición de carga
        }//

        public void TerminarFuente()
        {
            if (!(FuenteVideo == null))
            {
                if (FuenteVideo.IsRunning)
                {
                    FuenteVideo.SignalToStop();
                    FuenteVideo = null;
                    MessageBox.Show("Apagando dispostivo", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }//Apagando Cámara


        public void VideoNuevo(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            EspacioCamara.Image = Imagen;
        }//

        private void Capturar()
        {
            try
            {
                if (FuenteVideo.IsRunning)
                {
                    Captura.Image = EspacioCamara.Image;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado cámara encendida", "Ups...",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }   
            }catch (Exception ex) { MessageBox.Show("No se ha detectado ninguna camara todavía\n"
                +"Encienda un dispositivo e intentelo de nuevo\n"+ex.Message,"Ups...", MessageBoxButtons.OK, MessageBoxIcon.Question); }
                //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Capturar();
            Foto = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {  try{
                if (btnIniciar.Text == "Encender")
                {
                    if (ExisteDispositivo)
                    {
                        FuenteVideo = new VideoCaptureDevice(DispositivoVideo[cbxDispositivo.SelectedIndex].MonikerString);
                        FuenteVideo.NewFrame += new NewFrameEventHandler(VideoNuevo);
                        FuenteVideo.Start();

                        btnIniciar.Text = "Detener";
                        cbxDispositivo.Enabled = false;
                        groupBox1.Text = DispositivoVideo[cbxDispositivo.SelectedIndex].Name.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sin dispositivos");
                    }//Else Dispositivo Existe

                }
                else if (FuenteVideo.IsRunning)
                {       TerminarFuente();
                        btnIniciar.Text = "Iniciar";
                        cbxDispositivo.Enabled = true;
                        Dispose();
                    
                }//Else botón detener
            }
            catch { MessageBox.Show("Seleccione primero un dispositivo de cámara", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           SenderImage();
           TerminarFuente();
         
         }


        public void SenderImage()
        {   Candidato c = new Candidato(Captura.Image, this, Name, Apellido, Fecha_nac, Tel, Dir, Tipo, Ced, CbxIndex, Exp, Sexo, Proced, Cpe, Cjs );
            c.pictureBox1.Refresh();
            c.MdiParent = this.MdiParent;
            c.Show();
            
            this.Dispose();
            
        }//Redirigiendo información a Ventana Candidato

        private void Captura_Click(object sender, EventArgs e)
        {

        }

        private void EspacioCamara_Click(object sender, EventArgs e)
        {
            Capturar();
            Foto = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
