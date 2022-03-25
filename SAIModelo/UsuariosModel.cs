using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIModelo
{
    internal class UsuariosModel
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

        public DataTable llenar_comboBoxUsr()
        {
            try
            {
                comando = "select idUsuario, nombreT from tbTipo_usuario where fechaBaja is null";
                cn = con.getConexionDB();
                sql = new SqlCommand(comando, cn);
                cn.Open();
                da = new SqlDataAdapter(sql);
                tb = new DataTable();
                da.Fill(tb);

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al obtener los registros de la base de datos\n" + e.Message);
            }
            finally
            {
                cerrar_conexion();
            }
            return tb;
        }
        public DataTable consulta_a_dgvUsr()
        {
            try
            {
                comando = "select u.id_usuario as ID, u.nombreUser Nombres,u.apellidoUser Apellidos, u.emailUser," +
                    " u.claveUser, u.id_tipoUser, tu.nombreT Cargo" +
                    " from tbUsuarios u, tbTipo_usuario tu where u.id_tipoUser = tu.idUsuario";
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


        public Boolean comprobarRegistroUsr(string buscar)
        {
            try
            {
                comando = "select id_usuario  from tbUsuarios where id_usuario='" + buscar + "'";
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

        public Boolean instruccion_sqlUsr(string opcion, string[] valores)
        {
            try
            {
                switch (opcion)
                {
                    case "insertar":
                        comando = "insert into tbUsuarios(nombreUser,apellidoUser,emailUser,claveUser" +
                            ",id_tipoUser,fechaCapturaU) " +
                            "values('" + valores[0] + "','" + valores[1] + "','" + valores[2] + "'," +
                            "'" + valores[3] + "','" + valores[4] + "',CURRENT_TIMESTAMP)";
                        break;
                    case "actualizar":
                        comando = "update tbUsuarios set nombreUser = '" + valores[0] + "',apellidoUser = '" + valores[1] + "'" +
                            ",emailUser = '" + valores[2] + "',claveUser = '" + valores[3] + "'" +
                            ",id_tipoUser = '" + valores[4] + "' where id_usuario = '" + valores[5] + "'";
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
