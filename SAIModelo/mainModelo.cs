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
        public void insertarDatos(string a, string b, string c, string d, string e, string f) {

            try
            {
                int idImagen = 0;
                
                insertarRutaImagen(f, a);
                string[] datosImagen0 = new string[2];
                datosImagen0 = retornoIdImagenAgregar(f);

                if (datosImagen0[1] == f ) {

                    idImagen = int.Parse(datosImagen0[0]);

                }

                obj.getConexionDB().Open();



                consultaSQL = "INSERT INTO tbArticulos(id_categoria, id_imagen, id_usuario, nombreArticulo, descripcionArt, cantidad, precio, fechaCaptura) values('" + int.Parse(a) + "','" + idImagen + "','" + 1 + "'," +
                    "'" + b + "','" + c + "','" + int.Parse(d) + "','" + double.Parse(e) + "','" +  fecha + "')";

                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();

                
                obj.getConexionDB().Close();
                lector.Close();



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



                while (lector.Read())
                {

                    listaArrayID.Add((string)lector["id_categoria"].ToString());
                    listaArrayCategoria.Add((string)lector["nombreCategoria"]);

                }
                lector.Close();
                obj.getConexionDB().Close();

                datos = new string[listaArrayCategoria.Count, 2];


                for (int k = 0; k < listaArrayCategoria.Count; k++)
                {
                    for (int i = 0; i <= 0; i++)
                    {

                        datos[k, i] = listaArrayID[k].ToString();

                    }
                    for (int j = 1; j <= 1; j++)
                    {
                        datos[k, j] = (string)listaArrayCategoria[k];
                    }

                }

                // Console.WriteLine(datos[0]+"este dato trajo");

                return datos;



            

        }


        //datos para el llenado del dataGrigView
        public string[,] datosDataGrieView() {

            string [,]datosDtgArticulos;
            string[,] datosIdImagen;

            var listaProductoID = new List<string>();
            var listaCategoriaID = new List<string>();
            var listaImagenID = new List<string>();
            var listaDosIDimagen = new List<string>();
            var listaRutaImagen = new List<string>();
            //var listaUsuarioID = new List<string>();
            var listaNombreArt = new List<string>();
            var listaDescripcion = new List<string>();
            var listaCantidad = new List<string>();
            var listaPrecio = new List<string>();
            //var listaFechaCap = new List<string>();

            
            obj.getConexionDB().Open();

            consultaSQL = "select id_producto, id_categoria, nombreArticulo, descripcionArt, cantidad, precio, id_imagen from tbArticulos";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read()) {



                listaProductoID.Add((string)lector["id_producto"].ToString());
                listaCategoriaID.Add((string)lector["id_categoria"].ToString());
                //listaUsuarioID.Add((string)lector["id_usuario"].ToString());
                listaNombreArt.Add((string)lector["nombreArticulo"]);
                listaDescripcion.Add((string)lector["descripcionArt"]);
                listaCantidad.Add((string)lector["cantidad"].ToString());
                listaPrecio.Add((string)lector["precio"].ToString());
                listaDosIDimagen.Add((string)lector["id_imagen"].ToString());
                //listaFechaCap.Add((string)lector["fechaCaptura"].ToString());

            }
            lector.Close();
            obj.getConexionDB().Close();

            //para extraer el id de la imagen y su path
            
            obj.getConexionDB().Open();
            consultaSQL = "select id_imagen, rutaImagen from tbImagenes";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read()) {

                listaImagenID.Add(lector["id_imagen"].ToString());
                listaRutaImagen.Add(lector["rutaImagen"].ToString());
            }
            lector.Close();
            obj.getConexionDB().Close();

            
            datosIdImagen = new string[listaImagenID.Count,2];
            datosDtgArticulos = new string[listaProductoID.Count,7];

            for (int k =0; k<listaRutaImagen.Count;k++) {

                datosIdImagen[k, 0] = listaImagenID[k];
                datosIdImagen[k, 1] = listaRutaImagen[k];
            }
            

            for (int i = 0; i < listaProductoID.Count; i++)
            {
                
                
                    datosDtgArticulos[i,0] = listaProductoID[i];
                    datosDtgArticulos[i,1] = listaCategoriaID[i];
                    //datosDtgArticulos[i,2] = listaImagenID[i];
                    //datosDtgArticulos[i,3] = listaUsuarioID[i];
                    datosDtgArticulos[i,2] = listaNombreArt[i];
                    datosDtgArticulos[i,3] = listaDescripcion[i];
                    datosDtgArticulos[i,4] = listaCantidad[i];
                    datosDtgArticulos[i,5] = listaPrecio[i];
                    datosDtgArticulos[i, 6] = listaDosIDimagen[i];
                    for (int j = 0; j<datosIdImagen.GetLength(0);j++) {
                    if (datosDtgArticulos[i, 6] == datosIdImagen[j,0])
                    {
                        datosDtgArticulos[i, 6] = listaRutaImagen[j];
                    }
                }
                    


                
            }

            
            
            return datosDtgArticulos;
        }

        //metodo para guardar ruta de la imagen en la base de datos
        public void insertarRutaImagen(string rutaImg, string categoriImg)
        {

            try
            {
                obj.getConexionDB().Open();
                consultaSQL = "INSERT INTO tbImagenes(id_categoria, nombreImagen, rutaImagen, fechaSubida) values('" + int.Parse(categoriImg) + "','" + "generico" + "','" + rutaImg + "','"+fecha+"')";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();
                lector.Close();
                obj.getConexionDB().Close();
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);

            }

        }

        //este metodo es para retornar el id de la imagen que se guardara en la tabla articulos
        public string []retornoIdImagenAgregar(string rutaImagen1)
        {
            string []DatosImagen;

            
            obj.getConexionDB().Open();
            consultaSQL = "SELECT id_imagen, rutaImagen FROM tbImagenes WHERE rutaImagen = '"+rutaImagen1+"'";
            comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();
            

            DatosImagen = new string[2];

            while (lector.Read()) {

                DatosImagen[0] = lector["id_imagen"].ToString();
                DatosImagen[1] = lector["rutaImagen"].ToString();
                
            }

            lector.Close();
            obj.getConexionDB().Close();

            return DatosImagen;
        }

        //Metodo para realizar la eliminacion del registro que corresponde al id seleccionado en el datagridview
        public void eliminarDatosModelo(int idProductoModelo) { 
        
            int idArticulo = idProductoModelo;

            obj.getConexionDB().Open();
            consultaSQL = "DELETE FROM tbArticulos WHERE id_producto='" + idProductoModelo + "'";
            comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB ());
            lector = comandoConexion.ExecuteReader();

          
            lector.Close();
            obj.getConexionDB ().Close();
        
        }

        //metodo para realizr la actualizacion de datos de mi tabla articulos
        public void actualizarDatosModelo(int idProductoAcModelo, int idCategoria, int idImagen, string nombreProducto, string descripcionArt, int cantidadP, double precioP) {

            Console.WriteLine("este es el valor de la imagen id"+idImagen);
            obj.getConexionDB ().Open();
            consultaSQL = "UPDATE tbArticulos SET id_categoria='"+idCategoria+"',id_imagen='"+idImagen+"',nombreArticulo='"+nombreProducto+"',descripcionArt='"+descripcionArt+"',cantidad='"+cantidadP+"',precio='"+precioP+"' WHERE id_producto='"+idProductoAcModelo+"'";
            
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB ());
            lector = comandoConexion.ExecuteReader ();

            lector.Close();
            obj.getConexionDB().Close();

        }

        //metodo para retornar el id de la imagen a la vista

        public int retornoIdimagenUpdateModel(string rutaImgModel, int idProductoModel, bool imagenExistente)
        {

            int idImagenRetornoVista;
            int []arregloIdImagen = new int[1];

            //cuando se trata de la misma imagen
            if (imagenExistente == true) {
                obj.getConexionDB().Open();
                consultaSQL = "SELECT tbArticulos.id_producto, tbArticulos.id_imagen FROM tbArticulos WHERE id_producto='" + idProductoModel + "'";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();


                while (lector.Read())
                {
                    arregloIdImagen[0] = int.Parse(lector["id_imagen"].ToString());
                }

                lector.Close();
                obj.getConexionDB().Close();

                idImagenRetornoVista = arregloIdImagen[0];


                return idImagenRetornoVista;
            }

            //cuando se trata de una imagen nueva
            else {

                obj.getConexionDB().Open();
                consultaSQL = "SELECT TOP(1) * FROM tbImagenes ORDER BY id_imagen DESC";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB()) ;
                lector = comandoConexion.ExecuteReader();


                while (lector.Read())
                {
                    arregloIdImagen[0] = int.Parse(lector["id_imagen"].ToString());
                }

                lector.Close();
                obj.getConexionDB().Close();

                idImagenRetornoVista = arregloIdImagen[0];

                return idImagenRetornoVista;
            }
        }

    }
}
