﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    public class mainController
    {

        ProductosController oProductosController = new ProductosController();
       

        //***************** Inicia controladores del mantenimiento de la tabla Articulos (tbArticulos) ************************************
        public string [,] datosCbxCategoriaMainController()
        {

            return oProductosController.getDatosCbxCategoria();

        }

        public void recibeDatosMainController(string cat, string nomb, string desc, string cant, string prec, string rtImg)
        {

            oProductosController.getRecibeDatos(cat, nomb, desc, cant, prec, rtImg);
        }

        public string [,] datosDtgArticulosMainController()
        {
           return oProductosController.getDatosDtgArticulos();
        }


        public void eliminarDatosMainCotroller(int idProductos)
        {

            oProductosController.getEliminarDatosController(idProductos);
        }

        public int retornoIDimagenMainController(string rutaImagen, int idProductoC, bool imagenExisteC)
        {

            return oProductosController.getRetornoIDimagenActualizar(rutaImagen, idProductoC, imagenExisteC);
        }


        public void actualizarDatosMainController(int idProdcutoMC, int idCategoria, int idImagen, string nombreProducto, string descripcionArt, int cantidadP, double precioP)
        {
            oProductosController.getActualizarDatosController(idProdcutoMC, idCategoria, idImagen, nombreProducto, descripcionArt, cantidadP, precioP);
        }

        public void insertDimagenUpdateMainController(string nRutaImagenUpdate, int categoriaUpdate)
        {
            oProductosController.getInsertDimagenUpdate(nRutaImagenUpdate, categoriaUpdate);

        }

        //****************************** finaliza controladores del mantenimiento de la tabla articulos **********************************

    }
}
