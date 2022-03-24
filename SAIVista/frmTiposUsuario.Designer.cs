namespace SAIVista
{
    partial class frmTiposUsuario
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbAlta = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbCreacion = new System.Windows.Forms.TextBox();
            this.tbBaja = new System.Windows.Forms.TextBox();
            this.dtgTipos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(532, 436);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 28);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Dar de Baja";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(387, 436);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 28);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(244, 436);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 28);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbPrecio.Location = new System.Drawing.Point(10, 274);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(176, 29);
            this.lbPrecio.TabIndex = 25;
            this.lbPrecio.Text = "Fecha de Baja";
            // 
            // lbAlta
            // 
            this.lbAlta.AutoSize = true;
            this.lbAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbAlta.Location = new System.Drawing.Point(10, 207);
            this.lbAlta.Name = "lbAlta";
            this.lbAlta.Size = new System.Drawing.Size(191, 29);
            this.lbAlta.TabIndex = 24;
            this.lbAlta.Text = "Fecha Creación";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(15, 166);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(202, 22);
            this.tbDescripcion.TabIndex = 23;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbDescripcion.Location = new System.Drawing.Point(10, 138);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(146, 29);
            this.lbDescripcion.TabIndex = 22;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(15, 101);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(202, 22);
            this.tbCodigo.TabIndex = 21;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCodigo.Location = new System.Drawing.Point(10, 73);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(93, 29);
            this.lbCodigo.TabIndex = 20;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbTitulo.Location = new System.Drawing.Point(7, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(123, 48);
            this.lbTitulo.TabIndex = 19;
            this.lbTitulo.Text = "Tipos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(675, 436);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 28);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbCreacion
            // 
            this.tbCreacion.Enabled = false;
            this.tbCreacion.Location = new System.Drawing.Point(15, 249);
            this.tbCreacion.Name = "tbCreacion";
            this.tbCreacion.Size = new System.Drawing.Size(202, 22);
            this.tbCreacion.TabIndex = 35;
            // 
            // tbBaja
            // 
            this.tbBaja.Enabled = false;
            this.tbBaja.Location = new System.Drawing.Point(15, 315);
            this.tbBaja.Name = "tbBaja";
            this.tbBaja.Size = new System.Drawing.Size(202, 22);
            this.tbBaja.TabIndex = 36;
            // 
            // dtgTipos
            // 
            this.dtgTipos.AllowUserToAddRows = false;
            this.dtgTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipos.Location = new System.Drawing.Point(244, 12);
            this.dtgTipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgTipos.Name = "dtgTipos";
            this.dtgTipos.ReadOnly = true;
            this.dtgTipos.RowHeadersWidth = 51;
            this.dtgTipos.RowTemplate.Height = 24;
            this.dtgTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipos.Size = new System.Drawing.Size(547, 419);
            this.dtgTipos.TabIndex = 37;
            this.dtgTipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTipos_CellContentClick);
            // 
            // frmTiposUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 484);
            this.Controls.Add(this.dtgTipos);
            this.Controls.Add(this.tbBaja);
            this.Controls.Add(this.tbCreacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbAlta);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmTiposUsuario";
            this.Text = "Gestionar Tipos de Usuarios";
            this.Load += new System.EventHandler(this.frmTiposUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbAlta;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbCreacion;
        private System.Windows.Forms.TextBox tbBaja;
        private System.Windows.Forms.DataGridView dtgTipos;
    }
}