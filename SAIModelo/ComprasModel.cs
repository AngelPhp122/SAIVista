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
    internal class ComprasModel
    {
        private SqlCommand comandoConexion;
        private SqlDataReader lector;
        private string consultaSQL;
        private DateTime fecha = DateTime.Now;



        Conexion obj = new Conexion();

        // 1.0 metodo para el llenado del comboBox Proveedores
        private string[,] datosCbxProveedores()
        {

            var listaArrayProveedor = new List<string>();
            var listaArrayID = new List<string>();


            string[,] datos;



            obj.getConexionDB().Open();

            consultaSQL = "SELECT id_Proveedor, nombreProveedor FROM tbProveedores";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();



            while (lector.Read())
            {

                listaArrayID.Add((string)lector["id_Proveedor"].ToString());
                listaArrayProveedor.Add((string)lector["nombreProveedor"]);

            }
            lector.Close();
            obj.getConexionDB().Close();

            datos = new string[listaArrayProveedor.Count, 2];


            for (int k = 0; k < listaArrayProveedor.Count; k++)
            {
                for (int i = 0; i <= 0; i++)
                {

                    datos[k, i] = listaArrayID[k].ToString();

                }
                for (int j = 1; j <= 1; j++)
                {
                    datos[k, j] = (string)listaArrayProveedor[k];
                }

            }

 
            return datos;


        }

        // 1.1 metodo para acceder datosCbxProveedores();

        public string [,] getDatosCbxProveedores()
        {

            return datosCbxProveedores();
        }

        // 1.0 metodo para el llenado del comboBox Categoria
        private string[,] datosCbxCategoriaCompras()
        {

            var listaArrayCategoria = new List<string>();
            var listaArrayIDC = new List<string>();


            string[,] datos;



            obj.getConexionDB().Open();

            consultaSQL = "SELECT id_categoria, nombreCategoria FROM tbCategoria";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();



            while (lector.Read())
            {

                listaArrayIDC.Add((string)lector["id_categoria"].ToString());
                listaArrayCategoria.Add((string)lector["nombreCategoria"]);

            }
            lector.Close();
            obj.getConexionDB().Close();

            datos = new string[listaArrayCategoria.Count, 2];


            for (int k = 0; k < listaArrayCategoria.Count; k++)
            {
                for (int i = 0; i <= 0; i++)
                {

                    datos[k, i] = listaArrayIDC[k].ToString();

                }
                for (int j = 1; j <= 1; j++)
                {
                    datos[k, j] = (string)listaArrayCategoria[k];
                }

            }


            return datos;


        }

        // 1.1 metodo para acceder datosCbxCategoriaCompras();
        public string[,] getDatosCbxCategoriaCompras()
        {

            return datosCbxCategoriaCompras();
        }


        //***************** 2.0 datos para el llenado del dataGrigView ******************************
        private string[,] datosDataGrieViewComprasModel()
        {

            string[,] datosDtgCompras;
            string[,] datosIdImagenCompras;

            var listaComprasID = new List<string>();
            var listaProductoID = new List<string>();
            var listaImagenID = new List<string>();
            //var listaDosIDimagen = new List<string>();
            var listaRutaImagen = new List<string>();
            var listaNombreCompra = new List<string>();
            //var listaDescripcion = new List<string>();
            var listaCantidad = new List<string>();
            var listaPrecio = new List<string>();
            var listaNumFactura = new List<string>();
            //var listaDescuento = new List<string>();
            var listaUsuarioID = new List<string>();
            var listaProveedorID = new List<string>();
            var listaCompraDetalleID = new List<string>();
            var listaFechaCompra = new List<string>();
            //var listaIDcompraEncabezado = new List<string>();


            obj.getConexionDB().Open();

            consultaSQL = "select id_compra, id_usuario, id_proveedor, id_producto, id_compra_detalle, fechaCompra   from tbCompra_encabezado";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read())
            {



                listaComprasID.Add((string)lector["id_compra"].ToString());
                listaUsuarioID.Add((string)lector["id_usuario"].ToString());
                listaProveedorID.Add((string)lector["id_proveedor"].ToString());
                listaProductoID.Add((string)lector["id_producto"].ToString());
                listaCompraDetalleID.Add((string)lector["id_compra_detalle"].ToString());
                 listaFechaCompra.Add((string)lector["fechaCompra"].ToString());
                 //listaFechaCap.Add((string)lector["fechaCaptura"].ToString());

            }
            lector.Close();
            obj.getConexionDB().Close();


            //separar consultas
            obj.getConexionDB().Open();

            consultaSQL = "select nombre_productoCom, numFacturaCompra, cantProdComprado, precioProdCompra from tbCompra_detalle";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read())
            {
                listaNombreCompra.Add((string)lector["nombre_productoCom"].ToString());
                listaNumFactura.Add((string)lector["numFacturaCompra"].ToString());
                listaCantidad.Add((string)lector["cantProdComprado"].ToString());
                listaPrecio.Add((string)lector["precioProdCompra"].ToString());
            }

            lector.Close();
            obj.getConexionDB().Close();

            //para extraer el id de la imagen y su path

            obj.getConexionDB().Open();
            consultaSQL = "select id_imagen, rutaImagen from tbImagenes";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read())
            {

                listaImagenID.Add(lector["id_imagen"].ToString());
                listaRutaImagen.Add(lector["rutaImagen"].ToString());
                //listaIDcompraEncabezado.Add(lector["id_compra"].ToString());

            }
            lector.Close();
            obj.getConexionDB().Close();

            

            datosIdImagenCompras = new string[listaImagenID.Count, 2];
            datosDtgCompras = new string[listaComprasID.Count, 11];

            for (int k = 0; k < listaImagenID.Count; k++)
            {

                datosIdImagenCompras[k, 0] = listaImagenID[k];
                datosIdImagenCompras[k, 1] = listaRutaImagen[k];
                //datosIdImagenCompras[k, 2] = listaIDcompraEncabezado[k];
            }


            for (int i = 0; i < listaComprasID.Count; i++)
            {


                datosDtgCompras[i, 0] = listaComprasID[i];
                datosDtgCompras[i, 1] = listaUsuarioID[i];
                datosDtgCompras[i, 2] = listaProveedorID[i];
                datosDtgCompras[i, 3] = listaProductoID[i];
                datosDtgCompras[i, 4] = listaCompraDetalleID[i];
               datosDtgCompras[i, 5] = listaNombreCompra[i];
                datosDtgCompras[i, 6] = listaNumFactura[i];
                datosDtgCompras[i, 7] = listaCantidad[i];
                datosDtgCompras[i, 8] = listaPrecio[i];
                datosDtgCompras[i,9] = listaFechaCompra[i];
                datosDtgCompras[i,10] = listaImagenID[i];
                for (int j = 0; j < datosIdImagenCompras.GetLength(0); j++)
                {
                   if (datosDtgCompras[i, 10] == datosIdImagenCompras[j, 0])
                    {
                       datosDtgCompras[i, 10] = listaRutaImagen[j];
                    }
                }


            }



            return datosDtgCompras;
        }

        //******************** 2.1 metodo para acceder a  datosDataGrieView()*****************************

        public string[,] getDatosDataGrieViewComprasModel()
        {
            return datosDataGrieViewComprasModel();
        }


        //********************* 3.0 metodo para registrar los datos en la tabla ComprasDetalle / imagenes / ComprasCabecera ***************************

        private void datosInsertarTabComprasImagenesModel(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            string [,] datosInsert = new string[1,10];
            int uIDcompraDetalle = 0;

            datosInsert[0,0] = a; // nombre_productoCom
            datosInsert[0,1] = b; // numFacturaCompra
            datosInsert[0,2] = c; // cantProdComprado
            datosInsert[0,3] = d; // precioProdCompra
            datosInsert[0,4] = e; // IVA_compra
            datosInsert[0,5] = f; // descuentoCompra
            datosInsert[0,6] = g; // descripcionCompraProd
            datosInsert[0,7] = h; // idProveedor
            datosInsert[0,8] = i; // rutaImagen
            datosInsert[0,9] = j; // categoria
           // datosInsert[0,9] = j; // 
           // datosInsert[0,10] = k;// 

            //try
            //{
                //insercion de datos a la tabla compraDetalle
                obj.getConexionDB().Open();
                consultaSQL = "INSERT INTO tbCompra_detalle (nombre_productoCom, numFacturaCompra, cantProdComprado, precioProdCompra, IVA_compra, descuentoCompra, descripcionCompraProd) values ('"+datosInsert[0,0]+"','"+datosInsert[0,1]+"','"+int.Parse(datosInsert[0,2])+"','"+double.Parse(datosInsert[0,3])+"','"+double.Parse(datosInsert[0,4])+"','"+double.Parse(datosInsert[0,5])+"','"+datosInsert[0,6]+"')";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();

                lector.Close();
                obj.getConexionDB().Close();


                //extraccion del ide de la compraDetalle para combinarlo con la tabla compraCabecera
                obj.getConexionDB().Open();
                consultaSQL = "SELECT TOP(1) id_compraDetalle FROM tbCompra_detalle ORDER BY id_compraDetalle DESC";
                comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();
            string loque;
            while (lector.Read())
            {

                 loque = lector["id_compraDetalle"].ToString();
                uIDcompraDetalle = int.Parse(loque);
            }
            

            

                lector.Close ();
                obj.getConexionDB().Close();

                //llamada al metodo para obtencion del idCategoria

               // int idCat = idCategoriaRetorno(datosInsert[0,9]);

            //insercion de imagen en la tabla mas obtencion de id
            Console.WriteLine("" + datosInsert[0, 9]);
                int idIMG = idImagenRetorno(datosInsert[0, 8], int.Parse(datosInsert[0,9]), "generic");

                //Insercion de datos a la tabla articulos para obtener su id

                obj.getConexionDB ().Open();
                consultaSQL = "INSERT INTO tbArticulos (id_categoria, id_imagen, id_usuario, nombreArticulo, descripcionArt, cantidad, precio, fechaCaptura) values ('" + datosInsert[0, 9] + "','" + idIMG + "','"+1+"','"+datosInsert[0,0]+"','"+datosInsert[0,6]+"','"+int.Parse(datosInsert[0,2])+"','"+double.Parse(datosInsert[0,3])+"','"+fecha+"')";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion .ExecuteReader();
                lector.Close ();
                obj.getConexionDB () .Close ();


                //retorno de el id del articulo
                obj.getConexionDB().Open();
                consultaSQL = "SELECT TOP(1) id_producto FROM tbArticulos ORDER BY id_producto DESC";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
                lector = comandoConexion.ExecuteReader();
            int idArticuloRe=0;
            while (lector.Read()) {

                idArticuloRe = int.Parse(lector["id_producto"].ToString());
            }
             

                lector.Close();
                obj.getConexionDB().Close();

                
                //Insercion de datos a la tabla compraCabecera
                obj.getConexionDB ().Open();
                consultaSQL = "INSERT INTO tbCompra_encabezado (id_proveedor, id_producto, id_usuario, id_compra_detalle, fechaCompra) values ('"+int.Parse(datosInsert[0,7])+"','"+idArticuloRe+"','"+1+"','"+uIDcompraDetalle+"','"+fecha+"')";
                comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());    
                lector= comandoConexion .ExecuteReader();   
                lector.Close () ;
                obj.getConexionDB ().Close();

           // }catch (Exception)
           // {

           // }
                
            
        }

        public void getDatosInsertarTabComprasImagenes(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {

            datosInsertarTabComprasImagenesModel(a, b, c, d, e, f, g, h, i, j);
        }

        //metodo para obtener el id de la categoria
        private int idCategoriaRetorno(string nombreCategoria)
        {
            int idCategoriaReturn = 0;

            obj.getConexionDB ().Open();
            consultaSQL = "SELECT id_categoria FROM tbCategoria WHERE nombreCategoria='"+nombreCategoria+"'";
            comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read())
            {
                idCategoriaReturn = int.Parse(lector["id_categoria"].ToString());
            }
            

            lector.Close ();
            obj.getConexionDB().Close();

            
            return idCategoriaReturn;
        }


        //metodo para insertar datos en la tabla imagen y a su vez obtener el id
        private int idImagenRetorno(string rutaImagenC, int categoriaId, string nombreImagen)
        {
            int idImagenReturn = 0;
            

            

            obj.getConexionDB().Open();
            consultaSQL = "INSERT INTO tbImagenes (id_categoria, nombreImagen, rutaImagen, fechaSubida) values ('"+categoriaId+"','"+nombreImagen+"','"+rutaImagenC+"','"+fecha+"')";
            comandoConexion= new SqlCommand (consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();  

           lector.Close();
           obj.getConexionDB().Close();    

           obj.getConexionDB().Open ();
           consultaSQL = "SELECT TOP(1) id_imagen FROM tbImagenes ORDER BY id_imagen DESC";
           comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
           lector= comandoConexion.ExecuteReader();

            while (lector.Read())
            {
                idImagenReturn = int.Parse(lector["id_imagen"].ToString());
            }
            

            lector.Close ();
           obj.getConexionDB().Close ();   

             

            return idImagenReturn;
        }

        //metodo de consulta si ya existe el path de la imagen en la base de datos

        private bool  comprobarPathIMG(string rutaPath)
        {
            string comprobarRuta = "";

            obj.getConexionDB().Open();
            consultaSQL = "SELECT rutaImagen FROM tbImagenes WHERE rutaImagen='"+rutaPath+"'";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            if (lector.Read())
            {
                comprobarRuta = lector["rutaImagen"].ToString();
            }

            lector.Close();
            obj.getConexionDB ().Close ();

            if (rutaPath.Equals(comprobarRuta))
            {
                return true;
            }
            else
            {
               return false;
            }

             
        }

        //metodo para acceder a comprobarPathIMG

        public bool getComprobarPathIMG(string ruta)
        {

            return comprobarPathIMG(ruta);
        }

    }
}
