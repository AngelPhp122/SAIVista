using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    internal class ProductosController
    {
        SAIModelo.mainModelo oModelo = new SAIModelo.mainModelo();

        //1.0 controlador que envia los datos para la insercion en la tabla articulos
        private void recibeDatos(string a, string b, string c, string d, string e, string f)
        {

            string[] datos = new string[6];
            datos[0] = a;
            datos[1] = b;
            datos[2] = c;
            datos[3] = d;
            datos[4] = e;
            datos[5] = f;

            oModelo.insertarDatosMainModel(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);

        }

        //1.1 metodo para acceder a recibeDatos
        public void getRecibeDatos(string getA, string getB, string getC, string getD, string getE, string getF) {

            recibeDatos(getA,getB,getC, getD, getE, getF);

        }


        //2.0 controlador para el llenado del comboBox
        private string[,] datosCbxCategoria()
        {

            string[,] datos;

            datos = oModelo.datosCbxCategoriaMainModel();



            return datos;

        }

        //2.1 metodo para acceder a datosCbxCategoria
        public string [,] getDatosCbxCategoria()
        {

            return datosCbxCategoria();
        }



        //3.0 controlador para el llenado del dataGriewView
        //
        private string[,] datosDtgArticulos()
        {

            string[,] datos;

            datos = oModelo.datosDataGrieViewMainModel();


            return datos;

        }

        //3.1 metodo para acceder a datosDtgArticulos()

        public string[,] getDatosDtgArticulos() { 
        
            return datosDtgArticulos(); 
        }

        //4.0 controlador para la eliminacion de datos de la tabla articulos
        private void eliminarDatosController(int idProductoController)
        {


            oModelo.eliminarDatosModeloMainModel(idProductoController);

        }

        //4.1 metodo para acceder a eliminarDatosController()

        public void getEliminarDatosController(int idProductoGet)
        {

            eliminarDatosController(idProductoGet);
        }

        //5.0 controlador para la actualizacion de datos de la tabla articulos
        private void actualizarDatosController(int idProdcutoMC, int idCategoria, int idImagen, string nombreProducto, string descripcionArt, int cantidadP, double precioP)
        {
            oModelo.actualizarDatosModeloMainModel(idProdcutoMC, idCategoria, idImagen, nombreProducto, descripcionArt, cantidadP, precioP);

        }

        //5.1 metodo para acceder a actualizarDatosController()
        public void getActualizarDatosController(int idProdcutoMC, int idCategoria, int idImagen, string nombreProducto, string descripcionArt, int cantidadP, double precioP) {

            actualizarDatosController(idProdcutoMC, idCategoria, idImagen, nombreProducto, descripcionArt, cantidadP, precioP);
        }

        //6.0 controlador para el retorno del id de imagen en el proceso de actualizacion de datos de la tabla articulos
        private int retornoIDimagenActualizar(string rutaImgUpdate, int IdProductoController, bool imagenExistenteController)
        {


            int idImagenModelReturn = oModelo.retornoIdimagenUpdateModelMainModel(rutaImgUpdate, IdProductoController, imagenExistenteController);

            return idImagenModelReturn;

        }

        //6.1 metodo para acceder a retornoIDimagenActualizar()

        public int getRetornoIDimagenActualizar(string rutaImgUpdate, int IdProductoController, bool imagenExistenteController)
        {
            return retornoIDimagenActualizar(rutaImgUpdate, IdProductoController, imagenExistenteController);
        }


        //7.0 controlador para la insercion de una nueva imagen que actualizara la ya existente para el index en curso a editar
        private void insertDimagenUpdate(string nRutaImagenUpdate, int categoriaUpdate)
        {
            oModelo.insertarRutaImagenMainModel(nRutaImagenUpdate, categoriaUpdate.ToString());

        }

        //7.1 metodo para acceder a insertDimagenUpdate()
        public void getInsertDimagenUpdate(string nRutaImagenUpdate, int categoriaUpdate)
        {

            insertDimagenUpdate(nRutaImagenUpdate, categoriaUpdate);

        }


    }
}
