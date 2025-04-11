namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuTitulo = new MenuStrip();
            MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            MenuMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            SubMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            SubMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            SubMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            SubMenuDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            Compras = new FontAwesome.Sharp.IconMenuItem();
            SubMenuRegistarCompra = new FontAwesome.Sharp.IconMenuItem();
            SubMenuDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            lblNombre = new Label();
            lblUsuario = new Label();
            Contenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.SteelBlue;
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.RightToLeft = RightToLeft.Yes;
            MenuTitulo.Size = new Size(994, 67);
            MenuTitulo.TabIndex = 3;
            MenuTitulo.ItemClicked += MenuTitulo_ItemClicked_1;
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.AutoSize = false;
            MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            MenuUsuarios.IconColor = Color.Black;
            MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(80, 67);
            MenuUsuarios.Text = "Usuarios";
            MenuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuUsuarios.Click += iconMenuItem5_Click;
            // 
            // MenuMantenimiento
            // 
            MenuMantenimiento.AutoSize = false;
            MenuMantenimiento.DropDownItems.AddRange(new ToolStripItem[] { SubMenuCategoria, SubMenuProducto });
            MenuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            MenuMantenimiento.IconColor = Color.Black;
            MenuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuMantenimiento.ImageScaling = ToolStripItemImageScaling.None;
            MenuMantenimiento.Name = "MenuMantenimiento";
            MenuMantenimiento.Size = new Size(122, 67);
            MenuMantenimiento.Text = "Mantenimiento";
            MenuMantenimiento.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuMantenimiento.Click += MenuMantenimiento_Click;
            // 
            // SubMenuCategoria
            // 
            SubMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuCategoria.IconColor = Color.Black;
            SubMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuCategoria.Name = "SubMenuCategoria";
            SubMenuCategoria.Size = new Size(180, 22);
            SubMenuCategoria.Text = "Categoria";
            SubMenuCategoria.Click += SubMenuCategoria_Click;
            // 
            // SubMenuProducto
            // 
            SubMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuProducto.IconColor = Color.Black;
            SubMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuProducto.Name = "SubMenuProducto";
            SubMenuProducto.Size = new Size(180, 22);
            SubMenuProducto.Text = "Producto";
            SubMenuProducto.Click += SubMenuProducto_Click;
            // 
            // MenuVentas
            // 
            MenuVentas.AutoSize = false;
            MenuVentas.DropDownItems.AddRange(new ToolStripItem[] { SubMenuRegistrarVenta, SubMenuDetalleVenta });
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            MenuVentas.IconColor = Color.Black;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(122, 67);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistrarVenta
            // 
            SubMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuRegistrarVenta.IconColor = Color.Black;
            SubMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuRegistrarVenta.Name = "SubMenuRegistrarVenta";
            SubMenuRegistrarVenta.Size = new Size(142, 22);
            SubMenuRegistrarVenta.Text = "Registrar";
            SubMenuRegistrarVenta.Click += SubMenuRegistrarVenta_Click;
            // 
            // SubMenuDetalleVenta
            // 
            SubMenuDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuDetalleVenta.IconColor = Color.Black;
            SubMenuDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuDetalleVenta.Name = "SubMenuDetalleVenta";
            SubMenuDetalleVenta.Size = new Size(142, 22);
            SubMenuDetalleVenta.Text = "Detalle Venta";
            SubMenuDetalleVenta.Click += SubMenuDetalleVenta_Click;
            // 
            // Compras
            // 
            Compras.AutoSize = false;
            Compras.DropDownItems.AddRange(new ToolStripItem[] { SubMenuRegistarCompra, SubMenuDetalleCompra });
            Compras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            Compras.IconColor = Color.Black;
            Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Compras.ImageScaling = ToolStripItemImageScaling.None;
            Compras.Name = "Compras";
            Compras.Size = new Size(80, 67);
            Compras.Text = "Compras";
            Compras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistarCompra
            // 
            SubMenuRegistarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuRegistarCompra.IconColor = Color.Black;
            SubMenuRegistarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuRegistarCompra.Name = "SubMenuRegistarCompra";
            SubMenuRegistarCompra.Size = new Size(156, 22);
            SubMenuRegistarCompra.Text = "Registrar";
            SubMenuRegistarCompra.Click += SubMenuRegistarCompra_Click;
            // 
            // SubMenuDetalleCompra
            // 
            SubMenuDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            SubMenuDetalleCompra.IconColor = Color.Black;
            SubMenuDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuDetalleCompra.Name = "SubMenuDetalleCompra";
            SubMenuDetalleCompra.Size = new Size(156, 22);
            SubMenuDetalleCompra.Text = "Detalle Compra";
            SubMenuDetalleCompra.Click += SubMenuDetalleCompra_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = false;
            MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            MenuClientes.IconColor = Color.Black;
            MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(122, 67);
            MenuClientes.Text = "Clientes";
            MenuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuClientes.Click += iconMenuItem7_Click;
            // 
            // MenuProveedores
            // 
            MenuProveedores.AutoSize = false;
            MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            MenuProveedores.IconColor = Color.Black;
            MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            MenuProveedores.Name = "MenuProveedores";
            MenuProveedores.Size = new Size(122, 67);
            MenuProveedores.Text = "Proveedores";
            MenuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProveedores.Click += MenuProveedores_Click;
            // 
            // MenuReportes
            // 
            MenuReportes.AutoSize = false;
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            MenuReportes.IconColor = Color.Black;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(122, 67);
            MenuReportes.Text = "Reportes";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuReportes.Click += MenuReportes_Click;
            // 
            // MenuAcercaDe
            // 
            MenuAcercaDe.AutoSize = false;
            MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            MenuAcercaDe.IconColor = Color.Black;
            MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            MenuAcercaDe.Name = "MenuAcercaDe";
            MenuAcercaDe.Size = new Size(122, 67);
            MenuAcercaDe.Text = "Acerca De";
            MenuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuUsuarios, MenuMantenimiento, MenuVentas, Compras, MenuClientes, MenuProveedores, MenuReportes, MenuAcercaDe });
            menuStrip1.Location = new Point(0, 67);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 71);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 36);
            label1.TabIndex = 2;
            label1.Text = "Sistema Ventas";
            label1.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.SteelBlue;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(679, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 23);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.SteelBlue;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(750, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(115, 23);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "lblUsuario";
            // 
            // Contenedor
            // 
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(0, 138);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(994, 312);
            Contenedor.TabIndex = 7;
            Contenedor.Paint += Contenedor_Paint;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 450);
            Controls.Add(Contenedor);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(MenuTitulo);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem MenuMantenimiento;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem Compras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private MenuStrip menuStrip1;
        private Label label1;
        private Label lblNombre;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem SubMenuProducto;
        private Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem SubMenuDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistarCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuDetalleCompra;
    }
}
