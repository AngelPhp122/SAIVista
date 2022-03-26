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
    public partial class frmReporteCompras : Form
    {
        SAIControlador.mainController oReportesCompras = new SAIControlador.mainController();
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            if (dtgReportesCompras.ColumnCount == 0) {
                DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();

                ///nombre_productoCom, numFacturaCompra, cantProdComprado, precioProdCompra, descripcionCompraProd

                c1.HeaderText = "Nombre producto";
                c2.HeaderText = "Factura No.";
                c3.HeaderText = "Cantidad";
                c4.HeaderText = "Precio";
                c5.HeaderText = "Decripcion";



                dtgReportesCompras.Columns.Add(c1);
                dtgReportesCompras.Columns.Add(c2);
                dtgReportesCompras.Columns.Add(c3);
                dtgReportesCompras.Columns.Add(c4);
                dtgReportesCompras.Columns.Add(c5);

            } else {
                
           
            }

                

                if (String.IsNullOrWhiteSpace(tbxFechaFinal.Text) || String.IsNullOrWhiteSpace(tbxFechaInicial.Text))
                {

                }

                else
                {


                    string[,] aDatos = oReportesCompras.datosReportesComprasMainController(tbxFechaInicial.Text, tbxFechaFinal.Text);



                    for (int i = 0; i < aDatos.GetLength(0); i++)
                    {

                        dtgReportesCompras.Rows.Add(aDatos[i, 0], aDatos[i, 1], aDatos[i, 2], aDatos[i, 3], aDatos[i, 4]);


                    }

                }
            

            

        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            frmReporteCompras_Load(sender,e);
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            exportarExcel(dtgReportesCompras);
        }

        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int indiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna].Value = col.Name;
            }

            int indiceFila = 0;

            foreach(DataGridViewRow row in tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna].Value = row.Cells[col.Name].Value;
                }
            }

            excel.Visible = true;
        }
    }
}
