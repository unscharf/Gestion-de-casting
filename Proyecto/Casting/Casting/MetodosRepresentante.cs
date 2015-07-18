using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Casting
{
    class MetodosRepresentante
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;


        public void AgregarRep(int Id, String Ced, String Nombre, String Apellido, String Dir, String Tel) {

            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                string proced = "GuardarRepresentante";
                cmd = new SqlCommand(proced, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
        
                cmd.Parameters.Add("@ced", SqlDbType.NVarChar);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
                cmd.Parameters.Add("@dir", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tel", SqlDbType.NVarChar);
                /************************************************************/
                cmd.Parameters["@ced"].Value = Ced;
                cmd.Parameters["@nombre"].Value = Nombre;
                cmd.Parameters["@apellido"].Value = Apellido;
                cmd.Parameters["@dir"].Value = Dir;
                cmd.Parameters["@tel"].Value = Tel;
                /************************************************************/
                cmd.ExecuteNonQuery();


                string query = "Select *From Representante where Ced='" + Ced + "'";

                cmd = new SqlCommand(query, con);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);

                int cantCol = dt.Rows.Count;
                if (cantCol == 0)
                {
                    MessageBox.Show("No se encontró la información del Representante", "ERROR AL PROCESAR",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {   int idAgente = Convert.ToInt32(dt.Rows[0][0].ToString());
                    cmd = new SqlCommand("GuardarRepCand", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idAgente", SqlDbType.Int);
                    cmd.Parameters.Add("@idCand", SqlDbType.Int);

                    /************************************************************/
                    cmd.Parameters["@idAgente"].Value = idAgente;
                    cmd.Parameters["@idCand"].Value = Id;

                    int f = cmd.ExecuteNonQuery();
                    if (f != 0)
                    {
                        MessageBox.Show("Almacenado exitosamente", "Representante almacenado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }//KMN
                }//
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            cmd.Dispose();
            con.Close();
        }//


        public void DetallesRepresentante(int Id, TextBox rep, TextBox Nombre, TextBox Apellido, TextBox Dir, MaskedTextBox Tel, MaskedTextBox Ced)
        {
            try
            {
                String query = "Select *From Rep_cand where Fk_candidato=" + Id;
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                cmd = new SqlCommand(query, con);
                int Col= cmd.ExecuteNonQuery();

                if (Col == 0)
                {
                    MessageBox.Show("Este candidato no tiene representante registrado", "Información");
                    return;
                }
                else
                {   
                    dt = new DataTable();
                    SqlDataAdapter Data = new SqlDataAdapter(cmd);
                    Data.Fill(dt);

                    int IdRep = Convert.ToInt32(dt.Rows[0][1].ToString());
                    String queryRep = "Select *From Representante where Pk_agente=" + IdRep;
                    cmd = new SqlCommand(queryRep, con);

                    int cantCol = cmd.ExecuteNonQuery();

                    if (cantCol == 0)
                    {
                        MessageBox.Show("Problemas al cargar la información", "Ups...");
                    }

                    dt = new DataTable();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    /************************************************ */
                 
                    Ced.Text = dt.Rows[0][1].ToString();
                    Nombre.Text = dt.Rows[0][2].ToString();
                    Apellido.Text = dt.Rows[0][3].ToString();
                    Dir.Text = dt.Rows[0][4].ToString();
                    Tel.Text = dt.Rows[0][5].ToString();
                    rep.Text = dt.Rows[0][0].ToString();
                    
                    
                }//
            }
            catch (SqlException sql) { MessageBox.Show(sql.Message, "Parece que algo ha salido mal"); }    
                
            cmd.Dispose();
            con.Close();
        }//


        public void ActualizarRepresentante(int Id, string nombre, string apellido, string dir, string tel)
        {
            try
            {
                con = new SqlConnection(CadCon.Servidor());
                con.Open();

                cmd = new SqlCommand("ActualizarRepresentante", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@dir", dir);
                cmd.Parameters.AddWithValue("@tel", tel);
                int r = cmd.ExecuteNonQuery();

                if(r!=0){
                    MessageBox.Show("Datos del Representante Actualizados", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sx) { MessageBox.Show(sx.ToString()); }
            con.Close();
            cmd.Dispose();
        }//

    }
}
