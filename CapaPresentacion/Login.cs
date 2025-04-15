using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
                List<Usuario> Test = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtDocumento.Text && u.clave  == txtClave.Text).FirstOrDefault();


            if (ousuario != null)
            {
                Inicio Form = new Inicio(ousuario);

                Form.Show();
                this.Hide();
                Form.FormClosing += new FormClosingEventHandler(frm_closing);
            }
            else
            {
                   MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
              
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
                txtDocumento.Text = "";
                txtClave.Text = "";
            this.Show();
        }
    }
}
