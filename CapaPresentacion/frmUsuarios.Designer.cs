namespace CapaPresentacion
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdocumento = new TextBox();
            txtnombrecompleto = new TextBox();
            txtcorreo = new TextBox();
            label5 = new Label();
            txtconfirmarclave = new TextBox();
            label6 = new Label();
            cborol = new ComboBox();
            cboestado = new ComboBox();
            label7 = new Label();
            label = new Label();
            txtclave = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btneditar = new FontAwesome.Sharp.IconButton();
            btnelimiar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            dgvData = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            idUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txtid = new TextBox();
            label10 = new Label();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 473);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(11, 28);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "No Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(11, 72);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(11, 46);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(243, 23);
            txtdocumento.TabIndex = 4;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(11, 90);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(243, 23);
            txtnombrecompleto.TabIndex = 5;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(11, 134);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(243, 23);
            txtcorreo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(11, 204);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 7;
            label5.Text = "Confirmar Contraseña";
            // 
            // txtconfirmarclave
            // 
            txtconfirmarclave.Location = new Point(11, 222);
            txtconfirmarclave.Name = "txtconfirmarclave";
            txtconfirmarclave.Size = new Size(243, 23);
            txtconfirmarclave.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(12, 248);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 9;
            label6.Text = "Rol";
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(11, 266);
            cborol.Name = "cborol";
            cborol.Size = new Size(243, 23);
            cborol.TabIndex = 10;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(9, 310);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(245, 23);
            cboestado.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(11, 292);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 12;
            label7.Text = "Estado";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.White;
            label.Location = new Point(11, 160);
            label.Name = "label";
            label.Size = new Size(67, 15);
            label.TabIndex = 13;
            label.Text = "Contraseña";
            label.Click += label8_Click;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(11, 178);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(243, 23);
            txtclave.TabIndex = 14;
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
            btnguardar.Location = new Point(12, 352);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(225, 26);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.RoyalBlue;
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatAppearance.BorderColor = Color.Black;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.ForeColor = Color.White;
            btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btneditar.IconColor = Color.White;
            btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditar.IconSize = 16;
            btneditar.Location = new Point(10, 395);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(227, 26);
            btneditar.TabIndex = 16;
            btneditar.Text = "Editar";
            btneditar.TextAlign = ContentAlignment.MiddleRight;
            btneditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneditar.UseVisualStyleBackColor = false;
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
            btnelimiar.Location = new Point(10, 427);
            btnelimiar.Name = "btnelimiar";
            btnelimiar.Size = new Size(227, 26);
            btnelimiar.TabIndex = 17;
            btnelimiar.Text = "Eliminar";
            btnelimiar.TextAlign = ContentAlignment.MiddleRight;
            btnelimiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnelimiar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(39, 0);
            label8.Name = "label8";
            label8.Size = new Size(145, 28);
            label8.TabIndex = 18;
            label8.Text = "Detalle Usuario";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, idUsuario, Documento, NombreCompleto, Correo, Clave, idRol, Rol, EstadoValor, Estado });
            dgvData.Location = new Point(304, 80);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(779, 381);
            dgvData.TabIndex = 19;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 50;
            // 
            // idUsuario
            // 
            idUsuario.HeaderText = "idUsuario";
            idUsuario.Name = "idUsuario";
            idUsuario.ReadOnly = true;
            idUsuario.Visible = false;
            // 
            // Documento
            // 
            Documento.HeaderText = "No Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
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
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            // 
            // idRol
            // 
            idRol.HeaderText = "idRol";
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            idRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
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
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(304, 9);
            label9.Name = "label9";
            label9.Size = new Size(779, 60);
            label9.TabIndex = 20;
            label9.Text = "Lista De Usuarios";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            txtid.Location = new Point(217, 14);
            txtid.Name = "txtid";
            txtid.Size = new Size(37, 23);
            txtid.TabIndex = 21;
            txtid.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(510, 36);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 22;
            label10.Text = "Buscar Por:";
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(591, 33);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(149, 23);
            cbobusqueda.TabIndex = 23;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(746, 33);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(171, 23);
            txtbusqueda.TabIndex = 24;
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
            btnlimpiar.Location = new Point(1015, 28);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(56, 31);
            btnlimpiar.TabIndex = 26;
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
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
            btnbuscar.Location = new Point(939, 28);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(63, 31);
            btnbuscar.TabIndex = 25;
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1083, 473);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label10);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(dgvData);
            Controls.Add(label8);
            Controls.Add(btnelimiar);
            Controls.Add(btneditar);
            Controls.Add(btnguardar);
            Controls.Add(txtclave);
            Controls.Add(label);
            Controls.Add(label7);
            Controls.Add(cboestado);
            Controls.Add(cborol);
            Controls.Add(label6);
            Controls.Add(txtconfirmarclave);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(txtnombrecompleto);
            Controls.Add(txtdocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdocumento;
        private TextBox txtnombrecompleto;
        private TextBox txtcorreo;
        private Label label5;
        private TextBox txtconfirmarclave;
        private Label label6;
        private ComboBox cborol;
        private ComboBox cboestado;
        private Label label7;
        private Label label;
        private TextBox txtclave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnelimiar;
        private Label label8;
        private DataGridView dgvData;
        private Label label9;
        private TextBox txtid;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn idUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Label label10;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
    }
}