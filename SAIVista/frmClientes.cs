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

        SAIControlador.mainController control = new SAIControlador.mainController();

        public frmClientes()
        {
            InitializeComponent();
        }
        public void limpiar_campos()
        {
            txbCodigo.Text = "";
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbDireccion.Text = "";
            txbTelefono.Text = "";
            txbEmail.Text = "";
            modificando = false;
        }

        public void actualizar_consulta()
        {
            dtgClientes.DataSource = control.consulta_a_dgvCli();

        }
        private void frmClientes_Load(object sender, EventArgs e)
        {

            dtgClientes.AllowUserToAddRows = false;
            dtgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgClientes.AllowUserToDeleteRows = false;



            limpiar_campos();
            actualizar_consulta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string comando;
            if (modificando)
            {
                control.instruccion_sqlCli("eliminar", new string[] { txbCodigo.Text });
                actualizar_consulta();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("Actualmente esta agregando un cliente.\nSi desea eliminar un cliente seleccione una fila de la tabla y luego presione eliminar");
            }
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Boolean existe = control.comprobarRegistroCli(txbCodigo.Text);
            if (txbNombre.Text != "" && txbApellido.Text != "" && txbDireccion.Text != ""
                && txbTelefono.Text != "" && txbEmail.Text != "")
            {
                if (!modificando)
                {
                    if (existe)
                    {
                        MessageBox.Show("Ya Existe, Ingrese nuevo codigo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string[] valores = new string[] {txbNombre.Text, txbApellido.Text
                        , txbDireccion.Text, txbTelefono.Text,txbEmail.Text};

                    control.instruccion_sqlCli("insertar", valores);

                    actualizar_consulta();
                    limpiar_campos();
                }

                else
                {
                    MessageBox.Show("Actualmente Esta visualizando un usuario");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todo los campos", "Messagge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dtgClientes[0, dtgClientes.CurrentCell.RowIndex].Value.ToString();
            txbNombre.Text = dtgClientes[1, dtgClientes.CurrentCell.RowIndex].Value.ToString();
            txbApellido.Text = dtgClientes[2, dtgClientes.CurrentCell.RowIndex].Value.ToString();
            txbDireccion.Text = dtgClientes[3, dtgClientes.CurrentCell.RowIndex].Value.ToString().Replace(" ", "");
            txbTelefono.Text = dtgClientes[4, dtgClientes.CurrentCell.RowIndex].Value.ToString();
            txbEmail.Text = dtgClientes[5, dtgClientes.CurrentCell.RowIndex].Value.ToString();


            modificando = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (txbCodigo.Text != "" && txbNombre.Text != "" && txbApellido.Text != "" && txbDireccion.Text != ""
                && txbTelefono.Text != "" && txbEmail.Text != "")
            {
                if (modificando)
                {

                    string[] valores = new string[] {txbNombre.Text, txbApellido.Text
                        , txbDireccion.Text, txbTelefono.Text,txbEmail.Text,txbCodigo.Text};

                    control.instruccion_sqlCli("actualizar", valores);
                    actualizar_consulta();
                    limpiar_campos();
                }
                else
                {
                    MessageBox.Show("Actualmente esta Agregando un cliente.\nSi desea Actualizar seleccione una fila de la tabla,Modifique los Campos Y luego presione actualizar");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todo los campos", "Messagge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
