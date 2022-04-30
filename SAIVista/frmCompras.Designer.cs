namespace SAIVista
{
    partial class frmCompras
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
            this.components = new System.ComponentModel.Container();
            this.tbxNombreProducto = new System.Windows.Forms.TextBox();
            this.tbxIVAcompra = new System.Windows.Forms.TextBox();
            this.tbxPrecioProdCompra = new System.Windows.Forms.TextBox();
            this.tbxCantProductoComprado = new System.Windows.Forms.TextBox();
            this.tbxDescuentoComp = new System.Windows.Forms.TextBox();
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.lbCantProdComp = new System.Windows.Forms.Label();
            this.lbPrecioProducto = new System.Windows.Forms.Label();
            this.lbIVAcompra = new System.Windows.Forms.Label();
            this.lbDescuentoComp = new System.Windows.Forms.Label();
            this.dtgCompras = new System.Windows.Forms.DataGridView();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.btnEditarCompra = new System.Windows.Forms.Button();
            this.btnEliminarCompra = new System.Windows.Forms.Button();
            this.tbxDescripcionCompra = new System.Windows.Forms.TextBox();
            this.lbDescripcionCompra = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.btnImagenCompra = new System.Windows.Forms.Button();
            this.errorProvider1Compras = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialogCompra = new System.Windows.Forms.OpenFileDialog();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.lbNumeroFact = new System.Windows.Forms.Label();
            this.tbxFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNombreProducto
            // 
            this.tbxNombreProducto.Location = new System.Drawing.Point(114, 73);
            this.tbxNombreProducto.Name = "tbxNombreProducto";
            this.tbxNombreProducto.Size = new System.Drawing.Size(170, 20);
            this.tbxNombreProducto.TabIndex = 0;
            // 
            // tbxIVAcompra
            // 
            this.tbxIVAcompra.Location = new System.Drawing.Point(114, 323);
            this.tbxIVAcompra.Name = "tbxIVAcompra";
            this.tbxIVAcompra.Size = new System.Drawing.Size(170, 20);
            this.tbxIVAcompra.TabIndex = 2;
            this.tbxIVAcompra.TextChanged += new System.EventHandler(this.tbxIVAcompra_TextChanged);
            // 
            // tbxPrecioProdCompra
            // 
            this.tbxPrecioProdCompra.Location = new System.Drawing.Point(114, 188);
            this.tbxPrecioProdCompra.Name = "tbxPrecioProdCompra";
            this.tbxPrecioProdCompra.Size = new System.Drawing.Size(170, 20);
            this.tbxPrecioProdCompra.TabIndex = 3;
            // 
            // tbxCantProductoComprado
            // 
            this.tbxCantProductoComprado.Location = new System.Drawing.Point(114, 122);
            this.tbxCantProductoComprado.Name = "tbxCantProductoComprado";
            this.tbxCantProductoComprado.Size = new System.Drawing.Size(170, 20);
            this.tbxCantProductoComprado.TabIndex = 4;
            // 
            // tbxDescuentoComp
            // 
            this.tbxDescuentoComp.Location = new System.Drawing.Point(114, 388);
            this.tbxDescuentoComp.Name = "tbxDescuentoComp";
            this.tbxDescuentoComp.Size = new System.Drawing.Size(170, 20);
            this.tbxDescuentoComp.TabIndex = 5;
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Location = new System.Drawing.Point(-2, 80);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(106, 13);
            this.lbNombreProducto.TabIndex = 6;
            this.lbNombreProducto.Text = "Nombre del producto";
            // 
            // lbCantProdComp
            // 
            this.lbCantProdComp.AutoSize = true;
            this.lbCantProdComp.Location = new System.Drawing.Point(-2, 129);
            this.lbCantProdComp.Name = "lbCantProdComp";
            this.lbCantProdComp.Size = new System.Drawing.Size(110, 13);
            this.lbCantProdComp.TabIndex = 8;
            this.lbCantProdComp.Text = "Cantidad de Producto";
            // 
            // lbPrecioProducto
            // 
            this.lbPrecioProducto.AutoSize = true;
            this.lbPrecioProducto.Location = new System.Drawing.Point(-2, 195);
            this.lbPrecioProducto.Name = "lbPrecioProducto";
            this.lbPrecioProducto.Size = new System.Drawing.Size(99, 13);
            this.lbPrecioProducto.TabIndex = 9;
            this.lbPrecioProducto.Text = "Precio del producto";
            // 
            // lbIVAcompra
            // 
            this.lbIVAcompra.AutoSize = true;
            this.lbIVAcompra.Location = new System.Drawing.Point(6, 330);
            this.lbIVAcompra.Name = "lbIVAcompra";
            this.lbIVAcompra.Size = new System.Drawing.Size(62, 13);
            this.lbIVAcompra.TabIndex = 10;
            this.lbIVAcompra.Text = "IVA compra";
            // 
            // lbDescuentoComp
            // 
            this.lbDescuentoComp.AutoSize = true;
            this.lbDescuentoComp.Location = new System.Drawing.Point(2, 395);
            this.lbDescuentoComp.Name = "lbDescuentoComp";
            this.lbDescuentoComp.Size = new System.Drawing.Size(59, 13);
            this.lbDescuentoComp.TabIndex = 11;
            this.lbDescuentoComp.Text = "Descuento";
            // 
            // dtgCompras
            // 
            this.dtgCompras.AllowUserToAddRows = false;
            this.dtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCompras.Location = new System.Drawing.Point(290, 73);
            this.dtgCompras.Name = "dtgCompras";
            this.dtgCompras.RowHeadersWidth = 51;
            this.dtgCompras.RowTemplate.Height = 180;
            this.dtgCompras.Size = new System.Drawing.Size(1223, 511);
            this.dtgCompras.TabIndex = 12;
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Location = new System.Drawing.Point(290, 590);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarCompra.TabIndex = 13;
            this.btnAgregarCompra.Text = "Agregar";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // btnEditarCompra
            // 
            this.btnEditarCompra.Location = new System.Drawing.Point(462, 590);
            this.btnEditarCompra.Name = "btnEditarCompra";
            this.btnEditarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnEditarCompra.TabIndex = 14;
            this.btnEditarCompra.Text = "Editar";
            this.btnEditarCompra.UseVisualStyleBackColor = true;
            this.btnEditarCompra.Click += new System.EventHandler(this.btnEditarCompra_Click);
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Location = new System.Drawing.Point(619, 590);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarCompra.TabIndex = 15;
            this.btnEliminarCompra.Text = "Eliminar";
            this.btnEliminarCompra.UseVisualStyleBackColor = true;
            this.btnEliminarCompra.Click += new System.EventHandler(this.btnEliminarCompra_Click);
            // 
            // tbxDescripcionCompra
            // 
            this.tbxDescripcionCompra.Location = new System.Drawing.Point(114, 257);
            this.tbxDescripcionCompra.Name = "tbxDescripcionCompra";
            this.tbxDescripcionCompra.Size = new System.Drawing.Size(170, 20);
            this.tbxDescripcionCompra.TabIndex = 16;
            // 
            // lbDescripcionCompra
            // 
            this.lbDescripcionCompra.AutoSize = true;
            this.lbDescripcionCompra.Location = new System.Drawing.Point(2, 264);
            this.lbDescripcionCompra.Name = "lbDescripcionCompra";
            this.lbDescripcionCompra.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcionCompra.TabIndex = 17;
            this.lbDescripcionCompra.Text = "Descripcion";
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Location = new System.Drawing.Point(2, 450);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(56, 13);
            this.lbProveedor.TabIndex = 18;
            this.lbProveedor.Text = "Proveedor";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(110, 442);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(174, 21);
            this.cbxProveedor.TabIndex = 19;
            // 
            // btnImagenCompra
            // 
            this.btnImagenCompra.Location = new System.Drawing.Point(110, 545);
            this.btnImagenCompra.Name = "btnImagenCompra";
            this.btnImagenCompra.Size = new System.Drawing.Size(96, 23);
            this.btnImagenCompra.TabIndex = 20;
            this.btnImagenCompra.Text = "Agregar Imagen";
            this.btnImagenCompra.UseVisualStyleBackColor = true;
            this.btnImagenCompra.Click += new System.EventHandler(this.btnImagenCompra_Click);
            // 
            // errorProvider1Compras
            // 
            this.errorProvider1Compras.ContainerControl = this;
            // 
            // openFileDialogCompra
            // 
            this.openFileDialogCompra.FileName = "openFileDialog1";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(2, 501);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 21;
            this.lbCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(110, 493);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(174, 21);
            this.cbxCategoria.TabIndex = 22;
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.Location = new System.Drawing.Point(818, 589);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(166, 23);
            this.btnGuardarCompra.TabIndex = 23;
            this.btnGuardarCompra.Text = "guardar Compra";
            this.btnGuardarCompra.UseVisualStyleBackColor = true;
            // 
            // lbNumeroFact
            // 
            this.lbNumeroFact.AutoSize = true;
            this.lbNumeroFact.Location = new System.Drawing.Point(1, 34);
            this.lbNumeroFact.Name = "lbNumeroFact";
            this.lbNumeroFact.Size = new System.Drawing.Size(43, 13);
            this.lbNumeroFact.TabIndex = 24;
            this.lbNumeroFact.Text = "Factura";
            // 
            // tbxFactura
            // 
            this.tbxFactura.Location = new System.Drawing.Point(114, 34);
            this.tbxFactura.Name = "tbxFactura";
            this.tbxFactura.Size = new System.Drawing.Size(170, 20);
            this.tbxFactura.TabIndex = 25;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 659);
            this.Controls.Add(this.tbxFactura);
            this.Controls.Add(this.lbNumeroFact);
            this.Controls.Add(this.btnGuardarCompra);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.btnImagenCompra);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.lbProveedor);
            this.Controls.Add(this.lbDescripcionCompra);
            this.Controls.Add(this.tbxDescripcionCompra);
            this.Controls.Add(this.btnEliminarCompra);
            this.Controls.Add(this.btnEditarCompra);
            this.Controls.Add(this.btnAgregarCompra);
            this.Controls.Add(this.dtgCompras);
            this.Controls.Add(this.lbDescuentoComp);
            this.Controls.Add(this.lbIVAcompra);
            this.Controls.Add(this.lbPrecioProducto);
            this.Controls.Add(this.lbCantProdComp);
            this.Controls.Add(this.lbNombreProducto);
            this.Controls.Add(this.tbxDescuentoComp);
            this.Controls.Add(this.tbxCantProductoComprado);
            this.Controls.Add(this.tbxPrecioProdCompra);
            this.Controls.Add(this.tbxIVAcompra);
            this.Controls.Add(this.tbxNombreProducto);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1Compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNombreProducto;
        private System.Windows.Forms.TextBox tbxIVAcompra;
        private System.Windows.Forms.TextBox tbxPrecioProdCompra;
        private System.Windows.Forms.TextBox tbxCantProductoComprado;
        private System.Windows.Forms.TextBox tbxDescuentoComp;
        private System.Windows.Forms.Label lbNombreProducto;
        private System.Windows.Forms.Label lbCantProdComp;
        private System.Windows.Forms.Label lbPrecioProducto;
        private System.Windows.Forms.Label lbIVAcompra;
        private System.Windows.Forms.Label lbDescuentoComp;
        private System.Windows.Forms.DataGridView dtgCompras;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.Button btnEditarCompra;
        private System.Windows.Forms.Button btnEliminarCompra;
        private System.Windows.Forms.TextBox tbxDescripcionCompra;
        private System.Windows.Forms.Label lbDescripcionCompra;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Button btnImagenCompra;
        private System.Windows.Forms.ErrorProvider errorProvider1Compras;
        private System.Windows.Forms.OpenFileDialog openFileDialogCompra;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.TextBox tbxFactura;
        private System.Windows.Forms.Label lbNumeroFact;
    }
}