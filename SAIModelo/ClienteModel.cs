﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIModelo
{
    internal class ClienteModel
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

        public DataTable consulta_a_dgvCli()
        {
            try
            {
                comando = "select c.id_cliente as ID, c.nombreCliente Nombres,c.apellidoCliente Apellidos, c.Direccion," +
                    " c.Telefono, c.correoElectronico from tbClientes c";
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


        public Boolean comprobarRegistroCli(string buscar)
        {
            try
            {
                comando = "select id_cliente  from tbClientes where id_cliente='" + buscar + "'";
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

        public Boolean instruccion_sqlCli(string opcion, string[] valores)
        {
            try
            {
                switch (opcion)
                {
                    case "insertar":
                        comando = "insert into tbClientes(nombreCliente,apellidoCliente,Direccion" +
                            ",Telefono,correoElectronico,fechaCaptura) " +
                            "values('" + valores[0] + "','" + valores[1] + "','" + valores[2] + "'," +
                            "'" + valores[3] + "','" + valores[4] + "',CURRENT_TIMESTAMP)";
                        break;
                    case "actualizar":
                        comando = "update tbClientes set nombreCliente = '" + valores[0] + "',apellidoCliente = '" + valores[1] + "'" +
                            ",Direccion = '" + valores[2] + "',telefono = '" + valores[3] + "'" +
                            ",correoElectronico = '" + valores[4] + "' where id_cliente = '" + valores[5] + "'";
                        break;
                    case "eliminar":
                        comando = "delete from tbClientes where id_cliente = '" + valores[0] + "'";
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
