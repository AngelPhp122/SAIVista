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
    public partial class frmCategorias : Form
    {
        bool modificando = false;
        public frmCategorias()
        {
            InitializeComponent();
        }
        SAIControlador.mainController control = new SAIControlador.mainController();

        public void limpiar_campos()
        {
            tbIDcat.Text = "";
            cmIdUser.SelectedIndex = 0;
            tbNombreCat.Text = "";
            modificando = false;
        }


        public void actualizar_consulta()
        {
            dtgCategorias.DataSource = control.consulta_a_dgvCat();

            //dtgCategorias.Columns[3].Visible = false;
            //dtgCategorias.Columns[4].Visible = false;
            //dtgCategorias.Columns[5].Visible = false;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            dtgCategorias.AllowUserToAddRows = false;
            dtgCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCategorias.AllowUserToDeleteRows = false;

            DataTable tb = control.llenar_comboBoxIdUsrCat();

            cmIdUser.Items.Add("Seleccione");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmIdUser.Items.Add(tb.Rows[i][0] + "-" + tb.Rows[i][1]);
            }
            cmIdUser.SelectedIndex = 0;

            limpiar_campos();
            actualizar_consulta();
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            Boolean existe = control.comprobarRegistroCat(tbIDcat.Text);
            if (tbNombreCat.Text != "")
            {
                if (!modificando)
                {
                    if (existe)
                    {
                        MessageBox.Show("Ya Existe, Ingrese nuevo codigo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string id_usr = cmIdUser.SelectedItem.ToString();
                    id_usr = id_usr.Split('-')[0];

                    string[] valores = new string[] { id_usr, tbNombreCat.Text };

                    control.instruccion_sqlCat("insertar", valores);

                    actualizar_consulta();
                    limpiar_campos();
                }

                else
                {
                    MessageBox.Show("Actualmente Esta visualizando una categoría");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todo los campos", "Messagge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            if (tbNombreCat.Text != "")
            {
                if (modificando)
                {
                    string id_usr = cmIdUser.SelectedItem.ToString();
                    id_usr = id_usr.Split('-')[0];

                    string[] valores = new string[] { id_usr, tbNombreCat.Text, tbIDcat.Text };

                    control.instruccion_sqlCat("actualizar", valores);
                    actualizar_consulta();
                    limpiar_campos();
                }
                else
                {
                    MessageBox.Show("Actualmente esta Agregando una categoría.\nSi desea Actualizar seleccione una fila de la tabla,Modifique los Campos Y luego presione actualizar");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de haber llenado todo los campos", "Messagge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void dtgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDcat.Text = dtgCategorias[0, dtgCategorias.CurrentCell.RowIndex].Value.ToString();
            cmIdUser.SelectedItem= dtgCategorias[1, dtgCategorias.CurrentCell.RowIndex].Value.ToString()
                + "-" + dtgCategorias[2, dtgCategorias.CurrentCell.RowIndex].Value.ToString();
            tbNombreCat.Text = dtgCategorias[3, dtgCategorias.CurrentCell.RowIndex].Value.ToString();

            modificando = true;
        }
    }
}