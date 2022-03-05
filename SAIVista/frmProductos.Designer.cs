namespace SAIVista
{
    partial class frmProductos
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

        private System.Windows.Forms.Label lbProductosTitulo;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.DataGridView dtgArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbIndexCat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }

}