using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private int indiceFilaSeleccionada = -1;
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            cboestado.Items.Add(new OpcionCombo() { Texto = "No Activo", Valor = 0 });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Texto = columna.HeaderText, Valor = columna.Name });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            if (cbobusqueda.Items.Count > 0) cbobusqueda.SelectedIndex = 0;

            List<Cliente> lista = new CN_Cliente().Listar();
            foreach (Cliente item in lista)
            {
                dgvData.Rows.Add(new object[] {
                    "", item.idCliente, item.Documento, item.NombreCompleto, item.Correo, item.Telefono,
                    item.Estado ? 1 : 0,
                    item.Estado ? "Activo" : "No Activo"
                });
            }
        }

        private void Limpiar()
        {
            txtid.Text = "0";
            txtDocumento.Text = "";
            txtnombre.Text = "";
            txtcorreo.Text = "";
            telefonotxt.Text = "";
            cboestado.SelectedIndex = 0;
            indiceFilaSeleccionada = -1;
        }




    }
}
