using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Casting.Reportes;
using Casting.Castings;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes f = new Clientes();
            f.MdiParent = this;
            f.Show();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes f = new Clientes();
            DataCliente dc = new DataCliente();
            dc.MdiParent = this;
            f.Dispose();
            dc.Show();


        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image Foto;
            Candidato cand = new Candidato();
            Camara cam = new Camara("", "" , "", "", "", "", "", 0, "", "", "", "", "", cand);
            
            Foto = cam.Captura.Image;
            Candidato c = new Candidato(Foto, cam, "", "", "", "", "", "", "", -1, "radio4", "", "", "", "");
            c.MdiParent = this;
            c.Show();
        }

        private void castingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verTodosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerCandidatos v = new VerCandidatos();
            v.MdiParent = this;
            v.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPerfiles vp = new VerPerfiles();
            vp.MdiParent = this;
            vp.Show();
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario ed = new EditarUsuario();
            ed.MdiParent = this;
            ed.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContratarCasting c = new ContratarCasting();
            c.MdiParent = this;
            c.Show();
        }

        private void agenteDeCastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agente a = new Agente();
            a.MdiParent = this;
            a.Show();
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            verCastings v = new verCastings();
            v.MdiParent = this;
            v.Show();
        }

        private void agentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarAgente edi = new EditarAgente();
            edi.MdiParent = this;
            edi.Show();
        }

        private void clientesActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesActivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarClienteReport m = new MostrarClienteReport();
            m.MdiParent = this;
            m.Show();
        }

        private void clientesInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarClienteInactivoRep m = new MostrarClienteInactivoRep();
            m.MdiParent = this;
            m.Show();

        }

        private void candidatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarCandidatosRep m = new MostrarCandidatosRep();
            m.MdiParent = this;
            m.Show();
        }

        private void helpCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C://Users//Blutharsch//Documents//Visual Studio 2013//Projects//Casting//AyudaCasting.chm");
        }

        private void agentesDeCastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteAgente r = new ReporteAgente();
            r.MdiParent = this;
            r.Show();
        }

        private void castingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CastingRepViewer crv = new CastingRepViewer();
            crv.MdiParent = this;
            crv.Show();
        }
    }
}
