using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using Casting.Castings;
using System.Threading.Tasks;
using Casting.Repositorio;
using System.Windows.Forms;

namespace Casting
{
    public partial class VerCandidatos : Form
    {
        public VerCandidatos()
        {
            InitializeComponent();
        }

        private void VerCandidatos_Load(object sender, EventArgs e)
        {
            MetodosComunes mc = new MetodosComunes();
            mc.MostrarCandidatos(dataGridView1);
        }

        private void Detalles_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                DetallesCandidato dcn = new DetallesCandidato((int)dataGridView1[0, pos].Value, this);
                dcn.MdiParent = this.MdiParent;
                dcn.Show();
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Elija a alguien de la tabla");
                return;
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                DetallesCandidato dcn = new DetallesCandidato((int)dataGridView1[0, pos].Value, this);
                dcn.MdiParent = this.MdiParent;
                dcn.Show();
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Elija a alguien de la tabla");
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                string query = "Select *From Rep_cand where Fk_candidato="+(int)dataGridView1[0, pos].Value;
                SqlConnection con = new SqlConnection(CadCon.Servidor());
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int cantCol = dt.Rows.Count;
                if (cantCol == 0)
                {
                    if (MessageBox.Show("No se encontró información del representante de este candidato\n Desea agregarla?","",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        { return;  }else{ //new// 
                        GuardarRepresentantes rep = new GuardarRepresentantes((int)dataGridView1[0, pos].Value, this);
                        rep.MdiParent = this.MdiParent;
                        rep.Show();
                   
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe información del representante de este candidato\n"
                                    +"Puede editar la información de este candidato clickendo en\n"
                                    +"el botón Detalles.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                con.Close();
                cmd.Dispose();
            }//END TRY
            catch
            {
                MessageBox.Show("Primero seleccione a alguien de la tabla");
                return;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(CadCon.Servidor());
            con.Open();
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
                if ((dataGridView1[3, pos].Value).ToString().Equals("Adulto"))
                {
                    MessageBox.Show("Los candidatos adultos no registran información del padre/tutor", "Lo sentimos");
                }
                else
                {

                string query = "Select *From Tutores where Fk_candidato=" + (int)dataGridView1[0, pos].Value;
               
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int cantCol = dt.Rows.Count;
                if (cantCol == 0)
                {
                    if (MessageBox.Show("No se encontró información del padre/tutor de este candidato\n Desea agregarla?", "",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    { return; }
                    else
                    { //new// 
                        AgregarTutorEx at = new AgregarTutorEx((int)dataGridView1[0, pos].Value, this);
                        at.MdiParent = this.MdiParent;
                        at.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe información del tutor de este candidato\n"
                                    + "Puede editar la información de este candidato clickendo en\n"
                                    + "el botón Detalles.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                con.Close();

            }//END TRY
            catch
            {
                MessageBox.Show("Primero seleccione a alguien de la tabla");
                return;
            }


        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
              MetodosComunes  m = new MetodosComunes();
              m.MostrarCandidatos(dataGridView1);
                return;
            }
            else
            {
                String Cad = "%" + textBox1.Text + "%";
                if (comboBox1.SelectedIndex == 0)
                {
                   String query = "Select Pk_candidato as 'ID', nombre as 'Nombre', apellido as 'Apellido', tipo as 'Tipo', "
                   + "tel as 'Teléfono', dir as 'Dirección', fecha_nac as 'Fecha de nacimiento', Estado as 'Estado' FROM Candidatos"
                   + " WHERE nombre like '"+Cad+"'";

                   MetodosNav nav = new MetodosNav();
                   nav.Buscar(query, dataGridView1);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                   String query = "Select Pk_candidato as 'ID', nombre as 'Nombre', apellido as 'Apellido', tipo as 'Tipo', "
                   + "tel as 'Teléfono', dir as 'Dirección', fecha_nac as 'Fecha de nacimiento', Estado as 'Estado' FROM Candidatos"
                   + " WHERE apellido like '" + Cad + "'";

                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    String query = "Select Pk_candidato as 'ID', nombre as 'Nombre', apellido as 'Apellido', tipo as 'Tipo', "
                    + "tel as 'Teléfono', dir as 'Dirección', fecha_nac as 'Fecha de nacimiento', Estado as 'Estado' FROM Candidatos"
                    + " WHERE tipo like '" + Cad + "'";

                    MetodosNav nav = new MetodosNav();
                    nav.Buscar(query, dataGridView1);

                }
            }


        }///**********************///
    }
}
