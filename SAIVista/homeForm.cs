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
    public partial class homeForm : Form
    {
        SAIControlador.mainController oSAIcontroller = new SAIControlador.mainController();
        

        public homeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                        
        }

       

        //metodo para llamar al formulario de productos
        private void tsmiProductos_Click(object sender, EventArgs e)
        {
            Form formularioMenu = new frmProductos();

            formularioMenu.Show();

        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioMenu = new frmCompras();

            formularioMenu.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void tiposUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposUsuario frm = new frmTiposUsuario();

            frm.Show();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUsuarios frm = new frmUsuarios();

            frm.Show();
        }

        private void reporteComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioMenu = new frmReporteCompras();

            formularioMenu.Show();
        }
    }
}
