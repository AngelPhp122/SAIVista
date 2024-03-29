﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    internal class ComprasController
    {

        SAIModelo.mainModelo oComprasModelo = new SAIModelo.mainModelo();

        //1.0 controlador para el llenado del comboBox
        private string[,] datosCbxProveedoresController()
        {

            string[,] datos;

            datos = oComprasModelo.datosCbxProveedorMainModel();

            return datos;

        }

        //1.1 metodo para acceder a datosCbxProveedores
        public string[,] getDatosCbxProveedoresComprasController()
        {

            return datosCbxProveedoresController();
        }

        //2.0 controlador para el llenado del dataGriewView
        //
        private string[,] datosDtgComprasController()
        {

            string[,] datos;

            datos = oComprasModelo.datosDataGridViewCompraMainModel();


            return datos;

        }

        //2.1 metodo para acceder a datosDtgArticulos()

        public string[,] getDatosDtgComprasController()
        {

            return datosDtgComprasController();
        }

        // 3.0 controlador para la insercion de datos en tabla compra, articulos e imagenes
        private void datosInsertarTabComprasImagenesController(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            oComprasModelo.datosInsertarTabComprasImagenesMainModel(a, b, c, d, e, f, g, h, i, j);

        }

        // 3.1 metodo para acceder datosInsertarTabComprasImagenesController
        public void getDatosInsertarTabComprasImagenesController(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {

            datosInsertarTabComprasImagenesController(a, b, c, d, e, f, g, h, i, j);
        }


        // 4.0 controlador para el llenado del combobox categoria

        private string[,] datosCbxCategoriaComprasController()
        {

            string[,] datos;

            datos = oComprasModelo.datosCbxCategoriaComprasMainModel();

            return datos;

        }


        //4.1 metodo para acceder a datosCbxCategoriaCompras()
        public string[,] getDatosCbxCategoriaComprasController()
        {

            return datosCbxCategoriaComprasController();
        }


        //5.0 controlador para comprobar ruta
        private bool comprobarPathIMGController(string rpath)
        {

            return oComprasModelo.comprobarPathIMGMainModel(rpath);
        }

        //metodo para acceder comprobar path
        public bool getComprobarPathIMGController(string rrpath)
        {

            return comprobarPathIMGController(rrpath);
        }

        //6.0 controlador para modificar datos de la compra
        private void datosModificarTabComprasDetalleController(int idCompraDatos, string nom, string numF, int cantPrCom, double prPrCom, double IVAcompraM, double descuentoCo, string descrC, string idProveedorCo, string idCatPro, string rutaImagenMod)
        {
            oComprasModelo.datosModificarTabComprasDetalleMainModel(idCompraDatos, nom, numF, cantPrCom, prPrCom, IVAcompraM, descuentoCo,descrC, idProveedorCo, idCatPro, rutaImagenMod);
        }

        public void getModificarTabComprasDetalleController(int idCompraDatos, string nom, string numF, int cantPrCom, double prPrCom, double IVAcompraM, double descuentoCo, string descrC, string idProveedorCo, string idCatPro, string rutaImagenMod)
        {
            datosModificarTabComprasDetalleController(idCompraDatos, nom, numF, cantPrCom, prPrCom, IVAcompraM, descuentoCo,descrC, idProveedorCo, idCatPro, rutaImagenMod);
        }

        //7.0 controlador para eliminar datos de la compra

        private void datosEliminarTabCompra(int idCompraEliminar)
        {
            oComprasModelo.eliminarDatosTabCompraMainModel(idCompraEliminar);
        }

        // 7.0 metodo para acceder a datosEliminarTabCompra(int idCompraEliminar)

        public void getDatosEliminarTabCompra(int idCompraElimnar)
        {
            datosEliminarTabCompra(idCompraElimnar);
        }
    }
}
