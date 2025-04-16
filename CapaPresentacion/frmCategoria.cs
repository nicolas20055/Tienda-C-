using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        private int indiceFilaSeleccionada = -1;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new Utilidades.OpcionCombo() { Texto = "Activo", Valor = 1 });
            cboestado.Items.Add(new Utilidades.OpcionCombo() { Texto = "No Activo", Valor = 0 });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobuscar.Items.Add(new OpcionCombo() { Texto = columna.HeaderText, Valor = columna.Name });
                }
            }

            cboBuscar.Items.Add("Descripcion");
            cboBuscar.Items.Add("Estado");
            cboBuscar.SelectedIndex = 0; // Selección por defecto

            List<Categoria> lista = new CN_Categoria().Listar();
            foreach (Categoria item in lista)
            {
                dgvData.Rows.Add(new object[] { "", item.idCategoria,
                    item.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categoria obj = new Categoria()
            {
                idCategoria = Convert.ToInt32(string.IsNullOrEmpty(txtid.Text) ? "0" : txtid.Text),
                Descripcion = txtdescripcion.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1
            };

            if (string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (obj.idCategoria == 0)
            {
                // Registrar nueva categoría
                int idGenerado = new CN_Categoria().Registrar(obj, out mensaje);
                if (idGenerado != 0)
                {
                    dgvData.Rows.Add("", idGenerado, obj.Descripcion, obj.Estado ? 1 : 0, obj.Estado ? "Activo" : "No Activo");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Editar categoría existente
                bool resultado = new CN_Categoria().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[indiceFilaSeleccionada];
                    row.Cells["idcategoria"].Value = obj.idCategoria;
                    row.Cells["Descripcion"].Value = obj.Descripcion;
                    row.Cells["EstadoValor"].Value = obj.Estado ? 1 : 0;
                    row.Cells["Estado"].Value = obj.Estado ? "Activo" : "No Activo";
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Limpiar()
        {
            indiceFilaSeleccionada = -1;
            txtid.Text = "0";
            txtdescripcion.Text = "";
            cboestado.SelectedIndex = 0;
            txtdescripcion.Select();
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobuscar.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
    }
}
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    indiceFilaSeleccionada = indice;

                    txtid.Text = dgvData.Rows[indice].Cells["idcategoria"].Value.ToString();
                    txtdescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

                    cboestado.SelectedIndex = cboestado.FindString(dgvData.Rows[indice].Cells["Estado"].Value.ToString());

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

        private void btnelimiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text) && txtid.Text != "0") // Validar que el ID no sea vacío o "0"
            {
                if (MessageBox.Show("¿Realmente desea eliminar la Categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {
                        idCategoria = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Categoria().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dgvData.Rows.Count) // Validar el índice
                        {
                            dgvData.Rows.RemoveAt(indiceFilaSeleccionada); // Eliminar la fila de la grilla
                            Limpiar();
                            MessageBox.Show("Categoria eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la fila de la grilla. Intente seleccionar de nuevo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo eliminar la Categoria {mensaje}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Categoria válida para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

 
           private void btnbus_Click(object sender, EventArgs e)
        {
            string columnaFiltro = cboBuscar.SelectedItem?.ToString();
            string textoBusqueda = txtbusqueda2.Text.Trim();

            if (string.IsNullOrEmpty(columnaFiltro))
            {
                MessageBox.Show("Seleccione un campo por el cual buscar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoBusqueda.ToUpper()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }



        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda2.Text = "";
            cboBuscar.SelectedIndex = -1;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

    }
}


