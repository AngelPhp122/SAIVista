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
    public partial class frmModificarProducto : Form 
    {
     private  string idproductoM, categoriaM, nombreM, descripcionM, cantidadM, precioM, imgMod;
     private string rutaImagenYaExistente;
        private bool imagenExistente = false;

       

        SAIControlador.mainController oControllerM = new SAIControlador.mainController();

        

        public frmModificarProducto(string idproducto, string categoria, string nombre, string descripcion, string cantidad, string precio, string rutaImagen)
        {
            InitializeComponent();
            idproductoM = idproducto;
            categoriaM = categoria;
            nombreM = nombre;
            descripcionM = descripcion;
            cantidadM = cantidad;
            precioM = precio;
            rutaImagenYaExistente = rutaImagen;
            imgMod = rutaImagenYaExistente;

            MessageBox.Show(rutaImagenYaExistente);
            MessageBox.Show(imgMod);
        }

       
       
        

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                string[,] d;
                string[] datos = new string [6];
                string[] datos2;
                //validacion de combobox vacio
                int comprobar1;
                d = oControllerM.datosCbxCategoria();
                comprobar1 = cbxCategoriaModificar.Items.Count;

                if (comprobar1 == 0)
                {
                   

                    datos2 = new string[d.Length / 2];

                    for (int i = 0; i < (d.Length / 2); i++)
                    {

                        //cbxCategoria.DataSource = d;
                        cbxCategoriaModificar.Items.Add(d[i, 1]);
                        datos2[i] = d[i, 0];

                        //cbxCategoria.ValueMember = d[i, 0];


                    }

                }

                //llamo al metodo para obtener el nombre de cada categoria segun su id
               
                for (int i = 0; i < cbxCategoriaModificar.Items.Count; i++)
                {

                    if (categoriaM.Equals(d[i,0]))
                    {
                        string cat = "";
                        cat = d[i,1];
                        
                        cbxCategoriaModificar.Text = cat;

                        
                    }
                    
                }


                //lleno los textbox con los datos que ya existen en ese index.
                tbxNombreMod.Text = nombreM;
                tbxDescripcionMod.Text = descripcionM;
                tbxCantidadMod.Text = cantidadM;
                tbxPrecioMod.Text = precioM;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarImagenMod_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                imgMod = openFileDialog1.FileName;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (imgMod.Equals(rutaImagenYaExistente)) {
               imagenExistente = true;
               int idImagenModelo =  oControllerM.retornoIDimagenActualizar(imgMod,int.Parse(idproductoM), imagenExistente);

               oControllerM.actualizarDatosController(int.Parse(idproductoM), int.Parse(categoriaM), idImagenModelo, tbxNombreMod.Text, tbxDescripcionMod.Text, int.Parse(tbxCantidadMod.Text), double.Parse(tbxPrecioMod.Text));
                
            
            }
            else {
                imagenExistente=false;
                oControllerM.insertDimagenUpdate(imgMod, int.Parse(categoriaM));
                int idImagenModelo2 = oControllerM.retornoIDimagenActualizar(imgMod, int.Parse(idproductoM),imagenExistente);
                oControllerM.actualizarDatosController(int.Parse(idproductoM), int.Parse(categoriaM), idImagenModelo2, tbxNombreMod.Text, tbxDescripcionMod.Text, int.Parse(tbxCantidadMod.Text), double.Parse(tbxPrecioMod.Text));

            }

        }
    }
}
