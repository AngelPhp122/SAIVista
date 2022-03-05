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

    public class mainModelo
    {
        private SqlCommand comandoConexion;
        private SqlDataReader lector;
        private string consultaSQL;
        private DateTime fecha = DateTime.Now;

        

        Conexion obj = new Conexion();
        


        //*******metodo para la insercion de datos a la tabla articulos de la base de datos******
        public void insertarDatos(string a, string b, string c, string d, string e) {

            try
            {

                obj.getConexionDB().Open();

                consultaSQL = "INSERT INTO tbArticulos(id_categoria, id_imagen, id_usuario, nombreArticulo, descripcionArt, cantidad, precio, fechaCaptura) values('" + int.Parse(a) + "','" + 1 + "','" + 1 + "'," +
                    "'" + b + "','" + c + "','" + int.Parse(d) + "','" + double.Parse(e) + "','" +  fecha + "')";

                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();

                lector.Close();
                obj.getConexionDB().Close();

                Console.WriteLine(consultaSQL);

            }
            catch (Exception error) {

                Console.WriteLine(error.Message);
            }
        }

        //metodo para llenar categorias al comboBox de la interfaz frmProductos

        public string[,] datosCbxCategoria() {

            var listaArrayCategoria = new List<string>();
            var listaArrayID = new List<string>();
            

            string[,] datos;
           

           
                obj.getConexionDB().Open();

                consultaSQL = "SELECT id_categoria, nombreCategoria FROM tbCategoria";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();

            /*while (lector.Read()) {

                j++;
            }*/


                while (lector.Read())
                {

                listaArrayID.Add((string)lector["id_categoria"].ToString());
                listaArrayCategoria.Add((string)lector["nombreCategoria"]);
                    
                }
                lector.Close();
                obj.getConexionDB().Close();

            datos = new string [listaArrayCategoria.Count,2];
           

            for (int k = 0; k < listaArrayCategoria.Count; k++) {
                for (int i = 0; i <= 0; i++) {

                    datos[k, i] = listaArrayID[k].ToString(); 
                
                }
                for (int j = 1; j <= 1; j++)
                {
                    datos[k,j] = (string)listaArrayCategoria[k];
                }

            }
                
               // Console.WriteLine(datos[0]+"este dato trajo");

            return datos;
        }


        //datos para el llenado del dataGreiwView
        public string[,] datosDataGrieView() {

            string [,]datosDtgArticulos;

            var listaProductoID = new List<string>();
            var listaCategoriaID = new List<string>();
            var listaImagenID = new List<string>();
            var listaUsuarioID = new List<string>();
            var listaNombreArt = new List<string>();
            var listaDescripcion = new List<string>();
            var listaCantidad = new List<string>();
            var listaPrecio = new List<string>();
            var listaFechaCap = new List<string>();

            obj.getConexionDB().Open();

            consultaSQL = "select * from tbArticulos";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read()) {



                listaProductoID.Add((string)lector["id_producto"].ToString());
                listaCategoriaID.Add((string)lector["id_categoria"].ToString());
                listaImagenID.Add((string)lector["id_imagen"].ToString());
                listaUsuarioID.Add((string)lector["id_usuario"].ToString());
                listaNombreArt.Add((string)lector["nombreArticulo"]);
                listaDescripcion.Add((string)lector["descripcionArt"]);
                listaCantidad.Add((string)lector["cantidad"].ToString());
                listaPrecio.Add((string)lector["precio"].ToString());
                listaFechaCap.Add((string)lector["fechaCaptura"].ToString());

            }

            obj.getConexionDB().Close();
            lector.Close();

            datosDtgArticulos = new string[listaProductoID.Count,9];

            for (int i = 0; i < listaProductoID.Count; i++)
            {
                
                
                    datosDtgArticulos[i,0] = listaProductoID[i];
                    datosDtgArticulos[i,1] = listaCategoriaID[i];
                    datosDtgArticulos[i,2] = listaImagenID[i];
                    datosDtgArticulos[i,3] = listaUsuarioID[i];
                    datosDtgArticulos[i,4] = listaNombreArt[i];
                    datosDtgArticulos[i,5] = listaDescripcion[i];
                    datosDtgArticulos[i,6] = listaCantidad[i];
                    datosDtgArticulos[i,7] = listaPrecio[i];
                datosDtgArticulos[i, 8] = listaFechaCap[i];


                
            }

            return datosDtgArticulos;
        }

    }
}
