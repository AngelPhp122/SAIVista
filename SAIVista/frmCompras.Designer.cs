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
            this.tbxNombreProducto = new System.Windows.Forms.TextBox();
            this.txbNumeroFactura = new System.Windows.Forms.TextBox();
            this.tbxIVAcompra = new System.Windows.Forms.TextBox();
            this.tbxPrecioProdCompra = new System.Windows.Forms.TextBox();
            this.tbxCantProductoComprado = new System.Windows.Forms.TextBox();
            this.tbxDescuentoComp = new System.Windows.Forms.TextBox();
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.lbFactura = new System.Windows.Forms.Label();
            this.lbCantProdComp = new System.Windows.Forms.Label();
            this.lbPrecioProducto = new System.Windows.Forms.Label();
            this.lbIVAcompra = new System.Windows.Forms.Label();
            this.lbDescuentoComp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.btnEditarCompra = new System.Windows.Forms.Button();
            this.btnEliminarCompra = new System.Windows.Forms.Button();
            this.tbxDescripcionCompra = new System.Windows.Forms.TextBox();
            this.lbDescripcionCompra = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNombreProducto
            // 
            this.tbxNombreProducto.Location = new System.Drawing.Point(114, 74);
            this.tbxNombreProducto.Name = "tbxNombreProducto";
            this.tbxNombreProducto.Size = new System.Drawing.Size(170, 20);
            this.tbxNombreProducto.TabIndex = 0;
            // 
            // txbNumeroFactura
            // 
            this.txbNumeroFactura.Location = new System.Drawing.Point(114, 140);
            this.txbNumeroFactura.Name = "txbNumeroFactura";
            this.txbNumeroFactura.Size = new System.Drawing.Size(170, 20);
            this.txbNumeroFactura.TabIndex = 1;
            // 
            // tbxIVAcompra
            // 
            this.tbxIVAcompra.Location = new System.Drawing.Point(114, 400);
            this.tbxIVAcompra.Name = "tbxIVAcompra";
            this.tbxIVAcompra.Size = new System.Drawing.Size(100, 20);
            this.tbxIVAcompra.TabIndex = 2;
            // 
            // tbxPrecioProdCompra
            // 
            this.tbxPrecioProdCompra.Location = new System.Drawing.Point(114, 277);
            this.tbxPrecioProdCompra.Name = "tbxPrecioProdCompra";
            this.tbxPrecioProdCompra.Size = new System.Drawing.Size(100, 20);
            this.tbxPrecioProdCompra.TabIndex = 3;
            // 
            // tbxCantProductoComprado
            // 
            this.tbxCantProductoComprado.Location = new System.Drawing.Point(114, 211);
            this.tbxCantProductoComprado.Name = "tbxCantProductoComprado";
            this.tbxCantProductoComprado.Size = new System.Drawing.Size(100, 20);
            this.tbxCantProductoComprado.TabIndex = 4;
            // 
            // tbxDescuentoComp
            // 
            this.tbxDescuentoComp.Location = new System.Drawing.Point(114, 457);
            this.tbxDescuentoComp.Name = "tbxDescuentoComp";
            this.tbxDescuentoComp.Size = new System.Drawing.Size(100, 20);
            this.tbxDescuentoComp.TabIndex = 5;
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Location = new System.Drawing.Point(-2, 77);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(106, 13);
            this.lbNombreProducto.TabIndex = 6;
            this.lbNombreProducto.Text = "Nombre del producto";
            // 
            // lbFactura
            // 
            this.lbFactura.AutoSize = true;
            this.lbFactura.Location = new System.Drawing.Point(2, 143);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(63, 13);
            this.lbFactura.TabIndex = 7;
            this.lbFactura.Text = "Factura No.";
            // 
            // lbCantProdComp
            // 
            this.lbCantProdComp.AutoSize = true;
            this.lbCantProdComp.Location = new System.Drawing.Point(2, 214);
            this.lbCantProdComp.Name = "lbCantProdComp";
            this.lbCantProdComp.Size = new System.Drawing.Size(110, 13);
            this.lbCantProdComp.TabIndex = 8;
            this.lbCantProdComp.Text = "Cantidad de Producto";
            // 
            // lbPrecioProducto
            // 
            this.lbPrecioProducto.AutoSize = true;
            this.lbPrecioProducto.Location = new System.Drawing.Point(5, 283);
            this.lbPrecioProducto.Name = "lbPrecioProducto";
            this.lbPrecioProducto.Size = new System.Drawing.Size(99, 13);
            this.lbPrecioProducto.TabIndex = 9;
            this.lbPrecioProducto.Text = "Precio del producto";
            // 
            // lbIVAcompra
            // 
            this.lbIVAcompra.AutoSize = true;
            this.lbIVAcompra.Location = new System.Drawing.Point(6, 400);
            this.lbIVAcompra.Name = "lbIVAcompra";
            this.lbIVAcompra.Size = new System.Drawing.Size(62, 13);
            this.lbIVAcompra.TabIndex = 10;
            this.lbIVAcompra.Text = "IVA compra";
            // 
            // lbDescuentoComp
            // 
            this.lbDescuentoComp.AutoSize = true;
            this.lbDescuentoComp.Location = new System.Drawing.Point(5, 460);
            this.lbDescuentoComp.Name = "lbDescuentoComp";
            this.lbDescuentoComp.Size = new System.Drawing.Size(59, 13);
            this.lbDescuentoComp.TabIndex = 11;
            this.lbDescuentoComp.Text = "Descuento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 511);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Location = new System.Drawing.Point(290, 590);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarCompra.TabIndex = 13;
            this.btnAgregarCompra.Text = "Agregar";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            // 
            // btnEditarCompra
            // 
            this.btnEditarCompra.Location = new System.Drawing.Point(615, 590);
            this.btnEditarCompra.Name = "btnEditarCompra";
            this.btnEditarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnEditarCompra.TabIndex = 14;
            this.btnEditarCompra.Text = "Editar";
            this.btnEditarCompra.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Location = new System.Drawing.Point(1006, 590);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarCompra.TabIndex = 15;
            this.btnEliminarCompra.Text = "Eliminar";
            this.btnEliminarCompra.UseVisualStyleBackColor = true;
            // 
            // tbxDescripcionCompra
            // 
            this.tbxDescripcionCompra.Location = new System.Drawing.Point(114, 338);
            this.tbxDescripcionCompra.Name = "tbxDescripcionCompra";
            this.tbxDescripcionCompra.Size = new System.Drawing.Size(170, 20);
            this.tbxDescripcionCompra.TabIndex = 16;
            // 
            // lbDescripcionCompra
            // 
            this.lbDescripcionCompra.AutoSize = true;
            this.lbDescripcionCompra.Location = new System.Drawing.Point(5, 345);
            this.lbDescripcionCompra.Name = "lbDescripcionCompra";
            this.lbDescripcionCompra.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcionCompra.TabIndex = 17;
            this.lbDescripcionCompra.Text = "Descripcion";
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Location = new System.Drawing.Point(6, 512);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(56, 13);
            this.lbProveedor.TabIndex = 18;
            this.lbProveedor.Text = "Proveedor";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(110, 512);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(166, 21);
            this.cbxProveedor.TabIndex = 19;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 625);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.lbProveedor);
            this.Controls.Add(this.lbDescripcionCompra);
            this.Controls.Add(this.tbxDescripcionCompra);
            this.Controls.Add(this.btnEliminarCompra);
            this.Controls.Add(this.btnEditarCompra);
            this.Controls.Add(this.btnAgregarCompra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbDescuentoComp);
            this.Controls.Add(this.lbIVAcompra);
            this.Controls.Add(this.lbPrecioProducto);
            this.Controls.Add(this.lbCantProdComp);
            this.Controls.Add(this.lbFactura);
            this.Controls.Add(this.lbNombreProducto);
            this.Controls.Add(this.tbxDescuentoComp);
            this.Controls.Add(this.tbxCantProductoComprado);
            this.Controls.Add(this.tbxPrecioProdCompra);
            this.Controls.Add(this.tbxIVAcompra);
            this.Controls.Add(this.txbNumeroFactura);
            this.Controls.Add(this.tbxNombreProducto);
            this.Name = "frmCompras";
            this.Text = "Compras";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNombreProducto;
        private System.Windows.Forms.TextBox txbNumeroFactura;
        private System.Windows.Forms.TextBox tbxIVAcompra;
        private System.Windows.Forms.TextBox tbxPrecioProdCompra;
        private System.Windows.Forms.TextBox tbxCantProductoComprado;
        private System.Windows.Forms.TextBox tbxDescuentoComp;
        private System.Windows.Forms.Label lbNombreProducto;
        private System.Windows.Forms.Label lbFactura;
        private System.Windows.Forms.Label lbCantProdComp;
        private System.Windows.Forms.Label lbPrecioProducto;
        private System.Windows.Forms.Label lbIVAcompra;
        private System.Windows.Forms.Label lbDescuentoComp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.Button btnEditarCompra;
        private System.Windows.Forms.Button btnEliminarCompra;
        private System.Windows.Forms.TextBox tbxDescripcionCompra;
        private System.Windows.Forms.Label lbDescripcionCompra;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.ComboBox cbxProveedor;
    }
}