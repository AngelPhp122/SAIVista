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
            Form formularioMenu1 = new frmProductos();

            formularioMenu1.Show();

        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioMenu2 = new frmCompras();

            formularioMenu2.Show();
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
            Form formularioMenu3 = new frmReporteCompras();

            formularioMenu3.Show();
        }

        //llamando a los clientes form
        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioMenu = new frmClientes();

            formularioMenu.Show();
        }
        //llamando a los clientes search form
        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioMenu = new frmConsultaCliente();

            formularioMenu.Show();
        }



        private void homeForm_Load(object sender, EventArgs e)
        {

        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioMeno5 = new frmVentas();

            formularioMeno5.Show(); 
        }

        private void gestiónDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCat = new frmCategorias();
            formCat.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Login = new SAIModelo.Login();
            Login.Show();
            this.Hide();
        }

        private void tsmiInicio_Click(object sender, EventArgs e)
        {

        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
