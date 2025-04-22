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
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        private int indiceFilaSeleccionada = -1;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new Utilidades.OpcionCombo() { Texto = "Activo", Valor = 1 });
            cboestado.Items.Add(new Utilidades.OpcionCombo() { Texto = "No Activo", Valor = 0 });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Categoria> listaCategoria = new CN_Categoria().Listar();
            foreach (Categoria item in listaCategoria)
            {
                cboCategoria.Items.Add(new Utilidades.OpcionCombo() { Texto = item.Descripcion, Valor = item.idCategoria });
            }
            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";
            cboCategoria.SelectedIndex = 0;

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

            List<Producto> lista = new CN_Producto().Listar();
            foreach (Producto item in lista)
            {
                dgvData.Rows.Add(new object[] {
                    "",
                    item.idProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.idCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                item.Estado ==  true ? 1 : 0 ,
                item.Estado == true ? "Activo" : "No Activo",
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Producto obj = new Producto()
            {
                idProducto = Convert.ToInt32(txtid.Text == "" ? "0" : txtid.Text),
                Codigo = txtCodigo.Text.Trim(),
                Nombre = Nombre.HeaderText.Trim(),
                Descripcion = Descripcion.HeaderText.Trim(),
                oCategoria = new Categoria() { idCategoria = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).Valor) },
                Estado = Convert.ToBoolean(((OpcionCombo)cboestado.SelectedItem).Valor)
            };

            if (obj.idProducto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(obj, out string Mensaje);

                if (idgenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {
                        "",
                        idgenerado,
                        txtCodigo.Text,
                        txtnombre.Text,
                        txtdescripcion.Text,
                        ((OpcionCombo)cboCategoria.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboCategoria.SelectedItem).Texto.ToString(),
                        "0",
                        "0-00",
                        "0-00",

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
                bool resultado = new CN_Producto().Editar(obj, out string Mensaje);

                if (resultado && indiceFilaSeleccionada >= 0)
                {
                    DataGridViewRow row = dgvData.Rows[indiceFilaSeleccionada];

                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtCodigo.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["idCategoria"].Value = ((OpcionCombo)cboCategoria.SelectedItem).Texto.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cboCategoria.SelectedItem).Texto.ToString();

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
            txtCodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            indiceFilaSeleccionada = -1;
            txtCodigo.Select();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    indiceFilaSeleccionada = indice;

                    txtid.Text = dgvData.Rows[indice].Cells["id"].Value.ToString();
                    txtCodigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtnombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();


                    cboestado.SelectedIndex = cboestado.FindString(dgvData.Rows[indice].Cells["Estado"].Value.ToString());

                    foreach (OpcionCombo oc in cboCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idCategoria"].Value))
                        {
                            int indice_combo = cboCategoria.Items.IndexOf(oc);
                            cboCategoria.SelectedIndex = indice_combo;
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

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            }
        }

        private void btnelimiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text) && txtid.Text != "0") 
            {
                if (MessageBox.Show("¿Realmente desea eliminar el Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        idProducto = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dgvData.Rows.Count) // Validar el índice
                        {
                            dgvData.Rows.RemoveAt(indiceFilaSeleccionada); // Eliminar la fila de la grilla
                            limpiar(); // Limpiar los campos después de eliminar
                            MessageBox.Show("Registro eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la fila de la grilla. Intente seleccionar de nuevo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo eliminar el Producto: {mensaje}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto válido para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtbusqueda.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya un criterio de búsqueda seleccionado
            if (cbobusqueda.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el criterio de búsqueda seleccionado
            string criterioBusqueda = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[criterioBusqueda].Value != null)
                {
                    string valorCelda = row.Cells[criterioBusqueda].Value.ToString().ToLower();

                    // Mostrar u ocultar filas según el texto de búsqueda
                    row.Visible = valorCelda.Contains(textoBusqueda);
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = string.Empty;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true; // Mostrar todas las filas
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

       

        private void btnexportar_Click_1(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();

            // Crear columnas en el DataTable
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (!string.IsNullOrWhiteSpace(column.HeaderText) && column.Visible)
                {
                    dt.Columns.Add(column.HeaderText, typeof(string));
                }
            }

            // Agregar filas visibles al DataTable
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Visible)
                {
                    List<object> fila = new List<object>();

                    foreach (DataGridViewColumn column in dgvData.Columns)
                    {
                        if (!string.IsNullOrWhiteSpace(column.HeaderText) && column.Visible)
                        {
                            fila.Add(row.Cells[column.Index].Value?.ToString() ?? string.Empty);
                        }
                    }

                    dt.Rows.Add(fila.ToArray());
                }
            }

            // Mostrar diálogo para guardar
            SaveFileDialog saveFile = new SaveFileDialog
            {
                FileName = $"Reporte_Productos_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                Filter = "Excel Files|*.xlsx"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var wb = new ClosedXML.Excel.XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.Columns().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                    }

                    MessageBox.Show("Exportación exitosa.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}



