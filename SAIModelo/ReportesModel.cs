using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SAIModelo
{
    internal class ReportesModel
    {

        private SqlCommand comandoConexion;
        private SqlDataReader lector;
        private string consultaSQL;
        private DateTime fecha = DateTime.Now;

        Conexion obj = new Conexion();


        //Metodo para retorno de reporte por fechas 

        private string[,] datosReporte(string fechaInicio, string fechaHasta)
        {
            try
            {
                string[,] arregloDatos;

                var listaNombre = new List<string>();
                var listaFactura = new List<string>();
                var listaCantidad = new List<string>();
                var listaPrecio = new List<string>();
                var listaDescripcion = new List<string>();

                obj.getConexionDB().Open();
                consultaSQL = "SELECT nombre_productoCom, numFacturaComp, cantProdComprado, precioProdCompra, descripcionCompraProd from tbCompra_detalle,tbCompra_encabezado where  fechaCompra >= '" + fechaInicio + "' AND fechaCompra <= '" + fechaHasta + "'";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();

                while (lector.Read())
                {
                    listaNombre.Add(lector["nombre_productoCom"].ToString());
                    listaFactura.Add(lector["numFacturaComp"].ToString());
                    listaCantidad.Add(lector["cantProdComprado"].ToString());
                    listaPrecio.Add((string)lector["precioProdCompra"].ToString());
                    listaDescripcion.Add((string)lector["descripcionCompraProd"]);

                }
                lector.Close();
                obj.getConexionDB().Close();

                arregloDatos = new string[listaNombre.Count, 5];

                for (int i = 0; i < listaNombre.Count; i++)
                {
                    arregloDatos[i, 0] = listaNombre[i].ToString();
                    arregloDatos[i, 1] = listaFactura[i].ToString();
                    arregloDatos[i, 2] = listaCantidad[i].ToString();
                    arregloDatos[i, 3] = listaPrecio[i].ToString();
                    arregloDatos[i, 4] = listaDescripcion[i].ToString();

                }

                return arregloDatos;
            }
            catch (Exception ex)
            {
                string[,] arreglo = new string [1,1] ;
                Console.WriteLine(ex.ToString());
                arreglo[0, 0] = ex.ToString();
                return arreglo; 
            }


        }

        public string[,] getDatosReporte(string fechaInicio, string fechaHasta){

            string[,] arregloDatos;

            arregloDatos = datosReporte(fechaInicio, fechaHasta);

            return arregloDatos;
        }

        

        

    }
}
