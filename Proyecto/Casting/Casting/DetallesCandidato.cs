using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Casting
{
    public partial class DetallesCandidato : Form
    {
        VerCandidatos V;
        int ID;
        MetodosComunes mc;

        public DetallesCandidato(int ID, VerCandidatos V)
        {
            InitializeComponent();
            this.ID = ID;
            this.V= V;
            comboBox1.SelectedIndex = 0;
        }

        public DetallesCandidato() { }

        private void DetallesCandidato_Load(object sender, EventArgs e)
        {  
            mc = new MetodosComunes();
            textBox6.Text = ID.ToString();
            mc.DetallesCandidato(ID, textBox1, textBox2, textBox3, textBox4, textBox5, maskedTextBox1, maskedTextBox2, pictureBox1);
            textBox6.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            maskedTextBox1.Enabled = false;
            textBox7.Enabled = false;
            maskedTextBox2.Enabled = false;

            String cad = textBox4.Text.Substring(6,4);
            String an = DateTime.Now.ToString();
            String anAct = an.Substring(6,4);
            int nac = Convert.ToInt32(cad);
            int a = Convert.ToInt32(anAct);
            int edad = a - nac;

            textBox7.Text = ""+ edad+ " años";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosCandidato g = new MetodosCandidato();
            g.ActualizarCand(ID, textBox1.Text, textBox2.Text, textBox5.Text, maskedTextBox1.Text, comboBox1.SelectedItem.ToString(), pictureBox1);
            mc = new MetodosComunes();
            mc.DetallesCandidato(ID, textBox1, textBox2, textBox3, textBox4, textBox5, maskedTextBox1, maskedTextBox2, pictureBox1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true){
                textBox5.Enabled = true;
            }
            else { textBox5.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                 maskedTextBox1.Enabled = true;
            }
            else { maskedTextBox1.Enabled = false; }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
              textBox1.Enabled = true;
            }
            else { textBox1.Enabled = false; }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                textBox2.Enabled = true;
            }
            else { textBox2.Enabled = false; }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerCandidatos v = new VerCandidatos();
            v.MdiParent = this.MdiParent;
            v.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="Adulto"){
                MessageBox.Show("Los candidatos adultos no registran\n"
                                 + "información del padre o tutor", "Nada que mostrar",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text == "Niño")
            {
                DetallesTutor dt = new DetallesTutor(ID, this);
                dt.Show();

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "Select *From Rep_cand where Fk_candidato=" + Convert.ToInt32(textBox6.Text) ;
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
                    +"\nPuede agregar información de un representante dirigiendose a:"
                    + "\nCandidatos/Ver todos, en la ventana principal", "Nada que mostrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    DetallesRepresentante details = new DetallesRepresentante(ID, this);
                    details.Show();
                }

                cmd.Dispose();
                con.Close();
            }catch (SqlException sx) { MessageBox.Show(sx.Message, "Ups..."); }
           
        }//

    }
}
