namespace SAIVista
{
    partial class frmEditarCompra
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
            this.tbxNombreProComp = new System.Windows.Forms.TextBox();
            this.tbxFacturaCompra = new System.Windows.Forms.TextBox();
            this.tbxCantidadProduComMod = new System.Windows.Forms.TextBox();
            this.tbxPrecioProdCompra = new System.Windows.Forms.TextBox();
            this.tbxDescripcionCompra = new System.Windows.Forms.TextBox();
            this.tbxIVAcompra = new System.Windows.Forms.TextBox();
            this.tbxDescuentoCompra = new System.Windows.Forms.TextBox();
            this.cbxProveedorCompra = new System.Windows.Forms.ComboBox();
            this.cbxCategoriaCompra = new System.Windows.Forms.ComboBox();
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.lbFacturaNo = new System.Windows.Forms.Label();
            this.lbCantidadProCompra = new System.Windows.Forms.Label();
            this.lbPrecioProducto = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbIvaCompra = new System.Windows.Forms.Label();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btnAceptarCompra = new System.Windows.Forms.Button();
            this.btnCancelarModCompra = new System.Windows.Forms.Button();
            this.btnModificarImagenCompra = new System.Windows.Forms.Button();
            this.openFileDialogCompraMod = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbxNombreProComp
            // 
            this.tbxNombreProComp.Location = new System.Drawing.Point(181, 47);
            this.tbxNombreProComp.Name = "tbxNombreProComp";
            this.tbxNombreProComp.Size = new System.Drawing.Size(168, 20);
            this.tbxNombreProComp.TabIndex = 0;
            // 
            // tbxFacturaCompra
            // 
            this.tbxFacturaCompra.Location = new System.Drawing.Point(181, 95);
            this.tbxFacturaCompra.Name = "tbxFacturaCompra";
            this.tbxFacturaCompra.Size = new System.Drawing.Size(168, 20);
            this.tbxFacturaCompra.TabIndex = 1;
            // 
            // tbxCantidadProduComMod
            // 
            this.tbxCantidadProduComMod.Location = new System.Drawing.Point(181, 145);
            this.tbxCantidadProduComMod.Name = "tbxCantidadProduComMod";
            this.tbxCantidadProduComMod.Size = new System.Drawing.Size(168, 20);
            this.tbxCantidadProduComMod.TabIndex = 2;
            // 
            // tbxPrecioProdCompra
            // 
            this.tbxPrecioProdCompra.Location = new System.Drawing.Point(181, 203);
            this.tbxPrecioProdCompra.Name = "tbxPrecioProdCompra";
            this.tbxPrecioProdCompra.Size = new System.Drawing.Size(168, 20);
            this.tbxPrecioProdCompra.TabIndex = 3;
            // 
            // tbxDescripcionCompra
            // 
            this.tbxDescripcionCompra.Location = new System.Drawing.Point(181, 264);
            this.tbxDescripcionCompra.Name = "tbxDescripcionCompra";
            this.tbxDescripcionCompra.Size = new System.Drawing.Size(168, 20);
            this.tbxDescripcionCompra.TabIndex = 4;
            // 
            // tbxIVAcompra
            // 
            this.tbxIVAcompra.Location = new System.Drawing.Point(181, 322);
            this.tbxIVAcompra.Name = "tbxIVAcompra";
            this.tbxIVAcompra.Size = new System.Drawing.Size(168, 20);
            this.tbxIVAcompra.TabIndex = 5;
            // 
            // tbxDescuentoCompra
            // 
            this.tbxDescuentoCompra.Location = new System.Drawing.Point(181, 381);
            this.tbxDescuentoCompra.Name = "tbxDescuentoCompra";
            this.tbxDescuentoCompra.Size = new System.Drawing.Size(168, 20);
            this.tbxDescuentoCompra.TabIndex = 6;
            // 
            // cbxProveedorCompra
            // 
            this.cbxProveedorCompra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxProveedorCompra.FormattingEnabled = true;
            this.cbxProveedorCompra.Location = new System.Drawing.Point(181, 439);
            this.cbxProveedorCompra.Name = "cbxProveedorCompra";
            this.cbxProveedorCompra.Size = new System.Drawing.Size(168, 21);
            this.cbxProveedorCompra.TabIndex = 7;
            // 
            // cbxCategoriaCompra
            // 
            this.cbxCategoriaCompra.FormattingEnabled = true;
            this.cbxCategoriaCompra.Location = new System.Drawing.Point(181, 496);
            this.cbxCategoriaCompra.Name = "cbxCategoriaCompra";
            this.cbxCategoriaCompra.Size = new System.Drawing.Size(168, 21);
            this.cbxCategoriaCompra.TabIndex = 8;
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Location = new System.Drawing.Point(34, 47);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(106, 13);
            this.lbNombreProducto.TabIndex = 9;
            this.lbNombreProducto.Text = "Nombre del producto";
            // 
            // lbFacturaNo
            // 
            this.lbFacturaNo.AutoSize = true;
            this.lbFacturaNo.Location = new System.Drawing.Point(34, 98);
            this.lbFacturaNo.Name = "lbFacturaNo";
            this.lbFacturaNo.Size = new System.Drawing.Size(63, 13);
            this.lbFacturaNo.TabIndex = 10;
            this.lbFacturaNo.Text = "Factura No.";
            // 
            // lbCantidadProCompra
            // 
            this.lbCantidadProCompra.AutoSize = true;
            this.lbCantidadProCompra.Location = new System.Drawing.Point(34, 152);
            this.lbCantidadProCompra.Name = "lbCantidadProCompra";
            this.lbCantidadProCompra.Size = new System.Drawing.Size(109, 13);
            this.lbCantidadProCompra.TabIndex = 11;
            this.lbCantidadProCompra.Text = "Cantidad de producto";
            // 
            // lbPrecioProducto
            // 
            this.lbPrecioProducto.AutoSize = true;
            this.lbPrecioProducto.Location = new System.Drawing.Point(34, 210);
            this.lbPrecioProducto.Name = "lbPrecioProducto";
            this.lbPrecioProducto.Size = new System.Drawing.Size(99, 13);
            this.lbPrecioProducto.TabIndex = 12;
            this.lbPrecioProducto.Text = "Precio del producto";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(34, 271);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 13;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbIvaCompra
            // 
            this.lbIvaCompra.AutoSize = true;
            this.lbIvaCompra.Location = new System.Drawing.Point(34, 325);
            this.lbIvaCompra.Name = "lbIvaCompra";
            this.lbIvaCompra.Size = new System.Drawing.Size(62, 13);
            this.lbIvaCompra.TabIndex = 14;
            this.lbIvaCompra.Text = "IVA compra";
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Location = new System.Drawing.Point(34, 384);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(59, 13);
            this.lbDescuento.TabIndex = 15;
            this.lbDescuento.Text = "Descuento";
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Location = new System.Drawing.Point(34, 447);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(56, 13);
            this.lbProveedor.TabIndex = 16;
            this.lbProveedor.Text = "Proveedor";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(34, 499);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 17;
            this.lbCategoria.Text = "Categoria";
            // 
            // btnAceptarCompra
            // 
            this.btnAceptarCompra.Location = new System.Drawing.Point(78, 595);
            this.btnAceptarCompra.Name = "btnAceptarCompra";
            this.btnAceptarCompra.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCompra.TabIndex = 18;
            this.btnAceptarCompra.Text = "Aceptar";
            this.btnAceptarCompra.UseVisualStyleBackColor = true;
            this.btnAceptarCompra.Click += new System.EventHandler(this.btnAceptarCompra_Click);
            // 
            // btnCancelarModCompra
            // 
            this.btnCancelarModCompra.Location = new System.Drawing.Point(211, 595);
            this.btnCancelarModCompra.Name = "btnCancelarModCompra";
            this.btnCancelarModCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModCompra.TabIndex = 19;
            this.btnCancelarModCompra.Text = "Cancelar";
            this.btnCancelarModCompra.UseVisualStyleBackColor = true;
            // 
            // btnModificarImagenCompra
            // 
            this.btnModificarImagenCompra.Location = new System.Drawing.Point(119, 542);
            this.btnModificarImagenCompra.Name = "btnModificarImagenCompra";
            this.btnModificarImagenCompra.Size = new System.Drawing.Size(135, 23);
            this.btnModificarImagenCompra.TabIndex = 20;
            this.btnModificarImagenCompra.Text = "Modificar imagen";
            this.btnModificarImagenCompra.UseVisualStyleBackColor = true;
            this.btnModificarImagenCompra.Click += new System.EventHandler(this.btnModificarImagenCompra_Click);
            // 
            // openFileDialogCompraMod
            // 
            this.openFileDialogCompraMod.FileName = "openFileDialog1";
            // 
            // frmEditarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 653);
            this.Controls.Add(this.btnModificarImagenCompra);
            this.Controls.Add(this.btnCancelarModCompra);
            this.Controls.Add(this.btnAceptarCompra);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbProveedor);
            this.Controls.Add(this.lbDescuento);
            this.Controls.Add(this.lbIvaCompra);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbPrecioProducto);
            this.Controls.Add(this.lbCantidadProCompra);
            this.Controls.Add(this.lbFacturaNo);
            this.Controls.Add(this.lbNombreProducto);
            this.Controls.Add(this.cbxCategoriaCompra);
            this.Controls.Add(this.cbxProveedorCompra);
            this.Controls.Add(this.tbxDescuentoCompra);
            this.Controls.Add(this.tbxIVAcompra);
            this.Controls.Add(this.tbxDescripcionCompra);
            this.Controls.Add(this.tbxPrecioProdCompra);
            this.Controls.Add(this.tbxCantidadProduComMod);
            this.Controls.Add(this.tbxFacturaCompra);
            this.Controls.Add(this.tbxNombreProComp);
            this.Name = "frmEditarCompra";
            this.Text = "frmEditarCompra";
            this.Load += new System.EventHandler(this.frmEditarCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNombreProComp;
        private System.Windows.Forms.TextBox tbxFacturaCompra;
        private System.Windows.Forms.TextBox tbxCantidadProduComMod;
        private System.Windows.Forms.TextBox tbxPrecioProdCompra;
        private System.Windows.Forms.TextBox tbxDescripcionCompra;
        private System.Windows.Forms.TextBox tbxIVAcompra;
        private System.Windows.Forms.TextBox tbxDescuentoCompra;
        private System.Windows.Forms.ComboBox cbxProveedorCompra;
        private System.Windows.Forms.ComboBox cbxCategoriaCompra;
        private System.Windows.Forms.Label lbNombreProducto;
        private System.Windows.Forms.Label lbFacturaNo;
        private System.Windows.Forms.Label lbCantidadProCompra;
        private System.Windows.Forms.Label lbPrecioProducto;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbIvaCompra;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btnAceptarCompra;
        private System.Windows.Forms.Button btnCancelarModCompra;
        private System.Windows.Forms.Button btnModificarImagenCompra;
        private System.Windows.Forms.OpenFileDialog openFileDialogCompraMod;
    }
}