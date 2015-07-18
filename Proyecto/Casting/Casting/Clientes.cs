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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            CargarFalseAst();
            HideAstC();
            MostrarContactos();
        }

        public void CargarFalseAst(){
            ast3.Visible = false;
            ast4.Visible = false;
            ast5.Visible = false;
            ast6.Visible = false;
            ast7.Visible = false;
            ast8.Visible = false;

        }//Esconder Piture Box Clientes

        public void CargarAst()
        {
            ast3.Visible = true;
            ast4.Visible = true;
            ast5.Visible = true;
            ast6.Visible = true;
            ast7.Visible = true;
            ast8.Visible = true;
        }//Mostrar Picture Box Clientes

  
        
        private void Clientes_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            
        }


        public void HideAstC() {
            astC1.Visible = false;
            astC2.Visible = false;
            astC3.Visible = false;
       }//Esconder Picture Box Contactos



        public void Limpiar()
        {
            comboBox2.SelectedIndex=-1;
            textBox3.Clear();
            maskedTextBox3.Clear();
            textBox5.Clear();
        }//Reiniciar Campos Clientes

        public void LimpiarContactosReg()
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }//Reiniciar campos registro Cliente

        public void BuscadorContactosNombre()
        {
            if (textBox9.Text.Trim().Equals(""))
            {
                MostrarContactos();
                return;
            }
            try
            {
                String Finder = "%" + textBox9.Text + "%";
                SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
                Coneccion.Open();
                
                String Query = "BuscarContactoNombre '" + Finder + "'";
                 SqlCommand Command = new SqlCommand(Query, Coneccion);
                
                Command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(Command);
                Data.Fill(dt);

                dataGridView1.DataSource = dt;
                Command.Dispose();
                Coneccion.Close();
            }
            catch
            {
                MessageBox.Show("Error al realizar la operacion");
            }
        }//Buscador SQL SERVER PROCEDURE BuscarContactosNombre


        public void BuscadorContactosApellido()
        {
            if (textBox9.Text.Trim().Equals(""))
            {
                MostrarContactos();
                return;
            }
            try
            {
                String Finder = "%" + textBox9.Text + "%";
                SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
                Coneccion.Open();

                String Query = "BuscarContactoApellido '" + Finder + "'";
                SqlCommand Command = new SqlCommand(Query, Coneccion);
             

                Command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(Command);
                Data.Fill(dt);

                dataGridView1.DataSource = dt;
                Command.Dispose();
                Coneccion.Close();
            }
            catch
            {
                MessageBox.Show("Error al realizar la operacion", "Ups...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscadorContactosCedula()
        {
            if (textBox9.Text.Trim().Equals(""))
            {
                MostrarContactos();
                return;
            }
            try
            {
                String Finder = "%" + textBox9.Text + "%";
                SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
                Coneccion.Open();

                String Query = "BuscarContactoCedula '" + Finder + "'";
                SqlCommand Command = new SqlCommand(Query, Coneccion);


                Command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(Command);
                Data.Fill(dt);

                dataGridView1.DataSource = dt;
                Command.Dispose();
                Coneccion.Close();
            }
            catch
            {
                MessageBox.Show("Error al realizar la operacion");
            }
        }//Buscador SQL SERVER PROCEDURE BuscarContactosCedula


        public void MostrarContactos()
        {
            try
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
            catch
            {

                MessageBox.Show("La aplicación no ha podido establecer una conexión segura con SQL Server", "Error de conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        public void CargarAstC()
        {
            astC1.Visible = true;
            astC2.Visible = true;
            astC3.Visible = true;

        }//PictureBox de contactos


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="" || maskedTextBox1.Text==""){
                MessageBox.Show("Complete todos los campos marcados como obligatorios", "Error al registrar", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarAstC();
            
            }else{

                try
                {
                    SqlConnection sc = new SqlConnection(CadCon.Servidor());
                    sc.Open();

                    SqlCommand s = new SqlCommand("GuardarContacto", sc);
                    s.CommandType = System.Data.CommandType.StoredProcedure;
                    s.Parameters.AddWithValue("@nombre", textBox1.Text);
                    s.Parameters.AddWithValue("@apellido", textBox2.Text);
                    s.Parameters.AddWithValue("@ced", maskedTextBox1.Text);
                    s.Parameters.AddWithValue("@tel", maskedTextBox2.Text);

                    if (s.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show(this, "Almacenado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HideAstC();

                        textBox1.Clear();
                        textBox2.Clear();
                        maskedTextBox1.Clear();
                        maskedTextBox2.Clear();
                    }
                    else { MessageBox.Show(this, "Ups... parece que hay problemas con el servidor"); }

                    MostrarContactos();
                    s.Dispose();
                    sc.Close();

                }
                catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
             
            }
        }/*------------------------------------------------------------------------------------------------------------------*/


        private void Agregar_Click(object sender, EventArgs e)
        {
            DataCliente dc = new DataCliente();

            if (textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == ""
                ) {
                    MessageBox.Show(null,"Debe completar toda la información marcada como obligatoria","Error al registrar", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarAst();
            
            }
            else
            {

                SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
                Coneccion.Open();
                String Query = "SELECT *FROM Contactos_cliente where Pk_contacto=" +textBox4.Text + " AND nombre='" 
                 +textBox6.Text + "' AND apellido='" +textBox7.Text + "' AND ced = '" +textBox8.Text 
                 + "' AND tel='"+maskedTextBox4.Text+"'";
                
                SqlCommand s = new SqlCommand(Query, Coneccion);
                s.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(s);
                Data.Fill(dt);
                int cantCol= dt.Rows.Count;
                if (cantCol == 0)
                {
                    MessageBox.Show("No se encontró la información del contacto indicado\n"
                                   +"Si lo que desea es registrar la información de una nueva persona "
                                   +"de contacto dirgirse a la pestaña Contactos en la parte superior "
                                   +"de la ventana de registro y completar el formulario.",
                                   "Lo sentimos...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int IDContacto = Convert.ToInt32(dt.Rows[0][0].ToString());
          

                SqlCommand Command = new SqlCommand("GuardarClientes", Coneccion);
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@fkContacto", IDContacto);
                Command.Parameters.AddWithValue("@Nombre", textBox3.Text);
                Command.Parameters.AddWithValue("@dir", textBox5.Text);
                Command.Parameters.AddWithValue("@tipo", comboBox2.SelectedItem.ToString());
                Command.Parameters.AddWithValue("@tel", maskedTextBox3.Text);

                int f = Command.ExecuteNonQuery();
                if (f != 0)
                {
                    MessageBox.Show("Almacenado exitosamente", "Cliente almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarFalseAst();
                   
                }

            }
            }//
    
                
        

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
        {

            if(comboBox1.SelectedIndex==0){
                BuscadorContactosNombre();

            }
            else if(comboBox1.SelectedIndex==1){
                BuscadorContactosApellido();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                BuscadorContactosCedula();
            }


        }

        private void button2_Click(object sender, EventArgs e)
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
            textBox4.Text = dataGridView1[0, pos].Value.ToString();
            textBox6.Text = dataGridView1[1, pos].Value.ToString();
            textBox7.Text = dataGridView1[2, pos].Value.ToString();
            textBox8.Text = dataGridView1[3, pos].Value.ToString();
            maskedTextBox4.Text = dataGridView1[4, pos].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que quiere limpiar toda la información del contacto? ", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }
        }//Deshacer Contacto
        
        
        //*********************************************************************************************************//
    }
}
