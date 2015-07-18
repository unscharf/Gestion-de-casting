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
    class MetodosCandidato
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sda;
        


        public string InsertarCandidato(string nombre, string apellido, string dir, string tel, string tipo, string fechaNac, string procedencia, string sexo, string espc, string cpe, string csj, int exp, PictureBox pbImagen)
        {
            cn = new SqlConnection(CadCon.Servidor());
            cn.Open();

            string box = "Datos almacenado con éxito";
            try
            {
                cmd = new SqlCommand("GuardarCandidatoNino", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
                cmd.Parameters.Add("@dir", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tel", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tipo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@fecha_nac", SqlDbType.NVarChar);
                cmd.Parameters.Add("@foto", SqlDbType.Image);
                cmd.Parameters.Add("@estado", SqlDbType.NVarChar);

                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@apellido"].Value = apellido;
                cmd.Parameters["@dir"].Value = dir;
                cmd.Parameters["@tel"].Value = tel;
                cmd.Parameters["@tipo"].Value = tipo;
                cmd.Parameters["@fecha_nac"].Value = fechaNac;
                cmd.Parameters["@estado"].Value = "Activo";
                
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@foto"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
                string query = "Select *From Candidatos where nombre='" + nombre
              + "' AND apellido= '" + apellido + "' AND dir='" + dir + "' AND tel='" + tel
              + "' AND fecha_nac= '" + fechaNac + "' AND Tipo='Niño'";

                cmd = new SqlCommand(query, cn);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);

                int cantCol = dt.Rows.Count;
                if (cantCol == 0)
                {
                    MessageBox.Show("No se encontró la información del contacto indicado", "ERROR AL PROCESAR",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                int Fk_cand = Convert.ToInt32(dt.Rows[0][0].ToString());

                cmd = new SqlCommand("GuardarPerfil", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@Fkcand", SqlDbType.Int);
                cmd.Parameters.Add("@procedencia", SqlDbType.NVarChar);
                cmd.Parameters.Add("@sexo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@especialidad", SqlDbType.NVarChar);
                cmd.Parameters.Add("@colorpelo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@colorojos", SqlDbType.NVarChar);
                cmd.Parameters.Add("@experiencia", SqlDbType.Int);


                cmd.Parameters["@Fkcand"].Value = Fk_cand;
                cmd.Parameters["@procedencia"].Value = procedencia;
                cmd.Parameters["@sexo"].Value = sexo;
                cmd.Parameters["@especialidad"].Value = espc;
                cmd.Parameters["@colorpelo"].Value = cpe;
                cmd.Parameters["@colorojos"].Value = csj;
                cmd.Parameters["@experiencia"].Value = exp;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                box = "Problemas en la base de datos: " + ex.ToString();
            }

            cmd.Dispose();
            cn.Close();
            return box;
        }//


        public string InsertarCandidatoAdulto(string nombre, string apellido, string dir, string tel, string tipo, string fechaNac, string ced, string procedencia, string sexo, string espc, string cpe, string csj, int exp, PictureBox pbImagen)
        {
            cn = new SqlConnection(CadCon.Servidor());
            cn.Open();

            string box = "Almacenado con éxito";
            try
            {
                cmd = new SqlCommand("GuardarCandidato", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
                cmd.Parameters.Add("@dir", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tel", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tipo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@fecha_nac", SqlDbType.NVarChar);
                cmd.Parameters.Add("@img", SqlDbType.Image);
                cmd.Parameters.Add("@ced", SqlDbType.NVarChar);
                cmd.Parameters.Add("@estado", SqlDbType.NVarChar);

                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@apellido"].Value = apellido;
                cmd.Parameters["@dir"].Value = dir;
                cmd.Parameters["@tel"].Value = tel;
                cmd.Parameters["@tipo"].Value = tipo;
                cmd.Parameters["@fecha_nac"].Value = fechaNac;
                cmd.Parameters["@estado"].Value = "Activo";

                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@img"].Value = ms.GetBuffer();
                cmd.Parameters["@ced"].Value = ced;
                cmd.ExecuteNonQuery();

              string query = "Select *From Candidatos where nombre='" + nombre
               + "' AND apellido= '" + apellido + "' AND dir='" + dir+"' AND tel='"+tel
               + "' AND fecha_nac= '" + fechaNac + "' AND Tipo='Adulto' AND cedula='"+ced+"'";
                
                cmd = new SqlCommand(query,cn);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);

                int cantCol = dt.Rows.Count;
                if (cantCol == 0)
                {
                    MessageBox.Show("No se encontró la información del contacto indicado", "ERROR AL PROCESAR",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
               
                int Fk_cand= Convert.ToInt32(dt.Rows[0][0].ToString());

                cmd = new SqlCommand("GuardarPerfil", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@Fkcand", SqlDbType.Int);
                cmd.Parameters.Add("@procedencia", SqlDbType.NVarChar);
                cmd.Parameters.Add("@sexo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@especialidad", SqlDbType.NVarChar);
                cmd.Parameters.Add("@colorpelo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@colorojos", SqlDbType.NVarChar);
                cmd.Parameters.Add("@experiencia", SqlDbType.Int);
                

                cmd.Parameters["@Fkcand"].Value = Fk_cand;
                cmd.Parameters["@procedencia"].Value = procedencia;
                cmd.Parameters["@sexo"].Value = sexo;
                cmd.Parameters["@especialidad"].Value = espc;
                cmd.Parameters["@colorpelo"].Value = cpe;
                cmd.Parameters["@colorojos"].Value = csj;
                cmd.Parameters["@experiencia"].Value = exp;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                box = "Problemas en la base de datos:" + ex.ToString();
            }

            cmd.Dispose();
            cn.Close();
            return box;
        }//


        public void ActualizarCand(int id, string nombre, string apellido, string dir, string tel, string estado, PictureBox pb)
        {
             cn = new SqlConnection(CadCon.Servidor());
            cn.Open();

            
            try
            {
                cmd = new SqlCommand("ActualizarCandidato", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters.Add("@apellido", SqlDbType.NVarChar);
                cmd.Parameters.Add("@dir", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tel", SqlDbType.NVarChar);
                cmd.Parameters.Add("@estado", SqlDbType.NVarChar);
                cmd.Parameters.Add("@img", SqlDbType.Image);


                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@img"].Value = ms.GetBuffer();
                cmd.Parameters["@dir"].Value = dir;
                cmd.Parameters["@tel"].Value = tel;
                cmd.Parameters["@nombre"].Value = nombre;
                cmd.Parameters["@apellido"].Value = apellido;
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@estado"].Value = estado;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Actualizado exitosamente", "Operación Finalizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (SqlException sql) { MessageBox.Show(sql.Message); }
        }//
    }
}
