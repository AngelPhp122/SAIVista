﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIModelo
{
    internal class CategoriasModel
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

        public DataTable consulta_a_dgvCat()
        {
            try
            {
                comando = "select id_categoria as ID, nombreCategoria" +
                    " from tbCategoria";
                //comando = "select id_categoria, id_usuario, nombreCategoria from tbCategoria";
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


        public Boolean comprobarRegistroCat(string buscar)
        {
            try
            {
                comando = "select id_categoria from tbCategoria where id_categoria='" + buscar + "'";
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

        public Boolean instruccion_sqlCat(string opcion, string[] valores)
        {
            try
            {
                switch (opcion)
                {
                    case "insertar":
                        comando = "insert into tbCategoria(nombreCategoria,fechaCaptura) " +
                            "values('" + valores[0] + "', CURRENT_TIMESTAMP)";
                        break;
                    case "actualizar":
                        comando = "update tbCategoria set nombreCategoria = '" + valores[0] + 
                            "' where id_categoria = '" + valores[1] + "'";
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