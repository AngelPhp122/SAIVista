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
    public partial class frmClientes : Form
    {
        bool modificando = false;
        public frmClientes()
        {
            InitializeComponent();
        }
        SAIControlador.mainController control = new SAIControlador.mainController();
        public void limpiar_campos()
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbDireccion.Text = "";
            txbTelefono.Text = "";
            txbEmail.Text = "";
            modificando = false;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
