namespace CapaPresentacion
{
    partial class frmProducto
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label10 = new Label();
            txtid = new TextBox();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvData = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label8 = new Label();
            btnelimiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            cboestado = new ComboBox();
            cboCategoria = new ComboBox();
            label6 = new Label();
            txtdescripcion = new TextBox();
            txtnombre = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnexportar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.ForestGreen;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.White;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.White;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 16;
            btnbuscar.Location = new Point(975, 28);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 31);
            btnbuscar.TabIndex = 52;
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(782, 33);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(171, 23);
            txtbusqueda.TabIndex = 51;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(627, 33);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(149, 23);
            cbobusqueda.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(546, 36);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 49;
            label10.Text = "Buscar Por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(253, 14);
            txtid.Name = "txtid";
            txtid.Size = new Size(37, 23);
            txtid.TabIndex = 48;
            txtid.Text = "0";
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.RoyalBlue;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.White;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.White;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 16;
            btnlimpiarbuscador.Location = new Point(1051, 28);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(56, 31);
            btnlimpiarbuscador.TabIndex = 53;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(340, 9);
            label9.Name = "label9";
            label9.Size = new Size(779, 60);
            label9.TabIndex = 47;
            label9.Text = "Lista De Productos";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.RoyalBlue;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 16;
            btnlimpiar.Location = new Point(47, 307);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(227, 26);
            btnlimpiar.TabIndex = 43;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, id, Codigo, Nombre, Descripcion, idCategoria, Categoria, Stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dgvData.Location = new Point(322, 80);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(938, 285);
            dgvData.TabIndex = 46;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre ";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 180;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 150;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "idCategoria";
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = true;
            idCategoria.Visible = false;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(75, 0);
            label8.Name = "label8";
            label8.Size = new Size(159, 28);
            label8.TabIndex = 45;
            label8.Text = "Detalle Producto";
            // 
            // btnelimiar
            // 
            btnelimiar.BackColor = Color.Firebrick;
            btnelimiar.Cursor = Cursors.Hand;
            btnelimiar.FlatAppearance.BorderColor = Color.Black;
            btnelimiar.FlatStyle = FlatStyle.Flat;
            btnelimiar.ForeColor = Color.White;
            btnelimiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnelimiar.IconColor = Color.White;
            btnelimiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnelimiar.IconSize = 16;
            btnelimiar.Location = new Point(48, 339);
            btnelimiar.Name = "btnelimiar";
            btnelimiar.Size = new Size(227, 26);
            btnelimiar.TabIndex = 44;
            btnelimiar.Text = "Eliminar";
            btnelimiar.TextAlign = ContentAlignment.MiddleRight;
            btnelimiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnelimiar.UseVisualStyleBackColor = false;
            btnelimiar.Click += btnelimiar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.ForestGreen;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 16;
            btnguardar.Location = new Point(47, 275);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(225, 26);
            btnguardar.TabIndex = 42;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(46, 215);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 39;
            label7.Text = "Estado";
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(44, 233);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(245, 23);
            cboestado.TabIndex = 38;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(47, 189);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(243, 23);
            cboCategoria.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(48, 171);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 36;
            label6.Text = "Categoria";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(47, 134);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(243, 23);
            txtdescripcion.TabIndex = 33;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(47, 90);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(243, 23);
            txtnombre.TabIndex = 32;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(47, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(243, 23);
            txtCodigo.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(48, 116);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 30;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(47, 72);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 29;
            label3.Text = "Nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(47, 28);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 28;
            label2.Text = "Codigo";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 419);
            label1.TabIndex = 27;
            // 
            // btnexportar
            // 
            btnexportar.BackColor = Color.LightSlateGray;
            btnexportar.Cursor = Cursors.Hand;
            btnexportar.FlatAppearance.BorderColor = Color.Black;
            btnexportar.FlatStyle = FlatStyle.Flat;
            btnexportar.ForeColor = Color.White;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnexportar.IconColor = Color.White;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnexportar.IconSize = 16;
            btnexportar.Location = new Point(50, 371);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(225, 26);
            btnexportar.TabIndex = 54;
            btnexportar.Text = "Descargar Excel";
            btnexportar.TextAlign = ContentAlignment.MiddleRight;
            btnexportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click_1;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 419);
            Controls.Add(btnexportar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label10);
            Controls.Add(txtid);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(label9);
            Controls.Add(btnlimpiar);
            Controls.Add(dgvData);
            Controls.Add(label8);
            Controls.Add(btnelimiar);
            Controls.Add(btnguardar);
            Controls.Add(label7);
            Controls.Add(cboestado);
            Controls.Add(cboCategoria);
            Controls.Add(label6);
            Controls.Add(txtdescripcion);
            Controls.Add(txtnombre);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label10;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvData;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnelimiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label7;
        private ComboBox cboestado;
        private ComboBox cboCategoria;
        private Label label6;
        private TextBox txtdescripcion;
        private TextBox txtnombre;
        private TextBox txtCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton btnexportar;
    }
}