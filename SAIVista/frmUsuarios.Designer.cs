namespace SAIVista
{
    partial class frmUsuarios
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
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbClave = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.cmTipo = new System.Windows.Forms.ComboBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(245, 11);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 24;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(675, 487);
            this.dtgUsuarios.TabIndex = 51;
            this.dtgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick);
            this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellContentClick_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(804, 517);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 28);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(529, 517);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 28);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(245, 517);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 28);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbEmail.Location = new System.Drawing.Point(11, 261);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(78, 29);
            this.lbEmail.TabIndex = 44;
            this.lbEmail.Text = "Email";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbApellido.Location = new System.Drawing.Point(11, 194);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(104, 29);
            this.lbApellido.TabIndex = 43;
            this.lbApellido.Text = "Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(16, 153);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(202, 22);
            this.tbNombre.TabIndex = 42;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbNombre.Location = new System.Drawing.Point(11, 125);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(103, 29);
            this.lbNombre.TabIndex = 41;
            this.lbNombre.Text = "Nombre";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(16, 88);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(202, 22);
            this.tbID.TabIndex = 40;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbID.Location = new System.Drawing.Point(11, 60);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(37, 29);
            this.lbID.TabIndex = 39;
            this.lbID.Text = "ID";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbTitulo.Location = new System.Drawing.Point(8, -1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(185, 48);
            this.lbTitulo.TabIndex = 38;
            this.lbTitulo.Text = "Usuarios";
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbClave.Location = new System.Drawing.Point(11, 336);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(78, 29);
            this.lbClave.TabIndex = 52;
            this.lbClave.Text = "Clave";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(16, 377);
            this.tbClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(202, 22);
            this.tbClave.TabIndex = 53;
            this.tbClave.UseSystemPasswordChar = true;
            // 
            // cmTipo
            // 
            this.cmTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTipo.FormattingEnabled = true;
            this.cmTipo.Location = new System.Drawing.Point(16, 458);
            this.cmTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmTipo.Name = "cmTipo";
            this.cmTipo.Size = new System.Drawing.Size(202, 24);
            this.cmTipo.TabIndex = 54;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTipo.Location = new System.Drawing.Point(11, 418);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(191, 29);
            this.lbTipo.TabIndex = 55;
            this.lbTipo.Text = "Tipo de Usuario";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(16, 226);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(202, 22);
            this.tbApellido.TabIndex = 56;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(16, 293);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(202, 22);
            this.tbEmail.TabIndex = 57;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 557);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.cmTipo);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmUsuarios";
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.ComboBox cmTipo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbEmail;
    }
}