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
    class MetodosPerfiles
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        DataSet dse;
        DataRow dr;

        public void MostrarPerfiles(DataGridView dataGrid)
        {
            con = new SqlConnection(CadCon.Servidor());
            con.Open();

            try
            {
                String query = "Select *From Candidatos_Perfiles";

                cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter(cmd);
                Data.Fill(dt);

                dataGrid.DataSource = dt;
            }
            catch (SqlException sql) { MessageBox.Show(sql.Message, "Error al realizar la operación indicada"); }
            cmd.Dispose();
            con.Close();
        }//



        public void DetallesPerfiles(int Id, TextBox nombre, TextBox apellido, TextBox tipo, TextBox fechaNac, TextBox dir, MaskedTextBox tel, MaskedTextBox ced, TextBox proced, TextBox sexo, TextBox espc, TextBox cp, TextBox cdo, PictureBox pb)
        {
            try
            {
                byte[] datos = new byte[0];
                String query = "SELECT *FROM Candidatos INNER JOIN Perfil" 
                 +" on Candidatos.Pk_candidato= Perfil.Fk_candidato"
                 +" WHERE Pk_candidato=" + Id;
                con = new SqlConnection(CadCon.Servidor());
                con.Open();
                cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sda= new SqlDataAdapter(cmd);
                sda.Fill(dt);

                /************************************************ */
                nombre.Text = dt.Rows[0][1].ToString();
                apellido.Text = dt.Rows[0][2].ToString();
                tipo.Text = dt.Rows[0][5].ToString();
                fechaNac.Text = dt.Rows[0][6].ToString();
                /************************************************ */

                dir.Text = dt.Rows[0][3].ToString();
                tel.Text = dt.Rows[0][4].ToString();
                ced.Text = dt.Rows[0][8].ToString();
                proced.Text = dt.Rows[0][12].ToString();
                sexo.Text = dt.Rows[0][13].ToString();
                espc.Text = dt.Rows[0][14].ToString();
                cp.Text = dt.Rows[0][15].ToString();
                cdo.Text = dt.Rows[0][16].ToString();


                /************************************************************/
                dse = new DataSet();
                sda.Fill(dse, "Candidatos");

                dr = dse.Tables["Candidatos"].Rows[0];
                datos = (byte[])dr["foto"];
                System.IO.MemoryStream mst = new System.IO.MemoryStream(datos);
                pb.Image = System.Drawing.Bitmap.FromStream(mst);
                /******************************************************************************************/

            }
            catch (SqlException sql) { MessageBox.Show(sql.Message); }
            cmd.Dispose();
            con.Close();


        }
    }
}
