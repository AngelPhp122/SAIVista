using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAIVista
{
    public partial class frmTiposUsuario : Form
    {
        SAIControlador.mainController control = new SAIControlador.mainController();

        bool modificando = false;
        public frmTiposUsuario()
        {
            InitializeComponent();
        }
        public void limpiar_campos()
        {
            tbCodigo.Text = "";
            tbDescripcion.Text = "";
            tbBaja.Text = "--";
            tbCreacion.Text = "--";
            modificando = false;
        }


        string comando;
        public void actualizar_consulta()
        {
            dtgTipos.AllowUserToAddRows = false;
            dtgTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgTipos.DataSource = control.consulta_a_dgv();
        }




        //        private void dataregistro_CellClick_1(object sender, DataGridViewCellEventArgs e)
        //        {

        //            Txtcodigo.Text = dataregistro[0, dataregistro.CurrentCell.RowIndex].Value.ToString();
        //            txtnombre.Text = dataregistro[1, dataregistro.CurrentCell.RowIndex].Value.ToString();
        //            txtcontraseña.Text = dataregistro[2, dataregistro.CurrentCell.RowIndex].Value.ToString();
        //            cmbrol.SelectedIndex = Int32.Parse(dataregistro[3, dataregistro.CurrentCell.RowIndex].Value.ToString());
        //            Txtcodigo.Enabled = false;
        //        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            limpiar_campos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Boolean existe = control.comprobarRegistro(tbCodigo.Text);
            if (tbDescripcion.Text != "")
            {
                if (!modificando)
                {
                    if (existe)
                    {
                        MessageBox.Show("Ya Existe, Ingrese nuevo codigo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    control.instruccion_sql("insertar", new string[] { tbDescripcion.Text });

                    actualizar_consulta();
                    limpiar_campos();
                }

                else
                {
                    MessageBox.Show("Actualmente Esta visualizando un tipo de usuario");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todo los campos", "Messagge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string comando;
            if (modificando)
            {
                control.instruccion_sql("baja", new string[] { tbCodigo.Text });
                actualizar_consulta();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("Actualmente esta agregando un tipo de usuario.\nSi desea dar de baja un tipo de usuario seleccione una fila de la tabla y luego presione dar de baja");
            }
        }

        private void frmTiposUsuario_Load(object sender, EventArgs e)
        {
            limpiar_campos();
            actualizar_consulta();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (tbDescripcion.Text != "")
            {
                if (modificando)
                {
                    control.instruccion_sql("actualizar", new string[] { tbDescripcion.Text,tbCodigo.Text });
                    actualizar_consulta();
                    limpiar_campos();
                }
                else
                {
                    MessageBox.Show("Actualmente esta Agregando un tipo de usuario.\nSi desea Actualizar seleccione una fila de la tabla,Modifique los Campos Y luego presione actualizar");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todo los campos", "Messagge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dtgTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            tbCodigo.Text = dtgTipos[0, dtgTipos.CurrentCell.RowIndex].Value.ToString();
            tbDescripcion.Text = dtgTipos[1, dtgTipos.CurrentCell.RowIndex].Value.ToString();
            tbCreacion.Text = dtgTipos[2, dtgTipos.CurrentCell.RowIndex].Value.ToString();
            tbBaja.Text = dtgTipos[3, dtgTipos.CurrentCell.RowIndex].Value.ToString();
            modificando = true;
        }
    }
}
