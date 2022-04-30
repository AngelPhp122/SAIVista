using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    public class mainController
    {

        ProductosController oProductosController = new ProductosController();
        ComprasController oComprasController = new ComprasController();
        TiposUsuarioController oTiposUsuario = new TiposUsuarioController();
        UsuariosControl oUsuario = new UsuariosControl();
        ReportesController oReportesController = new ReportesController();
        CategoriasControl oCategoriasControl = new CategoriasControl();

        //***************** Inicia controladores del mantenimiento de la tabla Categorias ************************************

        public DataTable llenar_comboBoxIdUsrCat()
        {
            return oCategoriasControl.llenar_comboBoxIdUsrCat();
        }

        public DataTable consulta_a_dgvCat()
        {
            return oCategoriasControl.consulta_a_dgvCat();
        }


        public Boolean comprobarRegistroCat(string buscar)
        {
            return oCategoriasControl.comprobarRegistroCat(buscar);
        }

        public Boolean instruccion_sqlCat(string opcion, string[] valores)
        {
            return oCategoriasControl.instruccion_sqlCat(opcion, valores);
        }

        //****************************** finaliza controladores del mantenimiento de la tabla Categorias **********************************


        //***************** Inicia controladores del mantenimiento de la tabla Usuarios ************************************

        public DataTable llenar_comboBoxUsr()
        {
            return oUsuario.llenar_comboBoxUsr();
        }

        public DataTable consulta_a_dgvUsr()
        {
            return oUsuario.consulta_a_dgvUsr();
        }


        public Boolean comprobarRegistroUsr(string buscar)
        {
            return oUsuario.comprobarRegistroUsr(buscar);
        }

        public Boolean instruccion_sqlUsr(string opcion, string[] valores)
        {
            return oUsuario.instruccion_sqlUsr(opcion, valores);
        }

        //****************************** finaliza controladores del mantenimiento de la tabla Usuarios **********************************



        //***************** Inicia controladores del mantenimiento de la tabla Tipos Usuarios ************************************


        public DataTable consulta_a_dgv()
        {
            return oTiposUsuario.consulta_a_dgv();
        }


        public Boolean comprobarRegistro(string buscar)
        {
            return oTiposUsuario.comprobarRegistro(buscar);
        }

        public Boolean instruccion_sql(string opcion, string[] valores)
        {
            return oTiposUsuario.instruccion_sql(opcion, valores);
        }

        //****************************** finaliza controladores del mantenimiento de la tabla Tipos Usuarios **********************************





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

        //***************** Inicia controladores del mantenimiento de la tablas Compras (Compras detalle y compras encabezado) ************************************

        public string [,] datosCbxProveedorMainController()
        {

            return oComprasController.getDatosCbxProveedoresComprasController();
        }

        public string [,] datosDtgComprasMainController()
        {

            return oComprasController.getDatosDtgComprasController();
        }

        public string [,] datosCbxCategoriaComprasMainController()
        {
            return oComprasController.getDatosCbxCategoriaComprasController();
        }
        public void datosInsertarTabComprasImagenesMainController(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            oComprasController.getDatosInsertarTabComprasImagenesController(a, b, c, d, e, f, g, h, i, j);
        }
        
        public bool comprobarPathIMGMainController(string pathl)
        {

            return oComprasController.getComprobarPathIMGController(pathl);
        }

        public void actualizarDatosTabCompraDetalleMainController(int idCompraDatos, string nom, string numF, int cantPrCom, double prPrCom, double IVAcompraM, double descuentoCo, string descrC, string idProveedorCo, string idCatPro, string rutaImagenMod)
        {
            oComprasController.getModificarTabComprasDetalleController(idCompraDatos, nom, numF, cantPrCom, prPrCom, IVAcompraM, descuentoCo,descrC, idProveedorCo, idCatPro, rutaImagenMod);
        }

        public void eliminarDatosTabComprasMainController(int idEliminarC)
        {
            oComprasController.getDatosEliminarTabCompra(idEliminarC);
        }

        //****************************** finaliza controladores del mantenimiento de la  tablas Compras (Compras detalle y compras encabezado)**********************************

        //***************************** inicia Controladores para generar reportes ****************************************************

        public string [,] datosReportesComprasMainController(string fechaInicial, string fechaFInal)
        {
            return oReportesController.getRecibeDatosReportesController(fechaInicial, fechaFInal);
        }

        //***************************** i Controladores para generar reportes ****************************************************


    }
}
