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
        /*private string[] datos2;
        private string rutaImagen;

        SAIControlador.mainController oControladorCompras = new SAIControlador.mainController();
        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            string[,] d;
            try
            {

                //validacion de combobox vacio
                int comprobar1;

                comprobar1 = cbxProveedor.Items.Count;

                if (comprobar1 == 0)
                {
                    d = oControladorCompras;

                    datos2 = new string[d.Length / 2];

                    for (int i = 0; i < (d.Length / 2); i++)
                    {

                        //cbxCategoria.DataSource = d;
                        cbxCategoria.Items.Add(d[i, 1]);
                        datos2[i] = d[i, 0];

                        //cbxCategoria.ValueMember = d[i, 0];


                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            //DatagrewView


            int comprobar;

            try
            {

                comprobar = dtgArticulos.Rows.Count;
                dtgArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //MessageBox.Show(""+comprobar);
                DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
                DataGridViewImageColumn c7 = new DataGridViewImageColumn();
                //DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
                //DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();

                //estructura de control que no permite la duplicacion de la tabla
                if (comprobar == 0)
                {

                    c1.HeaderText = "id producto";
                    c2.HeaderText = "categoria";
                    //c3.HeaderText = "id imagen";
                    //c4.HeaderText = "id usuario";
                    c3.HeaderText = "nombre articulo";
                    c4.HeaderText = "descripcion";
                    c5.HeaderText = "cantidad";
                    c6.HeaderText = "precio";
                    c7.HeaderText = "imagen";

                    dtgArticulos.Columns.Add(c1);
                    dtgArticulos.Columns.Add(c2);
                    dtgArticulos.Columns.Add(c3);
                    dtgArticulos.Columns.Add(c4);
                    dtgArticulos.Columns.Add(c5);
                    dtgArticulos.Columns.Add(c6);
                    dtgArticulos.Columns.Add(c7);

                    dtgArticulos.Columns[6].Width = 325;
                    //dtgArticulos.Columns.Add(c8);
                    //dtgArticulos.Columns.Add(c9);
                    string[,] c;
                    c = oControlador.datosDtgArticulos();

                    //MessageBox.Show("arreglo c = "+c.GetLength(0));
                    if (c.GetLength(0) >= 0)
                    {


                        for (int i = 0; i < c.GetLength(0); i++)
                        {

                            dtgArticulos.Rows.Add(c[i, 0], c[i, 1], c[i, 2], c[i, 3], c[i, 4], c[i, 5], Image.FromFile(c[i, 6]));
                            dtgArticulos.Rows[i].Cells[6].Tag = c[i, 6];
                            //MessageBox.Show((dtgArticulos.Rows[i].Cells[6].Tag = c[i, 6]).ToString());
                            //dtgArticulos.Rows[i].Height = 180;
                            //dtgArticulos.Columns[6].Width = 325;


                        }
                    }

                }
                else
                {


                    string[,] c;

                    c = oControlador.datosDtgArticulos();

                    int indiceA = c.GetLength(0) - 1;


                    dtgArticulos.Rows.Add(c[indiceA, 0], c[indiceA, 1], c[indiceA, 2], c[indiceA, 3], c[indiceA, 4], c[indiceA, 5], Image.FromFile(c[indiceA, 6]));
                    dtgArticulos.Rows[indiceA].Cells[6].Tag = c[indiceA, 6];
                    dtgArticulos.Columns[6].Width = 325;
                }


                //string seleccionFila = dtgArticulos.CurrentRow.ToString();

                //           MessageBox.Show("datoSeleccionado "+ seleccionFila);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }*/
    }
    
}
