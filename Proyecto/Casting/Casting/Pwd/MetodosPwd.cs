using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Casting.Pwd
{
    class MetodosPwd
    {
        SqlCommand cmd;
        SqlConnection sql;
        DataTable dt;
        SqlDataAdapter sda;

        public bool BuscarUsuario(Form t, string user)
        {
            
            string query = "Select *From Usuarios where Usuario='"+user+"'";
           
            try {
                sql = new SqlConnection(CadCon.Servidor());
                sql.Open();
                cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                int row = dt.Rows.Count;
                if (row == 0)
                {
                    MessageBox.Show(t, "La búsqueda no arrojó resultados:\n"
                                   +"El nombre de usuario proporcionado no concuerda \n"
                                   +"con la información almacenada en la base de datos","Lo sentimos...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                    
                }
                else
                {
                    
                    t.Hide();

                    return true;
                }
               
            }
            catch (SqlException s) { MessageBox.Show(s.Message); }
            cmd.Dispose();
            sql.Close();
            return false;
        }

        public void setData(String user, TextBox PwdRecover)
        {
            try
            {
                sql = new SqlConnection(CadCon.Servidor());
                sql.Open();
                String queryRep = "Select *From Usuarios where Usuario='" + user + "'";
                cmd = new SqlCommand(queryRep, sql);

                int row = cmd.ExecuteNonQuery();

                if (row == 0)
                {
                    MessageBox.Show("Problemas al cargar la información", "Ups...");
                }
                else
                {   dt = new DataTable();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    /************************************************ */
                    PwdRecover.Text = dt.Rows[0][3].ToString();
                    /************************************************** */
                }
                sql.Close();
                cmd.Dispose();
            }
            catch (SqlException se) { MessageBox.Show(se.Message); }

        }//


        public void CompararRespuesta(Form f, string ask, string resp)
        {
            string dbAnswer;
            try
            {
                sql = new SqlConnection(CadCon.Servidor());
                sql.Open();
                String queryRep = "Select *From Usuarios where PwdRecover='" + ask + "'";
                cmd = new SqlCommand(queryRep, sql);

                int row = cmd.ExecuteNonQuery();

                if (row == 0)
                {
                    MessageBox.Show("Problemas al cargar la información", "Ups...");
                }
                else
                {
                    dt = new DataTable();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    /************************************************ */
                    dbAnswer=dt.Rows[0][4].ToString();
                    if(resp.Equals(dbAnswer)){
                        EditarUsuario ed = new EditarUsuario();
                        ed.Show();
                        f.Hide();
                    }
                    else {
                        MessageBox.Show("La información proporcionada es incorrecta...\n"
                            +"Tu respuesta no coincide con la respuesta almacenada\n"
                            +"en la base de datos",
                            "Lo sentimos...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                    /************************************************** */
                }
                sql.Close();
                cmd.Dispose();
            }
            catch (SqlException se) { MessageBox.Show(se.Message); }



        }



    }
}
