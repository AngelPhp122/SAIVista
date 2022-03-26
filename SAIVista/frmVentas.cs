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
    public partial class frmVentas : Form
    {
        SAIControlador.VentaController control = new SAIControlador.VentaController();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvSales.DataSource = control.GetSales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevaVenta frm = new frmNuevaVenta();

            frm.Show();
        }
    }
}
