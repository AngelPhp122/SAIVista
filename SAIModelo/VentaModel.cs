using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIModelo
{
    public class VentaModel
    {

        SqlConnection cn;
        SqlDataAdapter da;
        DataTable tb;
        SqlCommand sql;
        Conexion con = new Conexion();
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


        public DataTable GetSales()
        {
            try
            {

                string query = @"SELECT IdVenta, 
                                   c.nombreCliente +' '+c.apellidoCliente as Cliente,
                                   Fecha, 
                                   TotalProductos,
                                   TotalFacturado 
                              FROM tbVentas_encab v
                        INNER JOIN tbClientes c on v.IdCliente=c.id_cliente";


                cn = con.getConexionDB();
                sql = new SqlCommand(query, cn);
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

        public DataTable GetProducts()
        {
            try
            {
                string query = @"Select id_producto, nombreArticulo,precio 
                            from tbArticulos
                           where cantidad>0";

                cn = con.getConexionDB();
                sql = new SqlCommand(query, cn);
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

        public void SaveSale(DataTable data, int totalProductos, double totalValor, int IdCliente)
        {
            try
            {
                int? idVenta = null;
                using (SqlConnection conn = con.getConexionDB())
                {
                    conn.Open();
                    // 1.  create a command object identifying the stored procedure
                    SqlCommand cmd = new SqlCommand("SP_CreateSale", conn);

                    // 2. set the command object so it knows to execute a stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 3. add parameter to command, which will be passed to the stored procedure
                    cmd.Parameters.AddWithValue("@IdCustomer", IdCliente);
                    cmd.Parameters.AddWithValue("@TotalProducts", totalProductos);
                    cmd.Parameters.AddWithValue("@TotalSale", totalValor);

                    // execute the command
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        // iterate through results, printing each to console
                        while (rdr.Read())
                        {
                            idVenta = int.Parse(rdr["IdVenta"].ToString());
                        }
                    }
                    string query;

                    foreach (DataRow row in data.Rows)
                    {
                        var sdas = row[0];
                        if (!string.IsNullOrEmpty(row[0].ToString()))
                        {
                            query = "INSERT INTO tbVenta_detalle(IdVenta, IdProducto, Valor)";
                            query += $" VALUES({idVenta},{row[0]},{row[2]})";
                            SqlCommand comandoConexion = new SqlCommand(query, conn);
                            SqlDataReader lector = comandoConexion.ExecuteReader();
                            lector.Close();
                        }
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al verificar el registro en la base de datos\n" + e.Message);
            }
            cerrar_conexion();
        }

        public DataTable GetUsers()
        {
            try
            {
                string query = @"Select id_cliente,nombreCliente+' '+apellidoCliente from tbClientes";

                cn = con.getConexionDB();
                sql = new SqlCommand(query, cn);
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
    }
}
