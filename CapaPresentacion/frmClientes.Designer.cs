namespace CapaPresentacion
{
    partial class frmClientes
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
            label8 = new Label();
            btnelimiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            cboestado = new ComboBox();
            txtcorreo = new TextBox();
            txtnombre = new TextBox();
            txtDocumento = new TextBox();
            label4 = new Label();
            label3 = new Label();
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
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            telefonotxt = new TextBox();
            txtTelefono = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(30, 0);
            label8.Name = "label8";
            label8.Size = new Size(138, 28);
            label8.TabIndex = 69;
            label8.Text = "Detalle Cliente";
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
            btnelimiar.Location = new Point(8, 379);
            btnelimiar.Name = "btnelimiar";
            btnelimiar.Size = new Size(227, 26);
            btnelimiar.TabIndex = 68;
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
            btnguardar.Location = new Point(10, 307);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(225, 26);
            btnguardar.TabIndex = 66;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(6, 235);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 65;
            label7.Text = "Estado";
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(6, 263);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(245, 23);
            cboestado.TabIndex = 64;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(5, 134);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(243, 23);
            txtcorreo.TabIndex = 61;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(5, 90);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(243, 23);
            txtnombre.TabIndex = 60;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(12, 46);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(243, 23);
            txtDocumento.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(5, 116);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 58;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(5, 72);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 57;
            label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(2, 28);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 56;
            label2.Text = "Nro Documento";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 503);
            label1.TabIndex = 55;
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
            btnbuscar.Location = new Point(916, 28);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 31);
            btnbuscar.TabIndex = 76;
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click_1;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(723, 33);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(171, 23);
            txtbusqueda.TabIndex = 75;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(568, 33);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(149, 23);
            cbobusqueda.TabIndex = 74;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(487, 36);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 73;
            label10.Text = "Buscar Por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(195, 14);
            txtid.Name = "txtid";
            txtid.Size = new Size(37, 23);
            txtid.TabIndex = 72;
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
            btnlimpiarbuscador.Location = new Point(992, 28);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(56, 31);
            btnlimpiarbuscador.TabIndex = 77;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click_1;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(304, 9);
            label9.Name = "label9";
            label9.Size = new Size(873, 60);
            label9.TabIndex = 71;
            label9.Text = "Lista De Clientes";
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
            btnlimpiar.Location = new Point(-11, 307);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(227, 26);
            btnlimpiar.TabIndex = 67;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, id, NroDocumento, NombreCompleto, Correo, Telefono, EstadoValor, Estado });
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
            dgvData.Size = new Size(960, 285);
            dgvData.TabIndex = 70;
            dgvData.CellContentClick += dgvData_CellContentClick_1;
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
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
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
            // telefonotxt
            // 
            telefonotxt.Location = new Point(5, 194);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(243, 23);
            telefonotxt.TabIndex = 79;
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.BackColor = Color.White;
            txtTelefono.Location = new Point(5, 174);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(53, 15);
            txtTelefono.TabIndex = 80;
            txtTelefono.Text = "Telefono";
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
            iconButton1.Location = new Point(8, 339);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(227, 26);
            iconButton1.TabIndex = 81;
            iconButton1.Text = "Limpiar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 503);
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
            Controls.Add(label3);
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
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private FontAwesome.Sharp.IconButton btnelimiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label7;
        private ComboBox cboestado;
        private TextBox txtcorreo;
        private TextBox txtnombre;
        private TextBox txtDocumento;
        private Label label4;
        private Label label3;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox telefonotxt;
        private Label txtTelefono;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}