namespace SAIVista
{
    partial class frmCategorias
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
            this.tbNombreCat = new System.Windows.Forms.TextBox();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.lbApellido = new System.Windows.Forms.Label();
            this.tbIDcat = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombreCat
            // 
            this.tbNombreCat.Location = new System.Drawing.Point(20, 177);
            this.tbNombreCat.Name = "tbNombreCat";
            this.tbNombreCat.Size = new System.Drawing.Size(202, 22);
            this.tbNombreCat.TabIndex = 73;
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.AllowUserToAddRows = false;
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Location = new System.Drawing.Point(249, 20);
            this.dtgCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.ReadOnly = true;
            this.dtgCategorias.RowHeadersWidth = 51;
            this.dtgCategorias.RowTemplate.Height = 24;
            this.dtgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategorias.Size = new System.Drawing.Size(675, 487);
            this.dtgCategorias.TabIndex = 68;
            this.dtgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategorias_CellContentClick);
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.Location = new System.Drawing.Point(808, 527);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(116, 28);
            this.btnLimpiarC.TabIndex = 67;
            this.btnLimpiarC.Text = "Limpiar";
            this.btnLimpiarC.UseVisualStyleBackColor = true;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiarC_Click);
            // 
            // btnEditarC
            // 
            this.btnEditarC.Location = new System.Drawing.Point(533, 527);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(116, 28);
            this.btnEditarC.TabIndex = 66;
            this.btnEditarC.Text = "Actualizar";
            this.btnEditarC.UseVisualStyleBackColor = true;
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(249, 527);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(116, 28);
            this.btnAgregarC.TabIndex = 65;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbApellido.Location = new System.Drawing.Point(15, 145);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(219, 29);
            this.lbApellido.TabIndex = 63;
            this.lbApellido.Text = "Nombre Categoría";
            // 
            // tbIDcat
            // 
            this.tbIDcat.Enabled = false;
            this.tbIDcat.Location = new System.Drawing.Point(20, 98);
            this.tbIDcat.Name = "tbIDcat";
            this.tbIDcat.Size = new System.Drawing.Size(202, 22);
            this.tbIDcat.TabIndex = 60;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbID.Location = new System.Drawing.Point(15, 70);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(37, 29);
            this.lbID.TabIndex = 59;
            this.lbID.Text = "ID";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(222, 48);
            this.lbTitulo.TabIndex = 58;
            this.lbTitulo.Text = "Categorías";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 580);
            this.Controls.Add(this.tbNombreCat);
            this.Controls.Add(this.dtgCategorias);
            this.Controls.Add(this.btnLimpiarC);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.tbIDcat);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmCategorias";
            this.Text = "Gestión de Categorías";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNombreCat;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private System.Windows.Forms.Button btnLimpiarC;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox tbIDcat;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTitulo;
    }
}