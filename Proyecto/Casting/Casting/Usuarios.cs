using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using Casting.Load;
using System.Threading.Tasks;

namespace Casting
{
    class Usuarios
    {
        SqlConnection sql;
        SqlCommand cmd;
        DataRow dr;
      
        public void GuardarUsuario(String user, String Pwd, String PwdRecover, String PwdAnswer, PictureBox pb)
        {
            try
            {
                sql = new SqlConnection(CadCon.Servidor());
                sql.Open();
                string query = "GuardarUsuario";
                cmd = new SqlCommand(query, sql);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@usuario", SqlDbType.NVarChar);
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar);
                cmd.Parameters.Add("@PwdRecover", SqlDbType.NVarChar);
                cmd.Parameters.Add("@PwdAnswer", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Foto", SqlDbType.Image);
                

                cmd.Parameters["@usuario"].Value = user;
                cmd.Parameters["@pass"].Value = Pwd;
                cmd.Parameters["@PwdRecover"].Value = PwdRecover;
                cmd.Parameters["@PwdAnswer"].Value = PwdAnswer;
               
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Foto"].Value = ms.GetBuffer();
                int f= cmd.ExecuteNonQuery();
                if (f != 0)
                {
                    MessageBox.Show("Almacenado exitosamente", "Usuario Almacenado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.Dispose();
                    sql.Close();
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }

        public void ActualizarUsuario(String user, String Pwd, String PwdRecover, String PwdAnswer, PictureBox pb)
        {
            try
            {
                sql = new SqlConnection(CadCon.Servidor());
                sql.Open();
                string query = "ActualizarUsuario";
                cmd = new SqlCommand(query, sql);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@usuario", SqlDbType.NVarChar);
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar);
                cmd.Parameters.Add("@PwdRecover", SqlDbType.NVarChar);
                cmd.Parameters.Add("@PwdAnswer", SqlDbType.NVarChar);
                cmd.Parameters.Add("@Foto", SqlDbType.Image);

                cmd.Parameters["@usuario"].Value = user;
                cmd.Parameters["@pass"].Value = Pwd;
                cmd.Parameters["@PwdRecover"].Value = PwdRecover;
                cmd.Parameters["@PwdAnswer"].Value = PwdAnswer;

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@Foto"].Value = ms.GetBuffer();
                int f = cmd.ExecuteNonQuery();
                if (f != 0)
                {
                    MessageBox.Show("Actualizado exitosamente", "Usuario Almacenado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.Dispose();
                    sql.Close();
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }


        public void MostrarUsuario(TextBox user, PictureBox pb)
        {
            try{
            byte[] datos = new byte[0];
            String query = "Select *From Usuarios where Pk_user=" + 1;
            sql= new SqlConnection(CadCon.Servidor());
            sql.Open();
            cmd = new SqlCommand(query, sql);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter(cmd);
            Data.Fill(dt);

            user.Text = dt.Rows[0][1].ToString();
            DataSet set = new DataSet();
            Data.Fill(set, "Usuarios");

            dr = set.Tables["Usuarios"].Rows[0];
            datos = (byte[])dr["Foto"];
            System.IO.MemoryStream mst = new System.IO.MemoryStream(datos);
            pb.Image = System.Drawing.Bitmap.FromStream(mst);
            sql.Close();
            cmd.Dispose();
           }catch(SqlException ex){ MessageBox.Show(ex.Message);}


        }


        public void Entrar(Form f, TextBox user, TextBox pass)
        {
          try{
            
            sql = new SqlConnection(CadCon.Servidor());
            sql.Open();

            cmd = new SqlCommand("Entrar", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@usuario", user.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
             int operacion = cmd.ExecuteNonQuery();
             DataTable d = new DataTable();
             SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(d);

               if (d.Rows.Count >0)
                {
                    LoadThread lt = new LoadThread();
                   lt.Show();
                   f.Hide();
                }
                else {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos\n", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    user.Focus();
                    pass.Clear();
                  } 
                cmd.Dispose();
                sql.Close();
          }
          catch (SqlException s) { MessageBox.Show(s.Message); }
        }//
    }
}
