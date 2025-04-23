using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;



namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        private int indiceFilaSeleccionada = -1;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
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




        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            Cliente obj = new Cliente()
            {
                idCliente = Convert.ToInt32(txtid.Text),
                Documento = txtDocumento.Text.Trim(),
                NombreCompleto = txtnombre.Text.Trim(),
                Correo = txtcorreo.Text.Trim(),
                Telefono = telefonotxt.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1
            };

            if (obj.idCliente == 0)
            {
                int idGenerado = new CN_Cliente().Registrar(obj, out string mensaje);

                if (idGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {
                        "", idGenerado, obj.Documento, obj.NombreCompleto, obj.Correo, obj.Telefono,
                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                    MessageBox.Show("Cliente registrado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bool resultado = new CN_Cliente().Editar(obj, out string mensaje);

                if (resultado && indiceFilaSeleccionada >= 0)
                {
                    DataGridViewRow row = dgvData.Rows[indiceFilaSeleccionada];

                    row.Cells["NroDocumento"].Value = obj.Documento;
                    row.Cells["NombreCompleto"].Value = obj.NombreCompleto;
                    row.Cells["Correo"].Value = obj.Correo;
                    row.Cells["Telefono"].Value = obj.Telefono;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    Limpiar();
                    MessageBox.Show("Cliente actualizado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    txtid.Text = dgvData.Rows[indice].Cells[1].Value?.ToString() ?? "0";
                    txtDocumento.Text = dgvData.Rows[indice].Cells[2].Value?.ToString() ?? "";
                    txtnombre.Text = dgvData.Rows[indice].Cells[3].Value?.ToString() ?? "";
                    txtcorreo.Text = dgvData.Rows[indice].Cells[4].Value?.ToString() ?? "";
                    telefonotxt.Text = dgvData.Rows[indice].Cells[5].Value?.ToString() ?? "";

                    int.TryParse(dgvData.Rows[indice].Cells[6].Value?.ToString(), out int estadoValor);

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == estadoValor)
                        {
                            cboestado.SelectedIndex = cboestado.Items.IndexOf(oc);
                            break;
                        }
                    }
                }
            }
        }

        private void btnelimiar_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "0")
            {
                if (MessageBox.Show("¿Desea eliminar este cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cliente obj = new Cliente() { idCliente = Convert.ToInt32(txtid.Text) };
                    bool respuesta = new CN_Cliente().Eliminar(obj, out string mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(indiceFilaSeleccionada);
                        Limpiar();
                        MessageBox.Show("Cliente eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string texto = txtbusqueda.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese un término de búsqueda.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbobusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un criterio de búsqueda.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columna = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[columna].Value != null)
                {
                    string valor = row.Cells[columna].Value.ToString().ToLower();
                    row.Visible = valor.Contains(texto);
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnlimpiarbuscador_Click_1(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
