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

            string[,] datosIDprodImg;

            string[] temporalIDimagen;

            var listaComprasIDdetalle = new List<string>();
            var listaProductoNombre = new List<string>();
            var listaImagenID = new List<string>();
            var listaDosIDproImg = new List<string>();
            var listaRutaImagen = new List<string>();
            var listaDescripcion = new List<string>();
            var listaCantidad = new List<string>();
            var listaPrecio = new List<string>();
            var listaIVA = new List<string>();
            var listaDescuento = new List<string>();
            var listaCompraEncabezadoID = new List<string>();
            var listaTotalCompra = new List<string>();
            var listaDosIDPRODUCTO = new List<string>();


            obj.getConexionDB().Open();

            consultaSQL = "select id_compraDetalle, nombre_productoCom, cantProdComprado, precioProdCompra, IVA_compra, descuentoCompra, descripcionCompraProd, id_compra_encabezado, tCompraD from tbCompra_detalle";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read())
            {

                listaComprasIDdetalle.Add(lector["id_compraDetalle"].ToString());
                listaProductoNombre.Add(lector["nombre_productoCom"].ToString());
                listaCantidad.Add(lector["cantProdComprado"].ToString());
                listaPrecio.Add(lector["precioProdCompra"].ToString());
                listaIVA.Add(lector["IVA_compra"].ToString());
                listaDescuento.Add(lector["descuentoCompra"].ToString());
                listaDescripcion.Add(lector["descripcionCompraProd"].ToString());
                listaCompraEncabezadoID.Add(lector["id_compra_encabezado"].ToString());
                listaTotalCompra.Add(lector["tCompraD"].ToString());
  

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

            }
            lector.Close();
            obj.getConexionDB().Close();

            //consulta para concatenar el ID del producto con la imagen

            obj.getConexionDB().Open();
            consultaSQL = "Select id_producto, id_imagen from tbArticulos";
            comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
            lector= comandoConexion.ExecuteReader();

            while (lector.Read())
            {
                listaDosIDPRODUCTO.Add(lector["id_producto"].ToString());
                listaDosIDproImg.Add(lector["id_imagen"].ToString());
            }
            
            lector.Close();
            obj.getConexionDB().Close();   

            datosIdImagenCompras = new string[listaImagenID.Count, 2];
            datosDtgCompras = new string[listaComprasIDdetalle.Count, 11];

            datosIDprodImg = new string[listaDosIDPRODUCTO.Count, 2];

            temporalIDimagen = new string[listaImagenID.Count];


            for (int k = 0; k < listaImagenID.Count; k++)
            {

                datosIdImagenCompras[k, 0] = listaImagenID[k];
                datosIdImagenCompras[k, 1] = listaRutaImagen[k];
                //datosIdImagenCompras[k, 2] = listaIDcompraEncabezado[k];
            }

            for (int n = 0; n < listaDosIDPRODUCTO.Count; n++)
            {
               datosIDprodImg[n, 0] = listaDosIDPRODUCTO[n]; // id del producto
               datosIDprodImg[n, 1] = listaDosIDproImg[n];  //id de la imagen

                Console.WriteLine(datosIDprodImg[n, 1]);

            }

           

            for (int i = 0; i < listaComprasIDdetalle.Count; i++)
            {

                
                datosDtgCompras[i, 0] = listaComprasIDdetalle[i];
                datosDtgCompras[i, 1] = listaProductoNombre[i];
                datosDtgCompras[i, 2] = listaCantidad[i];
                datosDtgCompras[i, 3] = listaPrecio[i];
                datosDtgCompras[i, 4] = listaIVA[i];
                datosDtgCompras[i, 5] = listaDescuento[i];
                datosDtgCompras[i, 6] = listaDescripcion[i];
                datosDtgCompras[i, 7] = listaCompraEncabezadoID[i];
                datosDtgCompras[i, 8] = listaTotalCompra[i];
                datosDtgCompras[i, 9] = listaImagenID[i];

                for (int x = 0; x < listaImagenID.Count; x++)
                {
                    temporalIDimagen[x] = listaImagenID[x];
                }
                //datosDtgCompras[i,10] = listaImagenID[i];
                
                for (int j = 0; j < listaImagenID.Count; j++)
                {
                    if (temporalIDimagen[j] == datosIDprodImg[i, 1])
                    {

                        for (int h = 0; h < datosIdImagenCompras.GetLength(0) ;h++)
                        {
                            if (datosIDprodImg[i,1] == datosIdImagenCompras[h,0])
                            {
                                datosDtgCompras[i, 10] = datosIdImagenCompras[h, 1];
                            }
                        }
                                              
                        
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
            int idCompraEncabezado = 0;
            double tCompra = 0.0;
            int idImagen = 0;

            datosInsert[0,0] = a; // numero de factura
            datosInsert[0,1] = b; // nombre_productoCom
            datosInsert[0,2] = c; // cantidad producto
            datosInsert[0,3] = d; // precio producto
            datosInsert[0,4] = e; // descripcion compra
            datosInsert[0,5] = f; // IVA_compra
            datosInsert[0,6] = g; // descuentoCompra
            datosInsert[0,7] = h; // proveedor
            datosInsert[0,8] = i; // categoria
            datosInsert[0,9] = j; // rutaImagen

            tCompra = ((int.Parse(c) * double.Parse(d)) + double.Parse(f)) - double.Parse(g);
            

            //para retornar e ingresar imagen en su tabla
           
            idImagen = idImagenRetorno(j);

            //primero, insercion de datos en la tabla encabezado para poder alojar todos los detalles de compra

            obj.getConexionDB().Open();
            consultaSQL = "INSERT INTO tbCompra_encabezado (id_proveedor, id_usuario, fechaCompra, numFacturaComp, tCompra) values ('"+h+"','"+1+"','"+fecha+"','"+a+"','"+0.00+"')";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();
            lector.Close();
            obj.getConexionDB().Close();

            //query para obtener el valor del ultimo ID de la compra del encabezado.

            obj.getConexionDB().Open();
            consultaSQL = "SELECT TOP(1) id_compra FROM tbCompra_encabezado ORDER BY id_compra DESC";
            comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read())
            {
                idCompraEncabezado = int.Parse((lector["id_compra"].ToString()));
            }
            lector.Close();
            obj.getConexionDB().Close();

            //segundo, insercion de datos en tabla articulo

            obj.getConexionDB().Open();
            consultaSQL = "INSERT INTO tbArticulos (id_categoria, id_imagen, nombreArticulo, descripcionArt, cantidad, precio, fechaCaptura) values ('"+i+"','"+idImagen+"','"+b+"','"+e+"','"+c+"','"+d+"','"+fecha+"')";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();
            lector.Close ();
            obj.getConexionDB().Close();


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


            //insercion de datos en la tabla compra_detalle

            obj.getConexionDB().Open();
            consultaSQL = "INSERT INTO tbCompra_detalle (nombre_productoCom, cantProdComprado, precioProdCompra, IVA_compra, descuentoCompra, descripcionCompraProd, id_producto, id_compra_encabezado, tCompraD, estadoCompra)" +
                "values ('"+b+"', '"+int.Parse(c)+"', '"+double.Parse(d)+"','"+double.Parse(f)+"','"+double.Parse(g)+"','"+e+"','"+idArticuloRe+"','"+idCompraEncabezado+"', '"+tCompra+"','"+true+"')";
            comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
            lector= comandoConexion.ExecuteReader();
            lector.Close();
            obj.getConexionDB().Close ();
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
        private int idImagenRetorno(string rutaImagenC)
        {
            int idImagenReturn = 0;


            obj.getConexionDB().Open();
            consultaSQL = "INSERT INTO tbImagenes (rutaImagen, fechaSubida) values ('"+rutaImagenC+"','"+fecha+"')";
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

        //***************************** Metodo para modificar el dato del Id obtenido en el datagridView ************************************

        private void ModificarDatoComprasModel(int idCompraDatos, string nom, string numF, int cantPrCom, double prPrCom, double IVAcompraM,double descuentoCo,string descrC, string idProveedorCo, string idCatPro, string rutaImagenMod )
        {
            //obtener el id de la categoria
            int CategoriaIdr = idCategoriaRetorno(idCatPro);

            //obtener el id del proveedor
            int ProveedorIDr = retornarIDproveedorComp(idProveedorCo);

            //inserta nueva image, a su vez se obtendra el ID
            int idImagenModificarCompra = idImagenRetorno(rutaImagenMod);


            //actualiza tabla compra detalle
            obj.getConexionDB().Open();
            consultaSQL = "UPDATE tbCompra_detalle SET nombre_productoCom='"+nom+ "', cantProdComprado='"+cantPrCom+"', precioProdCompra='"+prPrCom+"', IVA_compra='"+IVAcompraM+"' , descuentoCompra='"+descuentoCo+"',descripcionCompraProd='"+descrC+ "' WHERE id_compraDetalle ='" + idCompraDatos+"'";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            lector.Close();
            obj.getConexionDB().Close();


            //actualiza tabla compra encabezado
            obj.getConexionDB().Open ();
            consultaSQL = "UPDATE tbCompra_encabezado SET id_proveedor='"+ProveedorIDr+ "'  WHERE id_compra = '" + idCompraDatos+"'";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            lector.Close ();
            obj.getConexionDB().Close ();


            //actualiza tabla articulos
            obj.getConexionDB().Open();
            consultaSQL = "UPDATE tbArticulos SET id_categoria='"+CategoriaIdr+"', id_imagen='"+idImagenModificarCompra+"', nombreArticulo='"+nom+"', descripcionArt='"+descrC+"', cantidad='"+cantPrCom+"', precio='"+prPrCom+"' WHERE id_producto='"+idCompraDatos+"'";
            comandoConexion = new SqlCommand (consultaSQL, obj.getConexionDB());
            lector= comandoConexion.ExecuteReader();
            lector.Close();
            obj.getConexionDB();

        }

        public void getModificarDatoComprasModel(int idCompraDatos, string nom, string numF, int cantPrCom, double prPrCom, double IVAcompraM, double descuentoCo, string descrC, string idProveedorCo, string idCatPro, string rutaImagenMod)
        {
            ModificarDatoComprasModel(idCompraDatos, nom, numF, cantPrCom, prPrCom,IVAcompraM,descuentoCo, descrC, idProveedorCo, idCatPro, rutaImagenMod);
        }


        //metodo para obtener el id del proveedor
        private int retornarIDproveedorComp(string nombreProveedor)
        {
            int idProveedorReturn = 0;

            obj.getConexionDB().Open();
            consultaSQL = "SELECT id_Proveedor FROM tbProveedores WHERE nombreProveedor='" + nombreProveedor + "'";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            while (lector.Read())
            {
                idProveedorReturn = int.Parse(lector["id_Proveedor"].ToString());
            }


            lector.Close();
            obj.getConexionDB().Close();


            return idProveedorReturn;
           
        }


        //************************** Metodo para la eliminacion de la tabla compras detalle y compras encabezados por ID *************************

        private void eliminarDatoTabCompras(int idCompraEliminar)
        {
            

            // tabla compra encabezado
            obj.getConexionDB().Open();
            consultaSQL = "DELETE FROM tbCompra_encabezado WHERE id_compra='" + idCompraEliminar + "'";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            lector.Close();
            obj.getConexionDB().Close();

            //tabla compra detalle
            obj.getConexionDB().Open();
            consultaSQL = "DELETE FROM tbCompra_detalle WHERE id_compraDetalle='" + idCompraEliminar + "'";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            lector.Close();
            obj.getConexionDB().Close();

            //tabla articulos
            obj.getConexionDB().Open();
            consultaSQL = "DELETE FROM tbArticulos WHERE id_producto='" + idCompraEliminar + "'";
            comandoConexion = new SqlCommand(consultaSQL, obj.getConexionDB());
            lector = comandoConexion.ExecuteReader();

            lector.Close();
            obj.getConexionDB().Close();
        }

        public void getEliminarDatoTabCompras(int idCompraEliminar)
        {
            eliminarDatoTabCompras(idCompraEliminar);
        }
    }
}
