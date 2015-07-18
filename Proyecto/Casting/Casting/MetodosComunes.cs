using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Casting
{
    class MetodosComunes
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;
        DataRow dr;
        DataSet ds;

        public void LimpiarCampos(TextBox Campo1, TextBox Campo2, TextBox Campo3)
        {
            Campo1.Clear();
            Campo2.Clear();
            Campo3.Clear();

        }

        public void GuardarTutor(string nombre, string apellido, string ced, string dir, string tel, string query)
        { 
            try
            {
                cn = new SqlConnection(CadCon.Servidor());
                cn.Open();
                cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();

                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                int cantCol = dt.Rows.Count;
                if (cantCol == 0)
                {
                    MessageBox.Show("No se encontró la información del candidato indicado", "ERROR AL PROCESAR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    int ID = Convert.ToInt32(dt.Rows[0][0].ToString());


                    cmd = new SqlCommand("GuardarTutor", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fkcandidato", ID);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@ced", ced);
                    cmd.Parameters.AddWithValue("@dir", dir);
                    cmd.Parameters.AddWithValue("@tel", tel);

                    int f = cmd.ExecuteNonQuery();
                    if (f != 0)
                    {
                        MessageBox.Show("Almacenado exitosamente", "Tutor almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.Dispose();
                        cn.Close();
                    }//KMN

                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }

          
        }//Almacenar en la base de datos Tabla Tutor

        public void GuardarTutorEx(int IdCand, string nombre, string apellido, string ced, string dir, string tel)
        {

            try
            {
                cn = new SqlConnection(CadCon.Servidor());
                cn.Open();
                cmd = new SqlCommand("GuardarTutor", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fkcandidato", IdCand);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@ced", ced);
                cmd.Parameters.AddWithValue("@dir", dir);
                cmd.Parameters.AddWithValue("@tel", tel);

                int f = cmd.ExecuteNonQuery();
                if (f != 0)
                {
                    MessageBox.Show("Almacenado exitosamente", "Tutor almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.Dispose();
                    cn.Close();
                }
            }
            catch (SqlException sx)
            {
                MessageBox.Show(sx.ToString());
            }
        }


        public void ActualizarTutor(Form vent, int Id, string nombre, string apellido, string dir, string tel)
        {
            try
            {
                cn = new SqlConnection(CadCon.Servidor());
                cn.Open();
                cmd = new SqlCommand("ActualizarTutor", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                   
                    cmd.Parameters.AddWithValue("@dir", dir);
                    cmd.Parameters.AddWithValue("@tel", tel);

                    int f = cmd.ExecuteNonQuery();
                    if (f != 0)
                    {
                        MessageBox.Show("Tutor actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vent.Dispose();
                        cmd.Dispose();
                        cn.Close();
                    }//KMN
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }//Almacenar en la base de datos Tabla Tutor

        public void MostrarCandidatos(DataGridView dataGrid)
        {
            String query= "Select Pk_candidato as 'ID', nombre as 'Nombre', apellido as 'Apellido', tipo as 'Tipo', "
           +"tel as 'Teléfono', dir as 'Dirección', fecha_nac as 'Fecha de nacimiento', Estado as 'Estado' FROM Candidatos";

           cn= new SqlConnection(CadCon.Servidor());
           cn.Open();
           cmd = new SqlCommand(query, cn);

            //Command.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(cmd);
            Data.Fill(dt);

            dataGrid.DataSource = dt;

            cmd.Dispose();
            cn.Close();
        }//Mostrar todos los candidatos almacenados


        public void DetallesCandidato(int Id, TextBox nombre, TextBox apellido, TextBox tipo, TextBox fechaNac, TextBox dir, MaskedTextBox tel, MaskedTextBox ced, PictureBox pb)
        {
            try
            {
                byte[] datos = new byte[0];
                String query = "Select *From Candidatos where Pk_candidato=" + Id;
                cn = new SqlConnection(CadCon.Servidor());
                cn.Open();
                cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();
                dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);

                /************************************************ */
                nombre.Text = dt.Rows[0][1].ToString();
                apellido.Text = dt.Rows[0][2].ToString();
                tipo.Text = dt.Rows[0][5].ToString();
                fechaNac.Text = dt.Rows[0][6].ToString();
                /************************************************ */

                dir.Text = dt.Rows[0][3].ToString();
                tel.Text = dt.Rows[0][4].ToString();
                ced.Text = dt.Rows[0][8].ToString();



                /************************************************************/
                ds = new DataSet();
                Data.Fill(ds, "Candidatos");
                dr = ds.Tables["Candidatos"].Rows[0];
                datos = (byte[])dr["foto"];
                System.IO.MemoryStream mst = new System.IO.MemoryStream(datos);
                pb.Image = System.Drawing.Bitmap.FromStream(mst);
                /******************************************************************************************/

            }
            catch (SqlException sql) { MessageBox.Show(sql.Message); }
            cmd.Dispose();
            cn.Close();
        }

        public void DetallesTutor(int Id, TextBox nombre, TextBox apellido, TextBox dir, MaskedTextBox tel, TextBox ced)
        {

            try
            {
                String query = "Select* From Tutores where Fk_candidato=" + Id;
                cn = new SqlConnection(CadCon.Servidor());
                cn.Open();
                cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();
                dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);

                /************************************************ */
                nombre.Text = dt.Rows[0][2].ToString();
                apellido.Text = dt.Rows[0][3].ToString();
                ced.Text = dt.Rows[0][4].ToString();
                dir.Text = dt.Rows[0][5].ToString();
                tel.Text = dt.Rows[0][6].ToString();

            }
            catch (SqlException sql) { MessageBox.Show(sql.Message); }    
                
            cmd.Dispose();
            cn.Close();
        }//

        public bool ActualizarCliente(int Id, int IdContacto, string nombre, string tel, string dir)
        {
            try
            {
                cn = new SqlConnection(CadCon.Servidor());
                cn.Open();

                cmd = new SqlCommand("ActualizarCliente", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@idContacto", IdContacto);
                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@dir", dir);
                int r = cmd.ExecuteNonQuery();

                if(r!=0){
                    MessageBox.Show("Cliente actualizado con éxito");
                    return true;
                }

            }catch(SqlException sx){
                MessageBox.Show(sx.ToString());
            }finally{
                cn.Close();
                cn.Dispose();
            }

            return false;
        }


    }
}
