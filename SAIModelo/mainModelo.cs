using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace SAIModelo
{

    public class mainModelo
    {
        ProductosModel oProductosModel = new ProductosModel();
        ComprasModel oComprasModel = new ComprasModel();
        TiposUsuarioModel oTiposUsuarioModel = new TiposUsuarioModel();
        UsuariosModel oUsuarioModel = new UsuariosModel();
        ReportesModel oReportesModel = new ReportesModel(); 


        //************************** INICIO DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL USUARIOS ******************************


        public DataTable llenar_comboBoxUsr()
        {
            return oUsuarioModel.llenar_comboBoxUsr();
        }
        public DataTable consulta_a_dgvUsr()
        {
            return oUsuarioModel.consulta_a_dgvUsr();
        }


        public Boolean comprobarRegistroUsr(string buscar)
        {
            return oUsuarioModel.comprobarRegistroUsr(buscar);
        }

        public Boolean instruccion_sqlUsr(string opcion, string[] valores)
        {
            return oUsuarioModel.instruccion_sqlUsr(opcion, valores);
        }


        //************************** FIN DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL USUARIOS ******************************


        //************************** INICIO DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL TABLA USUARIOS ******************************


        public DataTable consulta_a_dgv()
        {
            return oTiposUsuarioModel.consulta_a_dgv();
        }


        public Boolean comprobarRegistro(string buscar)
        {
            return oTiposUsuarioModel.comprobarRegistro(buscar);
        }

        public Boolean instruccion_sql(string opcion, string[] valores)
        {
            return oTiposUsuarioModel.instruccion_sql(opcion, valores);
        }


        //************************** FIN DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL TABLA USUARIOS ******************************


        //************************** INICIO DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL TABLA ARTICULOS ******************************
        public void insertarDatosMainModel(string a, string b, string c, string d, string e, string f)
        {

            oProductosModel.getInsertarDatos(a, b, c, d, e, f);
        }

        public string [,] datosCbxCategoriaMainModel()
        {
            return oProductosModel.getDatosCbxCategoria();
        }

        public string [,] datosDataGrieViewMainModel()
        {
            return oProductosModel.getDatosDataGrieView();
        }

        public void eliminarDatosModeloMainModel(int idProductoModelo)
        {
            oProductosModel.getEliminarDatosModelo(idProductoModelo);

        }

        public void actualizarDatosModeloMainModel(int idProductoAcModelo, int idCategoria, int idImagen, string nombreProducto, string descripcionArt, int cantidadP, double precioP)
        {
            oProductosModel.getActualizarDatosModelo(idProductoAcModelo, idCategoria, idImagen, nombreProducto, descripcionArt, cantidadP, precioP);
        }

        public int retornoIdimagenUpdateModelMainModel(string rutaImgModel, int idProductoModel, bool imagenExistente)
        {
            return oProductosModel.getRetornoIdimagenUpdateModel(rutaImgModel, idProductoModel, imagenExistente); 
        }

        public void insertarRutaImagenMainModel(string rutaImg, string categoriImg)
        {
            oProductosModel.getInsertarRutaImagen(rutaImg, categoriImg);
        }

        //************************** FIN DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL TABLA ARTICULOS ******************************


        //************************** INICIO DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL TABLA COMPRAS ******************************

        public string[,] datosCbxProveedorMainModel()
        {

            return oComprasModel.getDatosCbxProveedores();
        }

        public string[,] datosDataGridViewCompraMainModel()
        {

            return oComprasModel.getDatosDataGrieViewComprasModel();
        }

        public string[,] datosCbxCategoriaComprasMainModel()
        {

            return oComprasModel.getDatosCbxCategoriaCompras();
        }

        public void datosInsertarTabComprasImagenesMainModel(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
        {
            oComprasModel.getDatosInsertarTabComprasImagenes(a, b, c, d, e, f, g, h, i, j);
        }

        public bool comprobarPathIMGMainModel(string pathR)
        {

            return oComprasModel.getComprobarPathIMG(pathR);
        }


        public void datosModificarTabComprasDetalleMainModel(int idCompraDatos, string nom, string numF, int cantPrCom, double prPrCom, double IVAcompraM, double descuentoCo, string descrC, string idProveedorCo, string idCatPro, string rutaImagenMod)
        {
            oComprasModel.getModificarDatoComprasModel(idCompraDatos, nom, numF, cantPrCom, prPrCom,IVAcompraM,descuentoCo, descrC, idProveedorCo, idCatPro, rutaImagenMod);
        }

        public void eliminarDatosTabCompraMainModel(int idDatoEliminarComp)
        {
            oComprasModel.getEliminarDatoTabCompras(idDatoEliminarComp);
        }

        //************************** FIN DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL TABLAS COMPRAS ******************************

        //************************** INICIO DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL REPORTES ******************************


        public string [,]  reportesComprasMainModel(string fechaINICIAL, string fechaFin)
        {
            string[,] arregloDatos;

           arregloDatos = oReportesModel.getDatosReporte(fechaINICIAL, fechaFin);

            return arregloDatos; 
        }

        //************************** FIN DE METODOS PARA LLAMADAS PARA ACCESO A DATOS MAINMODEL REPORTES ******************************

    }
}
