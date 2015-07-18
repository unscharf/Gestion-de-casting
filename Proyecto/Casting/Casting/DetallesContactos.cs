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
    public partial class DetallesContactos : Form
    {
        int id;
        DataCliente dc;


        public DetallesContactos(int id, DataCliente dc)
        {
            InitializeComponent();
            this.id = id;
            this.dc = dc;
            MostrarClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void MostrarClientes()
        {
            try
            {
                SqlConnection Coneccion = new SqlConnection(CadCon.Servidor());
                Coneccion.Open();
                SqlCommand Command = new SqlCommand("ListaClientes", Coneccion);
                Command.Parameters.AddWithValue("@fk_contacto", id);

                Command.CommandType = System.Data.CommandType.StoredProcedure;


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
        }

        private void DetallesContactos_Load(object sender, EventArgs e)
        {

        }
    }
}
