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
    public partial class frmUsuarios : Form
    {
        private int indiceFilaSeleccionada = -1;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new Utilidades.OpcionCombo() { Texto = "Activo", Valor = 1 });
            cboestado.Items.Add(new Utilidades.OpcionCombo() { Texto = "No Activo", Valor = 0 });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new Utilidades.OpcionCombo() { Texto = item.Descripcion, Valor = item.idRol });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Texto = columna.HeaderText, Valor = columna.Name });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] {"",item.idUsuario,item.Documento,item.NombreCompleto,item.Correo,item.clave,
                item.oRol.idRol,
                item.oRol.Descripcion,
                item.Estado ==  true ? 1 : 0 ,
                item.Estado == true ? "Activo" : "No Activo",
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario()
            {
                idUsuario = Convert.ToInt32(txtid.Text == "" ? "0" : txtid.Text),
                Documento = txtdocumento.Text.Trim(),
                NombreCompleto = txtnombrecompleto.Text.Trim(),
                Correo = txtcorreo.Text.Trim(),
                clave = txtclave.Text.Trim(),
                oRol = new Rol() { idRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) },
                Estado = Convert.ToBoolean(((OpcionCombo)cboestado.SelectedItem).Valor)
            };

            if (obj.idUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(obj, out string Mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {
                        "", idusuariogenerado, txtdocumento.Text, txtnombrecompleto.Text, txtcorreo.Text, txtclave.Text,
                        ((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                    });

                    limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(obj, out string Mensaje);

                if (resultado && indiceFilaSeleccionada >= 0)
                {
                    DataGridViewRow row = dgvData.Rows[indiceFilaSeleccionada];

                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["clave"].Value = txtclave.Text;
                    row.Cells["idRol"].Value = ((OpcionCombo)cborol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void limpiar()
        {
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            indiceFilaSeleccionada = -1; // limpiar también el índice seleccionado
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    indiceFilaSeleccionada = indice; // capturamos el índice

                    txtid.Text = dgvData.Rows[indice].Cells["id"].Value.ToString();
                    txtdocumento.Text = dgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvData.Rows[indice].Cells["clave"].Value.ToString();

                    cboestado.SelectedIndex = cboestado.FindString(dgvData.Rows[indice].Cells["Estado"].Value.ToString());

                    foreach (OpcionCombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
