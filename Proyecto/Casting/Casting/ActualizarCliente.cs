using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Casting
{
    public partial class ActualizarCliente : Form
    {
        int ID;
        DataCliente dc;
        public ActualizarCliente(int ID, DataCliente dc)
        {
            InitializeComponent();
            this.ID = ID;
            this.dc = dc;
            MostrarContactos();
            InfoTextBox();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            maskedTextBox1.Enabled = false;

        }

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        public void MostrarContactos()
        {
            SqlConnection c = new SqlConnection(CadCon.Servidor());
            c.Open();

            SqlCommand cmd = new SqlCommand("SELECT *FROM MostrarContactos WHERE [Estado]='Activo'", c);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.Dispose();
            c.Close();
        }

        public void InfoTextBox()
        {
            DataCliente d = new DataCliente();
            SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
            Coneccion.Open();
            SqlCommand Command = new SqlCommand("CargarDatosActualizar", Coneccion);
            Command.Parameters.AddWithValue("@Pk_cliente", ID);

            Command.CommandType = System.Data.CommandType.StoredProcedure;
           
            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(Command);
            Data.Fill(dt);

           /************************************************ */ 
            textBox2.Text= dt.Rows[0][4].ToString();
            textBox3.Text= dt.Rows[0][1].ToString();
            maskedTextBox1.Text= dt.Rows[0][2].ToString();
            textBox4.Text= dt.Rows[0][3].ToString();
          /************************************************ */

            textBox5.Text= dt.Rows[0][5].ToString();
            textBox6.Text = dt.Rows[0][6].ToString();
            textBox7.Text = dt.Rows[0][7].ToString();
            textBox8.Text = dt.Rows[0][8].ToString();
          
            Command.Dispose();
            Coneccion.Close();
        }


        public void ContactoPredeterminado()
        {
            DataCliente d = new DataCliente();
            SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
            Coneccion.Open();
            SqlCommand Command = new SqlCommand("CargarDatosActualizar", Coneccion);
            Command.Parameters.AddWithValue("@Pk_cliente", ID);

            Command.CommandType = System.Data.CommandType.StoredProcedure;

            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(Command);
            Data.Fill(dt);
            textBox5.Text = dt.Rows[0][5].ToString();
            textBox6.Text = dt.Rows[0][6].ToString();
            textBox7.Text = dt.Rows[0][7].ToString();
            textBox8.Text = dt.Rows[0][8].ToString();

            Command.Dispose();
            Coneccion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos = 0;
            try
            {
                pos = dataGridView1.CurrentCell.RowIndex;
            }
            catch
            {
                MessageBox.Show("Elija a alguien de la tabla");
                return;
            }
            textBox5.Text = dataGridView1[0, pos].Value.ToString();
            textBox6.Text = dataGridView1[1, pos].Value.ToString();
            textBox7.Text = dataGridView1[2, pos].Value.ToString();
            textBox8.Text = dataGridView1[3, pos].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContactoPredeterminado();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked== true){
            maskedTextBox1.Enabled = true;
            } else if (checkBox2.Checked == false) {
                maskedTextBox1.Enabled = false;
            }
        }//

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                textBox4.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                textBox4.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodosComunes m = new MetodosComunes();
            if (m.ActualizarCliente(ID, Convert.ToInt32(textBox5.Text), textBox3.Text, maskedTextBox1.Text, textBox4.Text) == true) {
                DataCliente dc = new DataCliente();
                dc.MostrarClientes();
                this.Dispose();
            }
            else
            {
                return;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked==true)
            {  textBox3.Enabled = true;

            }
            else if (checkBox3.Checked == false) {
                textBox3.Enabled = false;
            }
        }//


    }
}
