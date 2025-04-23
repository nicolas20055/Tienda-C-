using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido;
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido && byteimage.Length > 0)
            {
                piclogo.Image = ByteToImage(byteimage);
            }

            Negocio datos = new CN_Negocio().ObtenerDatos();
            txtNombreCompleto.Text = datos.Nombre;
            txtRut.Text = datos.Rut;
            txtDir.Text = datos.Direccion;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                piclogo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Negocio obj = new Negocio()
            {
                Nombre = txtNombreCompleto.Text,
                Rut = txtRut.Text,
                Direccion = txtDir.Text
            };

            string mensaje = string.Empty;

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
            {
                if (piclogo.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        piclogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Usa PNG por compatibilidad
                        byte[] imagen = ms.ToArray();
                        bool actualizado = new CN_Negocio().ActualizarLogo(imagen, out string mensajeLogo);

                        if (!actualizado)
                        {
                            MessageBox.Show("No se pudo actualizar el logo.\n" + mensajeLogo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show("Datos guardados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
                else
                {
                    MessageBox.Show("Error: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
        }
    }
}
