using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIModelo
{
    internal class TiposUsuarioModel
    {

        SqlConnection cn;
        SqlDataAdapter da;
        DataTable tb;
        SqlCommand sql;
        Conexion con = new Conexion();
        string comando;

        public void cerrar_conexion()
        {
            try
            {
                if (cn != null)
                    cn.Close();
                if (da != null)
                    da.Dispose();
                if (sql != null)
                    sql.Dispose();
            }
            catch (Exception) { }
        }
        public DataTable consulta_a_dgv()
        {
            try
            {
                comando = "select idUsuario as ID, nombreT Descripcion,fechaAlta Creacion, fechaBaja Baja from tbTipo_usuario";
                cn = con.getConexionDB();
                sql = new SqlCommand(comando, cn);
                cn.Open();
                da = new SqlDataAdapter(sql);
                tb = new DataTable();
                da.Fill(tb);

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al verificar el registro en la base de datos\n" + e.Message);
            }
            cerrar_conexion();
            return tb;
        }


        public Boolean comprobarRegistro(string buscar)
        {
            try
            {
                comando = "select idUsuario  from tbTipo_usuario where idUsuario='" + buscar + "'";
                cn = con.getConexionDB();
                sql = new SqlCommand(comando, cn);
                cn.Open();
                da = new SqlDataAdapter(sql);
                tb = new DataTable();
                da.Fill(tb);

                if (tb.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al verificar el registro en la base de datos\n" + e.Message);
            }
            finally
            {
                cerrar_conexion();
            }
            return false;
        }

        public Boolean instruccion_sql(string opcion, string[] valores)
        {
            try
            {
                switch (opcion)
                {
                    case "insertar":
                        comando = "insert into tbTipo_usuario(nombreT,fechaAlta) values('" + valores[0]+ "',CURRENT_TIMESTAMP)";
                        break;
                    case "actualizar":
                        comando = "update tbTipo_usuario set nombreT = '"+valores[0]+ "' where idUsuario = '"+valores[1]+"'";
                        break;
                    case "baja":
                        comando = "update tbTipo_usuario set fechaBaja = CURRENT_TIMESTAMP where idUsuario = '" + valores[0] + "'";
                        break;
                }
                cn = con.getConexionDB();
                sql = new SqlCommand(comando, cn);
                cn.Open();
                sql.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al ejecutar el comando en la base de datos\n" + e.Message);
            }
            finally
            {
                cerrar_conexion();
            }
            return false;
        }
    }
}
