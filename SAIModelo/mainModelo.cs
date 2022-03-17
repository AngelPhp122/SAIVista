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
        ProductosModel oProductosModel = new ProductosModel();
        ComprasModel oComprasModel = new ComprasModel();


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

    }
}
