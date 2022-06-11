namespace SAIVista
{
    partial class RptProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableAdapterManager1 = new SAIVista.SAIDBDataSetTableAdapters.TableAdapterManager();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbArticulosTableAdapter = null;
            this.tableAdapterManager1.tbCategoriaTableAdapter = null;
            this.tableAdapterManager1.tbClientesTableAdapter = null;
            this.tableAdapterManager1.tbClienteUsuariosTableAdapter = null;
            this.tableAdapterManager1.tbCompra_detalleTableAdapter = null;
            this.tableAdapterManager1.tbCompra_encabezadoTableAdapter = null;
            this.tableAdapterManager1.tbImagenesTableAdapter = null;
            this.tableAdapterManager1.tbProveedoresTableAdapter = null;
            this.tableAdapterManager1.tbTipo_ProveedorTableAdapter = null;
            this.tableAdapterManager1.tbTipo_usuarioTableAdapter = null;
            this.tableAdapterManager1.tbUsuariosTableAdapter = null;
            this.tableAdapterManager1.tbVenta_detalleTableAdapter = null;
            this.tableAdapterManager1.tbVentas_encabTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = SAIVista.SAIDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RptProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "RptProd";
            this.Text = "RptProd";
            this.Load += new System.EventHandler(this.RptProd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SAIDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}