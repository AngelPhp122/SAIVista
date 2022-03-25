namespace SAIVista
{
    partial class homeForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdminitrar_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVenderProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiAdminitrar_articulos,
            this.tsmiClientes,
            this.tsmiVenderProducto,
            this.tsmiReportes,
            this.tsmiUsuario,
            this.comprasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(59, 24);
            this.tsmiInicio.Text = "Inicio";
            // 
            // tsmiAdminitrar_articulos
            // 
            this.tsmiAdminitrar_articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProductos,
            this.tsmiCategoria});
            this.tsmiAdminitrar_articulos.Name = "tsmiAdminitrar_articulos";
            this.tsmiAdminitrar_articulos.Size = new System.Drawing.Size(171, 24);
            this.tsmiAdminitrar_articulos.Text = "Administrar productos";
            // 
            // tsmiProductos
            // 
            this.tsmiProductos.Name = "tsmiProductos";
            this.tsmiProductos.Size = new System.Drawing.Size(163, 26);
            this.tsmiProductos.Text = "Productos";
            this.tsmiProductos.Click += new System.EventHandler(this.tsmiProductos_Click);
            // 
            // tsmiCategoria
            // 
            this.tsmiCategoria.Name = "tsmiCategoria";
            this.tsmiCategoria.Size = new System.Drawing.Size(163, 26);
            this.tsmiCategoria.Text = "Categorias";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(75, 24);
            this.tsmiClientes.Text = "Clientes";
            // 
            // tsmiVenderProducto
            // 
            this.tsmiVenderProducto.Name = "tsmiVenderProducto";
            this.tsmiVenderProducto.Size = new System.Drawing.Size(125, 24);
            this.tsmiVenderProducto.Text = "Vender Articulo";
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(82, 24);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiUsuario
            // 
            this.tsmiUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalir});
            this.tsmiUsuario.Name = "tsmiUsuario";
            this.tsmiUsuario.Size = new System.Drawing.Size(69, 24);
            this.tsmiUsuario.Text = "Sesion:";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(121, 26);
            this.tsmiSalir.Text = "Salir";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            this.registrarCompraToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // registrarProveedorToolStripMenuItem
            // 
            this.registrarProveedorToolStripMenuItem.Name = "registrarProveedorToolStripMenuItem";
            this.registrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.registrarProveedorToolStripMenuItem.Text = "Registrar Proveedor";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposUsuarioToolStripMenuItem,
            this.gestionDeUsuariosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 24);
            this.toolStripMenuItem1.Text = "Usuarios";
            // 
            // tiposUsuarioToolStripMenuItem
            // 
            this.tiposUsuarioToolStripMenuItem.Name = "tiposUsuarioToolStripMenuItem";
            this.tiposUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tiposUsuarioToolStripMenuItem.Text = "Tipos Usuario";
            this.tiposUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tiposUsuarioToolStripMenuItem_Click);
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // homeForm
            // 
            this.ClientSize = new System.Drawing.Size(914, 361);
            this.Controls.Add(this.menuStrip1);
            this.Name = "homeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdminitrar_articulos;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiVenderProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiposUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
    }
}

