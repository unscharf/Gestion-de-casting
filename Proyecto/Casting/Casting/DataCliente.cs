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
    public partial class DataCliente : Form
    {
        public DataCliente()
        {
            InitializeComponent();
        }

        private void DataCliente_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            comboBox2.SelectedIndex = 0;
        }


        public void MostrarClientes()
        {
            SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
            Coneccion.Open();
            SqlCommand Command = new SqlCommand("Select *From MostrarClientes", Coneccion);

            //Command.CommandType = System.Data.CommandType.StoredProcedure;

            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(Command);
            Data.Fill(dt);

            dataGridView1.DataSource = dt;

            Command.Dispose();
            Coneccion.Close();
        }

        public void MostrarInactivos()
        {
            SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
            Coneccion.Open();
            SqlCommand Command = new SqlCommand("SELECT *FROM MostrarInactivos", Coneccion);

            //Command.CommandType = System.Data.CommandType.StoredProcedure;

            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(Command);
            Data.Fill(dt);

            dataGridView1.DataSource = dt;

            Command.Dispose();
            Coneccion.Close();
        }



        public void MostrarContacto()
        {
            try
            {
                SqlConnection c = new SqlConnection(CadCon.Servidor());
                c.Open();

                SqlCommand cmd = new SqlCommand("SELECT *FROM MostrarContactos WHERE [Estado]='Activo'", c);
                //Vista MostrarContactos
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd.Dispose();
                c.Close();
            }catch{/**/} 
        }

        public void MostrarContactoInactivo()
        {
            try
            {
                SqlConnection c = new SqlConnection(CadCon.Servidor());
                c.Open();

                SqlCommand cmd = new SqlCommand("SELECT *FROM MostrarContactos WHERE [Estado]='Inactivo'", c);
                //Vista MostrarContactos
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                cmd.Dispose();
                c.Close();
            }
            catch(SqlException sx)
            { MessageBox.Show(sx.ToString()); }
        }



        public void MostrarDatos()
        {
            SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
            Coneccion.Open();
            SqlCommand Command = new SqlCommand("SELECT *FROM Cl_contacto", Coneccion);

            //Command.CommandType = System.Data.CommandType.StoredProcedure;

            Command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(Command);
            Data.Fill(dt);

            dataGridView1.DataSource = dt;

            Command.Dispose();
            Coneccion.Close();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            MostrarClientes();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Nombre del cliente");
            comboBox1.Items.Add("Dirección");
            comboBox1.Items.Add("Tipo de cliente");
            comboBox1.SelectedIndex = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MostrarContacto();
            
            comboBox1.Items.Clear();
         //   
            comboBox1.Items.Add("Nombre del contacto");
            comboBox1.Items.Add("Apellido");
            comboBox1.Items.Add("Cédula");
            comboBox1.SelectedIndex = 0;
            //
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        if (radioButton1.Checked == true)
        {
                int p = 0;

                try
                {
                    p = dataGridView1.CurrentCell.RowIndex;
                }
                catch
                {
                    MessageBox.Show("Primero elija a alguien de la tabla", "Error al desactivar",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (MessageBox.Show("Esta seguro que desea desactivar al cliente " + dataGridView1[1, p].Value, "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                else
                {

                    String estado = dataGridView1[5, p].Value.ToString();

                    if (estado == "Inactivo")
                    {
                        MessageBox.Show("Imposible desactivar porque el cliente " + dataGridView1[1, p].Value + " está actualmente inactivo ", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        SqlConnection sc = new SqlConnection(CadCon.Servidor());
                        sc.Open();
                        SqlCommand comand = new SqlCommand(String.Format("update Clientes set estado='Inactivo' WHERE Pk_cliente='{0}'", dataGridView1[0, p].Value), sc);

                        int act = comand.ExecuteNonQuery();
                        if (act != 0)
                        {
                            MessageBox.Show("Desactivado exitosamente", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarClientes();
                        }
                        else
                        {

                            MessageBox.Show("No se pudo desactivar al cliente", "Error al desactivar");
                        }
                        comand.Dispose();
                        sc.Close();
                    }
                }

        }else if (radioButton2.Checked == true) 
        {
        
       //Falta        
        }
        }//

        private void button3_Click(object sender, EventArgs e)
        {
            int p = 0;

            try
            {
                p = dataGridView1.CurrentCell.RowIndex;
            }
            catch
            {
                MessageBox.Show("Primero elija a alguien de la tabla", "Error al reactivar",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (MessageBox.Show("Esta seguro que desea reactivar al cliente " + dataGridView1[1, p].Value, "Advertencia",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                
                return;
                
            }
            else
            {
                String estado=dataGridView1[5, p].Value.ToString();

                if (estado == "Activo")
                {
                    MessageBox.Show("Imposible reactivar porque el cliente " + dataGridView1[1, p].Value + " está actualmente activo ", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    SqlConnection sc = new SqlConnection(CadCon.Servidor());
                    sc.Open();
                    SqlCommand comand = new SqlCommand(String.Format("update Clientes set estado='Activo' WHERE Pk_cliente='{0}'", dataGridView1[0, p].Value), sc);

                    int act = comand.ExecuteNonQuery();
                    if (act != 0)
                    {
                        MessageBox.Show("Reactivado Exitosamente", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo reactivar");
                    }
                    comand.Dispose();
                    sc.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex==0 && radioButton1.Checked==true){

                MostrarClientes();
                button1.Enabled = true;
            }
            else if (comboBox2.SelectedIndex == 1 && radioButton1.Checked == true)
            {
                MostrarInactivos();
                button1.Enabled = false;


            }
            else if (comboBox2.SelectedIndex == 0 && radioButton2.Checked == true)
            {
                MostrarContacto();
                button1.Enabled = true;
            }
            else if (comboBox2.SelectedIndex == 1 && radioButton2.Checked == true)
            {
                MostrarContactoInactivo();
                button1.Enabled = false;
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MostrarClientes();
                return;
            }
            try
            {
                String C = "%" + textBox1.Text + "%";
                SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
                Coneccion.Open();
                String Query = "SELECT *FROM MostrarClientes WHERE [Tipo de Cliente] like'" + C + "'";
                SqlCommand Command = new SqlCommand(Query, Coneccion);

                Command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(Command);
                Data.Fill(dt);

                dataGridView1.DataSource = dt;
                Command.Dispose();
                Coneccion.Close();
            }
            catch(SqlException sx)
            {
                MessageBox.Show("Ha experimentado problemas de conexión: "+sx.ToString(), "Mayday...");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true){
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
                DetallesContactos dcn= new DetallesContactos((int)dataGridView1[0, pos].Value, this);
                dcn.Show();

            }else if (radioButton1.Checked== true){

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

                ActualizarCliente ac = new ActualizarCliente((int)dataGridView1[0, pos].Value, this);
                ac.Show();

            }
        }//


    }
}
