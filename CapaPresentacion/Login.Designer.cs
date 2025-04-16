namespace CapaPresentacion
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtDocumento = new TextBox();
            txtClave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            BtnIngresar = new FontAwesome.Sharp.IconButton();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 310);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 227);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 1;
            label2.Text = "Sistema De Ventas";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 140;
            iconPictureBox1.Location = new Point(66, 55);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(144, 140);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(300, 40);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(169, 23);
            txtDocumento.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(300, 151);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(169, 23);
            txtClave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 22);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "No Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 120);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.RoyalBlue;
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnIngresar.IconColor = Color.White;
            BtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnIngresar.IconSize = 20;
            BtnIngresar.Location = new Point(289, 227);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(126, 28);
            BtnIngresar.TabIndex = 7;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.TextAlign = ContentAlignment.MiddleRight;
            BtnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Firebrick;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            BtnCancelar.IconColor = Color.White;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 20;
            BtnCancelar.Location = new Point(433, 227);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(116, 28);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 310);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnIngresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtClave);
            Controls.Add(txtDocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtDocumento;
        private TextBox txtClave;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton BtnIngresar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
    }
}