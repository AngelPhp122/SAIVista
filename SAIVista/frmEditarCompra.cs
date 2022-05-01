using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIVista
{
    public partial class frmEditarCompra : Form
    {
        SAIControlador.mainController oComprasModificacionController = new SAIControlador.mainController();
        private string rutaImagenCompras;
        private const double IVA = 0.13;
        private string[,] d;
        private string[,] b;
       
        private string[] datos2Compras;
        private string[] datos3Compras;

        private string[] datosCajas = new string [9];

        int capturaIdCompra;
        public frmEditarCompra(int idCompraModificar)
        {

            capturaIdCompra = idCompraModificar;
            InitializeComponent();
        }

        private void btnAceptarCompra_Click(object sender, EventArgs e)
        {

            datosCajas[0] = tbxNombreProComp.Text;
            datosCajas[1] = tbxFacturaCompra.Text;
            datosCajas[2] = tbxCantidadProduComMod.Text;
            datosCajas[3] = tbxPrecioProdCompra.Text;
            datosCajas[4] = tbxDescripcionCompra.Text;
            datosCajas[5] = calculoIVA().ToString();
            tbxIVAcompra.Text = datosCajas[5];
            datosCajas[6] = /*tbxDescuentoCompra.Text;*/ "0.00";
            tbxDescuentoCompra.Text = datosCajas[6];
            datosCajas[7] = cbxProveedorCompra.Text;
            datosCajas[8] = cbxCategoriaCompra.Text;

            oComprasModificacionController.actualizarDatosTabCompraDetalleMainController(capturaIdCompra, datosCajas[0],datosCajas[1],int.Parse(datosCajas[2]), double.Parse(datosCajas[3]), double.Parse(datosCajas[5]), double.Parse(datosCajas[6]), datosCajas[4] , datosCajas[7], datosCajas[8],rutaImagenCompras);

        }

        private void frmEditarCompra_Load(object sender, EventArgs e)
        {


             string[,] idProveedores;
             string[,] idCategorias;

            try
            {
                //validacion de combobox vacio
                int comprobar1;
                int comprobar2;
                comprobar1 = cbxProveedorCompra.Items.Count;
                comprobar2 = cbxCategoriaCompra.Items.Count;

                if (comprobar1 == 0)
                {
                    d = oComprasModificacionController.datosCbxProveedorMainController();
                    idProveedores = d;
                    //MessageBox.Show(""+idProveedores.GetLength(0));
                    datos2Compras = new string[d.Length / 2];

                    for (int i = 0; i < (d.Length / 2); i++)
                    {

                        //cbxCategoria.DataSource = d;
                        cbxProveedorCompra.Items.Add(d[i, 1]);
                        datos2Compras[i] = d[i, 0];

                        //cbxCategoria.ValueMember = d[i, 0];


                    }

                }

                if (comprobar2 == 0)
                {
                    b = oComprasModificacionController.datosCbxCategoriaComprasMainController();
                    idCategorias = b;
                    //MessageBox.Show(idCategorias[0,1]);
                    datos3Compras = new string[b.Length / 2];

                    for (int i = 0; i < (b.Length / 2); i++)
                    {

                        //cbxCategoria.DataSource = d;
                        cbxCategoriaCompra.Items.Add(b[i, 1]);
                        datos3Compras[i] = b[i, 0];

                        //cbxCategoria.ValueMember = d[i, 0];


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            
        }

        private void btnModificarImagenCompra_Click(object sender, EventArgs e)
        {
            if (openFileDialogCompraMod.ShowDialog() == DialogResult.OK)
            {
                bool comprobar = true;
                comprobar = oComprasModificacionController.comprobarPathIMGMainController(openFileDialogCompraMod.FileName);

                if (comprobar == false)
                {
                    rutaImagenCompras = openFileDialogCompraMod.FileName;
                }
                else
                {
                    MessageBox.Show("la imagen que usted esta seleccionando ya existe en la base de datos");
                }

                Form oFormaTablaCompra = new frmCompras();

                Close();
                oFormaTablaCompra.Show();
            }
        }

        
        public double calculoIVA()
        {
            double calculoIva = 0;
            double multiplicacion = 0;
           // MessageBox.Show(datosCajas[2]);
            //MessageBox.Show(datosCajas[3]);
            multiplicacion = (double.Parse(datosCajas[2]) * (double.Parse(datosCajas[3])));
            
            calculoIva = multiplicacion * IVA;

            return calculoIva; 
        }

       

    }
}
