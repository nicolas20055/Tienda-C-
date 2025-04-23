namespace CapaPresentacion
{
    partial class frmNegocio
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
            label8 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            txtDir = new TextBox();
            label5 = new Label();
            txtRut = new TextBox();
            label4 = new Label();
            txtNombreCompleto = new TextBox();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            piclogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(24, 9);
            label8.Name = "label8";
            label8.Size = new Size(153, 28);
            label8.TabIndex = 20;
            label8.Text = "Detalle Negocio";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(582, 494);
            label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(iconButton2);
            groupBox1.Controls.Add(txtDir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtRut);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(iconButton1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(piclogo);
            groupBox1.Location = new Point(24, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 308);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.LightGray;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(202, 246);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(171, 26);
            iconButton2.TabIndex = 9;
            iconButton2.Text = "Guardar Cambios";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(168, 200);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(267, 23);
            txtDir.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 169);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Direccion:";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(168, 119);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(267, 23);
            txtRut.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 88);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "R.U.T";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(168, 50);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(267, 23);
            txtNombreCompleto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 19);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre Completo:";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.LightGray;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(6, 169);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(121, 26);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Subir";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Logo:";
            // 
            // piclogo
            // 
            piclogo.Location = new Point(6, 30);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(134, 113);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 494);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private PictureBox piclogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtRut;
        private Label label4;
        private TextBox txtNombreCompleto;
        private Label label3;
        private TextBox txtDir;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}