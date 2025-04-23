namespace CapaPresentacion
{
    partial class frmProveedor
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtTelefono = new Label();
            telefonotxt = new TextBox();
            label8 = new Label();
            btnelimiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            cboestado = new ComboBox();
            txtcorreo = new TextBox();
            txtnombre = new TextBox();
            txtDocumento = new TextBox();
            label4 = new Label();
            txtrazonsocial = new Label();
            label2 = new Label();
            label1 = new Label();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label10 = new Label();
            txtid = new TextBox();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.RoyalBlue;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(28, 339);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(227, 26);
            iconButton1.TabIndex = 105;
            iconButton1.Text = "Limpiar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.BackColor = Color.White;
            txtTelefono.Location = new Point(25, 174);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(53, 15);
            txtTelefono.TabIndex = 104;
            txtTelefono.Text = "Telefono";
            // 
            // telefonotxt
            // 
            telefonotxt.Location = new Point(25, 194);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(243, 23);
            telefonotxt.TabIndex = 103;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(50, 0);
            label8.Name = "label8";
            label8.Size = new Size(169, 28);
            label8.TabIndex = 94;
            label8.Text = "Detalle Proveedor";
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
            btnelimiar.Location = new Point(28, 379);
            btnelimiar.Name = "btnelimiar";
            btnelimiar.Size = new Size(227, 26);
            btnelimiar.TabIndex = 93;
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
            btnguardar.Location = new Point(30, 307);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(225, 26);
            btnguardar.TabIndex = 91;
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
            label7.Location = new Point(26, 235);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 90;
            label7.Text = "Estado";
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(26, 263);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(245, 23);
            cboestado.TabIndex = 89;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(25, 134);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(243, 23);
            txtcorreo.TabIndex = 88;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(25, 90);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(243, 23);
            txtnombre.TabIndex = 87;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(32, 46);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(243, 23);
            txtDocumento.TabIndex = 86;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(25, 116);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 85;
            label4.Text = "Correo";
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.AutoSize = true;
            txtrazonsocial.BackColor = Color.White;
            txtrazonsocial.Location = new Point(25, 72);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.Size = new Size(73, 15);
            txtrazonsocial.TabIndex = 84;
            txtrazonsocial.Text = "Razon Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(22, 28);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 83;
            label2.Text = "Nro Documento";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 528);
            label1.TabIndex = 82;
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
            btnbuscar.Location = new Point(936, 28);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 31);
            btnbuscar.TabIndex = 101;
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(743, 33);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(171, 23);
            txtbusqueda.TabIndex = 100;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(588, 33);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(149, 23);
            cbobusqueda.TabIndex = 99;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(507, 36);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 98;
            label10.Text = "Buscar Por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(215, 14);
            txtid.Name = "txtid";
            txtid.Size = new Size(37, 23);
            txtid.TabIndex = 97;
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
            btnlimpiarbuscador.Location = new Point(1012, 28);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(56, 31);
            btnlimpiarbuscador.TabIndex = 102;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(304, 9);
            label9.Name = "label9";
            label9.Size = new Size(782, 60);
            label9.TabIndex = 96;
            label9.Text = "Lista De Proveedor";
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
            btnlimpiar.Location = new Point(9, 307);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(227, 26);
            btnlimpiar.TabIndex = 92;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, id, NroDocumento, RazonSocial, Correo, Telefono, EstadoValor, Estado });
            dgvData.Location = new Point(304, 72);
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
            dgvData.Size = new Size(782, 285);
            dgvData.TabIndex = 95;
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
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro Documento";
            NroDocumento.Name = "NroDocumento";
            NroDocumento.ReadOnly = true;
            NroDocumento.Width = 150;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "Estado valor";
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
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 528);
            Controls.Add(iconButton1);
            Controls.Add(txtTelefono);
            Controls.Add(telefonotxt);
            Controls.Add(label8);
            Controls.Add(btnelimiar);
            Controls.Add(btnguardar);
            Controls.Add(label7);
            Controls.Add(cboestado);
            Controls.Add(txtcorreo);
            Controls.Add(txtnombre);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(txtrazonsocial);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label10);
            Controls.Add(txtid);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(label9);
            Controls.Add(btnlimpiar);
            Controls.Add(dgvData);
            Name = "frmProveedor";
            Text = "frmProveedor";
            Load += frmProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label txtTelefono;
        private TextBox telefonotxt;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnelimiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label7;
        private ComboBox cboestado;
        private TextBox txtcorreo;
        private TextBox txtnombre;
        private TextBox txtDocumento;
        private Label label4;
        private Label txtrazonsocial;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label10;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private DataGridView dgvData;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}