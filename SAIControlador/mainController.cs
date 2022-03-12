using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    public class mainController
    {

        SAIModelo.mainModelo oModelo = new SAIModelo.mainModelo();

        

        public void recibeDatos(string a, string b, string c, string d, string e, string f) {

            string[] datos = new string[6];
            datos[0] = a;
            datos[1] = b;
            datos[2] = c;
            datos[3] = d;
            datos[4] = e;
            datos[5] = f;
            
            oModelo.insertarDatos(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);

        }

        //controlador para el llenado del comboBox
        public string[,] datosCbxCategoria() {

            string [,]datos;

            datos =  oModelo.datosCbxCategoria();

        

            return datos;

        }



        //controlador para el llenado del dataGriewView
        //
        public string[,] datosDtgArticulos() {

            string[,] datos;

            datos = oModelo.datosDataGrieView();
            

            return datos;

        }

        //controlador para la eliminacion de datos de la tabla articulos
        public void eliminarDatosController(int idProductoController) {

            
            oModelo.eliminarDatosModelo(idProductoController);

        }
        
        //controlador para la actualizacion de datos de la tabla articulos
        public void actualizarDatosController(int idProdcutoMC, int idCategoria, int idImagen, string nombreProducto, string descripcionArt, int cantidadP, double precioP)
        {
            oModelo.actualizarDatosModelo(idProdcutoMC, idCategoria, idImagen, nombreProducto, descripcionArt, cantidadP, precioP);

        }

        //controlador para el retorno del id de imagen en el proceso de actualizacion de datos de la tabla articulos
        public int retornoIDimagenActualizar(string rutaImgUpdate, int IdProductoController, bool imagenExistenteController) {


            int idImagenModelReturn = oModelo.retornoIdimagenUpdateModel(rutaImgUpdate, IdProductoController, imagenExistenteController);

            return idImagenModelReturn;
        
        }

        //controlador para la insercion de una nueva imagen que actualizara la ya existente para el index en curso a editar
        public void insertDimagenUpdate(string nRutaImagenUpdate, int categoriaUpdate)
        {
            oModelo.insertarRutaImagen(nRutaImagenUpdate, categoriaUpdate.ToString());

        }

    }
}
