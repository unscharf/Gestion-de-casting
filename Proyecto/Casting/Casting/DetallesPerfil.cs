using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Casting
{
    public partial class DetallesPerfil : Form
    {
        int IdCandidato;
        VerPerfiles v;

        public DetallesPerfil(int IdCandidato, VerPerfiles v)
        {
            InitializeComponent();
            this.IdCandidato = IdCandidato;
            this.v = v;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerPerfiles vp = new VerPerfiles();
            vp.MdiParent = this.MdiParent;
            vp.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "Select *From Rep_cand where Fk_candidato=" + IdCandidato;
                SqlConnection con = new SqlConnection(CadCon.Servidor());
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);

                int row = dt.Rows.Count;
                if (row == 0)
                {
                    MessageBox.Show("Este candidato no tiene ningún representante registrado."
                    + "\nPuede agregar información de un representante dirigiendose a:"
                    + "\nCandidatos/Ver todos, en la ventana principal", "Nada que mostrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DetallesRep details = new DetallesRep(IdCandidato, this);
                    details.Show();
                }

                cmd.Dispose();
                con.Close();
            }
            catch (SqlException sx) { MessageBox.Show(sx.Message, "Ups..."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DetallesPerfil_Load(object sender, EventArgs e)
        {
            MetodosPerfiles m = new MetodosPerfiles();
            m.DetallesPerfiles(IdCandidato, txnombre, txapellido, txtipo, txtFechaNac, txdir, maskedTextBox1, mtxCed, txproced, txSexo, espc, txCpe, txCdo, pictureBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            String dir = "";
            int rand = r.Next(10000, 99999);
             FolderBrowserDialog d = new FolderBrowserDialog();
                  
                // d.Filter = "(*.*)|*.*";
                // d.InitialDirectory = "C:";
                // d.Title = "Seleccione donde guardar";
              if (d.ShowDialog() == DialogResult.OK)
                {
                  dir = d.SelectedPath + "/IMG" + rand + ".jpg";
                  pictureBox1.Image.Save(dir);
                 MessageBox.Show("Almacenada en " + d.SelectedPath, 
                 "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Random r = new Random();
            String dir = "";
            int rand = r.Next(10000, 99999);
            FolderBrowserDialog d = new FolderBrowserDialog();

            // d.Filter = "(*.*)|*.*";
            // d.InitialDirectory = "C:";
            // d.Title = "Seleccione donde guardar";
            if (d.ShowDialog() == DialogResult.OK)
            {
                dir = d.SelectedPath + "/IMG" + rand + ".jpg";
                pictureBox1.Image.Save(dir);
                MessageBox.Show("Almacenada en " + d.SelectedPath,
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//

        }//
    }
}
