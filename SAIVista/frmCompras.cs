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
    public partial class frmCompras : Form
    {
        
        SAIControlador.mainController oControladorCompras = new SAIControlador.mainController();

        private string[] datos2Compras;
        private string[] datos3Compras;
        private string[,] idProveedores;
        private string[,] idCategorias;
        private string rutaImagenCompras;
        private const double IVA = 0.13;

        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            string[,] d;
            string[,] b;

            try
            {
                //validacion de combobox vacio
                int comprobar1;
                int comprobar2;
                comprobar1 = cbxProveedor.Items.Count;
                comprobar2 = cbxCategoria.Items.Count;

                if (comprobar1 == 0)
                {
                    d = oControladorCompras.datosCbxProveedorMainController();
                    idProveedores = d;
                    //MessageBox.Show(""+idProveedores.GetLength(0));
                    datos2Compras = new string[d.Length / 2];

                    for (int i = 0; i < (d.Length / 2); i++)
                    {

                        //cbxCategoria.DataSource = d;
                        cbxProveedor.Items.Add(d[i, 1]);
                        datos2Compras[i] = d[i, 0];

                        //cbxCategoria.ValueMember = d[i, 0];


                    }

                }




                if (comprobar2 == 0)
                {
                    b = oControladorCompras.datosCbxCategoriaComprasMainController();
                    idCategorias = b;
                    //MessageBox.Show(idCategorias[0,1]);
                    datos3Compras = new string[b.Length / 2];

                    for (int i = 0; i < (b.Length / 2); i++)
                    {

                        //cbxCategoria.DataSource = d;
                        cbxCategoria.Items.Add(b[i, 1]);
                        datos3Compras[i] = b[i, 0];

                        //cbxCategoria.ValueMember = d[i, 0];


                    }

                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            int comprobar;

            //try
            //{

                comprobar = dtgCompras.Rows.Count;
                dtgCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //MessageBox.Show(""+comprobar);
                DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c10=  new DataGridViewTextBoxColumn();
                DataGridViewImageColumn   c11 = new DataGridViewImageColumn();
                
                //DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();

                //estructura de control que no permite la duplicacion de la tabla
                if (comprobar == 0)
                {

                    c1.HeaderText = "id compra";
                    c2.HeaderText = "id usuario";
                    c3.HeaderText = "id proveedor";
                    c4.HeaderText = "id producto";
                    c5.HeaderText = "id compra detalle";
                    c6.HeaderText = "Nombre Producto";
                    c7.HeaderText = "Factura No.";
                    c8.HeaderText = "Cantidad Producto";
                    c9.HeaderText = "Precio producto";
                    c10.HeaderText = "fecha de Compra";
                    c11.HeaderText = "Imagen";

                    dtgCompras.Columns.Add(c1);
                    dtgCompras.Columns.Add(c2);
                    dtgCompras.Columns.Add(c3);
                    dtgCompras.Columns.Add(c4);
                    dtgCompras.Columns.Add(c5);
                    dtgCompras.Columns.Add(c6);
                    dtgCompras.Columns.Add(c7);
                    dtgCompras.Columns.Add(c8);
                    dtgCompras.Columns.Add(c9);
                    dtgCompras.Columns.Add(c10);
                    dtgCompras.Columns.Add(c11);
                    

                    dtgCompras.Columns[10].Width = 325;
                    
                    string[,] c;
                    c = oControladorCompras.datosDtgComprasMainController();
                    //MessageBox.Show(c[0,9]);

                    if (c.GetLength(0) >= 0)
                    {


                        for (int i = 0; i < c.GetLength(0); i++)
                        {

                            dtgCompras.Rows.Add(c[i, 0], c[i, 1], c[i, 2], c[i, 3], c[i, 4], c[i, 5], c[i,6], c[i,7], c[i,8], c[i,9], Image.FromFile(c[i, 10]));
                            dtgCompras.Rows[i].Cells[6].Tag = c[i, 10];
                            


                        }
                    }

                }
                else
                {


                    string[,] c;

                    c = oControladorCompras.datosDtgComprasMainController();

                    //MessageBox.Show("arreglo c "+ c.Length);

                    int indiceA = c.GetLength(0) - 1;


                    dtgCompras.Rows.Add(c[indiceA, 0], c[indiceA, 1], c[indiceA, 2], c[indiceA, 3], c[indiceA, 4], c[indiceA, 5], c[indiceA,6], c[indiceA, 7], c[indiceA,8], c[indiceA, 9], Image.FromFile(c[indiceA, 10]));
                    dtgCompras.Rows[indiceA].Cells[10].Tag = c[indiceA, 10];
                    dtgCompras.Columns[10].Width = 325;
                }


                //string seleccionFila = dtgArticulos.CurrentRow.ToString();

                //           MessageBox.Show("datoSeleccionado "+ seleccionFila);



          //  }
           //catch (Exception ex)
           //{

          //      MessageBox.Show(ex.Message);
//            }
            
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
             string[] datos = new string [10];
             //string[,] datos2;


           datos[0] =  tbxNombreProducto.Text;
           datos[1] = txbNumeroFactura.Text;
           datos[2] = tbxCantProductoComprado.Text;
           datos[3] = tbxPrecioProdCompra.Text;
            double resultIVAComp = ((int.Parse(datos[2])) * (double.Parse(datos[3]))) * IVA;
            datos[4] =  resultIVAComp.ToString();
           datos[5] =  tbxDescuentoComp.Text;
            datos[6] = tbxDescripcionCompra.Text;

            for(int i = 0; i < idProveedores.GetLength(0); i++)
            {
                if (cbxProveedor.Text.Equals(idProveedores[i,1]))
                {
                    datos[7] = idProveedores[i,0];
                }
                
            }

            for(int j = 0; j < idCategorias.GetLength(0); j++)
            {
                if (cbxCategoria.Text.Equals(idCategorias[j, 1]))
                {
                    datos[9] = idCategorias[j, 0];
                }
            }
            
           datos[8] = rutaImagenCompras;

            MessageBox.Show(datos[9]);
            
            oControladorCompras.datosInsertarTabComprasImagenesMainController(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], datos[9]);

            frmCompras_Load(sender, e);

        }

        private void btnImagenCompra_Click(object sender, EventArgs e)
        {
            if (openFileDialogCompra.ShowDialog() == DialogResult.OK)
            {
                bool comprobar = true;
               comprobar =  oControladorCompras.comprobarPathIMGMainController(openFileDialogCompra.FileName);

                if(comprobar == false) {
                    rutaImagenCompras = openFileDialogCompra.FileName;
                }
                else
                {
                    MessageBox.Show("la imagen que usted esta seleccionando ya existe en la base de datos");
                }
                
            }
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            int datoIdEnvio = int.Parse(dtgCompras.SelectedRows[0].Cells[0].Value.ToString());

            Form oFrmEditarCompra = new frmEditarCompra(datoIdEnvio);

            oFrmEditarCompra.Show();
        }
    }
}
    

