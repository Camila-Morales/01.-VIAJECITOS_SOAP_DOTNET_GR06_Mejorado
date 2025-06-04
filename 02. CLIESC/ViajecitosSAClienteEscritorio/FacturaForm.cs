using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViajecitosSAClienteEscritorio.CondorService;

namespace ViajecitosSAClienteEscritorio
{
    public partial class FacturaForm : Form
    {
        private readonly CondorServiceSoapClient client = new CondorServiceSoapClient();

        public FacturaForm()
        {
            InitializeComponent();
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtEdad.Text = "";
            txtNacionalidad.Text = "";
            txtOrigenDestino.Text = "";
            txtHoraSalida.Text = "";
            txtCantidad.Text = "";
            txtPrecioUnitario.Text = "";
            txtPrecioTotal.Text = "";
            txtFecha.Text = "";
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdFactura.Text, out int idFactura))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            try
            {
                var factura = client.ObtenerFacturaPorId(idFactura);

                if (factura == null)
                {
                    MessageBox.Show("Factura no encontrada.");
                    LimpiarCampos();
                    return;
                }

                // Mostrar los datos
                txtUsuario.Text = factura.NombreUsuario;
                txtEdad.Text = factura.EdadUsuario.ToString();
                txtNacionalidad.Text = factura.NacionalidadUsuario;
                txtOrigenDestino.Text = $"{factura.CiudadOrigen} → {factura.CiudadDestino}";
                txtHoraSalida.Text = factura.HoraSalida.ToString("g");
                txtCantidad.Text = factura.Cantidad.ToString();
                txtPrecioUnitario.Text = factura.PrecioUnitario.ToString("C");
                txtPrecioTotal.Text = factura.PrecioTotal.ToString("C");
                txtFecha.Text = factura.FechaEmision.ToString("g");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la factura: " + ex.Message);
            }

        }
    }
}
