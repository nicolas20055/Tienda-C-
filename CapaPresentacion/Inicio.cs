using CapaEntidad;
using FontAwesome.Sharp;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem menuactivo = null;
        private static Form formularioActivo = null;

        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
            
                usuarioActual = new Usuario() { NombreCompleto = "Admin predefinido", idUsuario = 1 };
            
            else
            
                usuarioActual = objusuario;
            

            InitializeComponent();
        }

        private void MenuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenimiento, new frmClientes());
        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuactivo != null)
            {
                menuactivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuactivo = menu;
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(formulario);
            formulario.Show();


        }
        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuTitulo_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.idUsuario);

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item is IconMenuItem iconMenu)
                {
                    bool encontrado = ListaPermisos.Any(p => p.Menu == iconMenu.Name);
                    if (!encontrado)
                    {
                        iconMenu.Visible = false;
                    }
                }
            }

            lblUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenimiento, new frmCategoria());

        }

        private void SubMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenimiento, new frmProducto());

        }

        private void SubMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmVentas());

        }
        private void SubMenuDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmDetalleVenta());
        }

        private void SubMenuRegistarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(Compras, new frmCompras());
        }

        private void SubMenuDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(Compras, new frmDetalleCompra());
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedor());
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void MenuMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
