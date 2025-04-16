namespace CapaPresentacion
{
    partial class frmCategoria
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
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txtbusqueda = new TextBox();
            cbobuscar = new ComboBox();
            label10 = new Label();
            txtid = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            idcategoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label8 = new Label();
            btnelimiar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            cboestado = new ComboBox();
            txtdescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnbus = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txtbusqueda2 = new TextBox();
            cboBuscar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
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
            btnlimpiarbuscador.Location = new Point(997, 17);
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
            label9.Location = new Point(293, 5);
            label9.Name = "label9";
            label9.Size = new Size(779, 60);
            label9.TabIndex = 47;
            label9.Text = "Lista De Categorias";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(735, 36);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(171, 23);
            txtbusqueda.TabIndex = 51;
            // 
            // cbobusqueda
            // 
            cbobuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobuscar.FormattingEnabled = true;
            cbobuscar.Location = new Point(580, 36);
            cbobuscar.Name = "cbobusqueda";
            cbobuscar.Size = new Size(149, 23);
            cbobuscar.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(499, 39);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 49;
            label10.Text = "Buscar Por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(206, 17);
            txtid.Name = "txtid";
            txtid.Size = new Size(37, 23);
            txtid.TabIndex = 48;
            txtid.Text = "0";
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
            btnbuscar.Location = new Point(928, 31);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 31);
            btnbuscar.TabIndex = 52;
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, idcategoria, Descripcion, EstadoValor, Estado });
            dgvData.Location = new Point(304, 68);
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
            dgvData.Size = new Size(779, 195);
            dgvData.TabIndex = 46;
            dgvData.CellContentClick += dgvData_CellContentClick_1;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 50;
            // 
            // idcategoria
            // 
            idcategoria.HeaderText = "id";
            idcategoria.Name = "idcategoria";
            idcategoria.ReadOnly = true;
            idcategoria.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 150;
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
            label8.Location = new Point(28, 3);
            label8.Name = "label8";
            label8.Size = new Size(163, 28);
            label8.TabIndex = 45;
            label8.Text = "Detalle Categoria";
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
            btnelimiar.Location = new Point(14, 226);
            btnelimiar.Name = "btnelimiar";
            btnelimiar.Size = new Size(227, 26);
            btnelimiar.TabIndex = 44;
            btnelimiar.Text = "Eliminar";
            btnelimiar.TextAlign = ContentAlignment.MiddleRight;
            btnelimiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnelimiar.UseVisualStyleBackColor = false;
            btnelimiar.Click += btnelimiar_Click;
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
            btnlimpiar.Location = new Point(14, 194);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(227, 26);
            btnlimpiar.TabIndex = 43;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
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
            btnguardar.Location = new Point(14, 162);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(225, 26);
            btnguardar.TabIndex = 42;
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
            label7.Location = new Point(2, 103);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 39;
            label7.Text = "Estado";
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(12, 121);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(245, 23);
            cboestado.TabIndex = 38;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(12, 46);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(243, 23);
            txtdescripcion.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(0, 31);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 28;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 345);
            label1.TabIndex = 27;
            // 
            // btnbus
            // 
            btnbus.BackColor = Color.ForestGreen;
            btnbus.Cursor = Cursors.Hand;
            btnbus.FlatAppearance.BorderColor = Color.Black;
            btnbus.FlatStyle = FlatStyle.Flat;
            btnbus.ForeColor = Color.White;
            btnbus.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbus.IconColor = Color.White;
            btnbus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbus.IconSize = 16;
            btnbus.Location = new Point(928, 18);
            btnbus.Name = "btnbus";
            btnbus.Size = new Size(63, 31);
            btnbus.TabIndex = 54;
            btnbus.TextAlign = ContentAlignment.MiddleRight;
            btnbus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbus.UseVisualStyleBackColor = false;
            btnbus.Click += btnbus_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(499, 31);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 55;
            label11.Text = "Buscar Por:";
            // 
            // txtbusqueda2
            // 
            txtbusqueda2.Location = new Point(735, 23);
            txtbusqueda2.Name = "txtbusqueda2";
            txtbusqueda2.Size = new Size(171, 23);
            txtbusqueda2.TabIndex = 57;
            // 
            // cboBuscar
            // 
            cboBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscar.FormattingEnabled = true;
            cboBuscar.Location = new Point(580, 23);
            cboBuscar.Name = "cboBuscar";
            cboBuscar.Size = new Size(149, 23);
            cboBuscar.TabIndex = 56;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 345);
            Controls.Add(txtbusqueda2);
            Controls.Add(cboBuscar);
            Controls.Add(label11);
            Controls.Add(btnbus);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(label9);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobuscar);
            Controls.Add(label10);
            Controls.Add(txtid);
            Controls.Add(btnbuscar);
            Controls.Add(dgvData);
            Controls.Add(label8);
            Controls.Add(btnelimiar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(label7);
            Controls.Add(cboestado);
            Controls.Add(txtdescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private Label label9;
        private TextBox txtbusqueda;
        private ComboBox cbobuscar;
        private Label label10;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridView dgvData;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnelimiar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label7;
        private ComboBox cboestado;
        private TextBox txtdescripcion;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnbus;
        private Label label11;
        private TextBox txtbusqueda2;
        private ComboBox cboBuscar;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn idcategoria;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}