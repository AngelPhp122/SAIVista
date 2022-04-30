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
    public partial class frmNuevaVenta : Form
    {
        SAIControlador.VentaController control = new SAIControlador.VentaController();

        int customerId;

        DataTable data;

        DataTable dataUser;

        public frmNuevaVenta()
        {
            data = control.GetProducts();
            dataUser = control.GetUsers();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     
        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in data.Rows)
            {
                cmbProduct.Items.Add(row[1]);
            }

            cmbProduct.SelectedIndex = 0;
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (DataRow row in dataUser.Rows)
            {
                cmbUser.Items.Add(row[1]);
            }
            txtQuantity.Text = "1";
            cmbUser.SelectedIndex = 0;
            cmbUser.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvVenta.Columns.Add("productId", "Codigo");
            dgvVenta.Columns.Add("name", "Producto");
            dgvVenta.Columns.Add("quantity", "Cantidad");
            dgvVenta.Columns.Add("total", "Total");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int productIndex = int.Parse(cmbProduct.SelectedIndex.ToString());

            int productId = (int)data.Rows[productIndex][0];

            int quantity = int.Parse(txtQuantity.Text);

            double price = double.Parse(data.Rows[productIndex][2].ToString()) * quantity;

            dgvVenta.Rows.Add(productId, data.Rows[productIndex][1], quantity, price);

            lbTotal.Text = "$" + (from DataGridViewRow row in dgvVenta.Rows
                                  where row.Cells[3].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();

            lbTotalQuantity.Text = (from DataGridViewRow row in dgvVenta.Rows
                                    where row.Cells[2].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();

        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usrIndex = int.Parse(cmbUser.SelectedIndex.ToString());
            customerId = (int)dataUser.Rows[usrIndex][0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvVenta.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            control.SaveSale(dt, int.Parse(lbTotalQuantity.Text), double.Parse(lbTotal.Text.Remove(0, 1)), customerId);
            this.Close();
        }
    }
}
