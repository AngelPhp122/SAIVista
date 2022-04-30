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
    public partial class frmUsuarios : Form
    {
        bool modificando = false;
        public frmUsuarios()
        {
            InitializeComponent();
        }
        SAIControlador.mainController control = new SAIControlador.mainController();

        public void limpiar_campos()
        {
            tbID.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEmail.Text = "";
            tbClave.Text = "";
            cmTipo.SelectedIndex = 0;
            modificando = false;
            lblEstado.Text = "";
        }


        public void actualizar_consulta()
        {
            dtgUsuarios.DataSource = control.consulta_a_dgvUsr();

            dtgUsuarios.Columns[3].Visible = false;
            dtgUsuarios.Columns[4].Visible = false;
            dtgUsuarios.Columns[5].Visible = false;
            dtgUsuarios.Columns[7].Visible = false;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Boolean existe = control.comprobarRegistro(tbID.Text);
            if (tbNombre.Text != "" && tbApellido.Text != "" && tbEmail.Text != "" && tbClave.Text != "")
            {
                if (!modificando)
                {
                    if (existe)
                    {
                        MessageBox.Show("Ya Existe, Ingrese nuevo codigo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string tipo_usr = cmTipo.SelectedIndex.ToString();
                    tipo_usr = tipo_usr.Split('-')[0];

                    string[] valores = new string[] {tbNombre.Text, tbApellido.Text
                        , tbEmail.Text, tbClave.Text,tipo_usr};

                    control.instruccion_sqlUsr("insertar", valores);

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

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (tbNombre.Text != "" && tbApellido.Text != "" && tbEmail.Text != "" && tbClave.Text != "")
            {
                if (modificando)
                {
                    string tipo_usr = cmTipo.SelectedIndex.ToString();
                    tipo_usr = tipo_usr.Split('-')[0];

                    string[] valores = new string[] {tbNombre.Text, tbApellido.Text
                        , tbEmail.Text, tbClave.Text,tipo_usr,tbID.Text};

                    control.instruccion_sqlUsr("actualizar", valores);
                    actualizar_consulta();
                    limpiar_campos();
                }
                else
                {
                    MessageBox.Show("Actualmente esta Agregando un usuario.\nSi desea Actualizar seleccione una fila de la tabla,Modifique los Campos Y luego presione actualizar");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todo los campos", "Messagge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuarios.AllowUserToDeleteRows = false;

            DataTable tb = control.llenar_comboBoxUsr();

            cmTipo.Items.Add("Seleccione");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmTipo.Items.Add(tb.Rows[i][0] + "-" + tb.Rows[i][1]);
            }
            cmTipo.SelectedIndex = 0;

            limpiar_campos();
            actualizar_consulta();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dtgUsuarios[0, dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
            tbNombre.Text = dtgUsuarios[1, dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
            tbApellido.Text = dtgUsuarios[2, dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
            tbEmail.Text = dtgUsuarios[3, dtgUsuarios.CurrentCell.RowIndex].Value.ToString().Replace(" ","");
            tbClave.Text = dtgUsuarios[4, dtgUsuarios.CurrentCell.RowIndex].Value.ToString();
            cmTipo.SelectedItem = dtgUsuarios[5, dtgUsuarios.CurrentCell.RowIndex].Value.ToString()
                +"-"+ dtgUsuarios[6, dtgUsuarios.CurrentCell.RowIndex].Value.ToString();

            if (dtgUsuarios[7, dtgUsuarios.CurrentCell.RowIndex].Value.ToString().Equals("False"))
                lblEstado.Text = "Inactivo";
            else
                lblEstado.Text = "Activo";

            modificando = true;
        }

        private void dtgUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string comando;
            if (modificando)
            {
                control.instruccion_sqlUsr("baja", new string[] { tbID.Text });
                actualizar_consulta();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("Actualmente esta agregando un usuario.\nSi desea dar de baja un usuario seleccione una fila de la tabla y luego presione dar de baja");
            }
        }
    }
}
