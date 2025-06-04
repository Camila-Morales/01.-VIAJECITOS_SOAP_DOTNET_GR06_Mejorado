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
    public partial class BuscarVuelosPorFiltroForm : Form
    {
        private readonly CondorServiceSoapClient client = new CondorServiceSoapClient();
        public BuscarVuelosPorFiltroForm()
        {
            InitializeComponent();
            // Configurar ComboBox con opciones de filtro
            comboFiltro.Items.Add("Origen");
            comboFiltro.Items.Add("Destino");
            comboFiltro.Items.Add("Fecha");
            comboFiltro.SelectedIndex = 0;
        }

        private void BuscarVuelosPorFiltroForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_Click(object sender, EventArgs e)
        {
            string tipoFiltro = comboFiltro.SelectedItem.ToString().ToLower();
            string valorFiltro = txtValorFiltro.Text.Trim();

            if (string.IsNullOrEmpty(valorFiltro))
            {
                lblMensaje.Text = "Por favor, ingrese un valor para buscar.";
                return;
            }

            // Validar fecha si filtro es fecha
            if (tipoFiltro == "fecha")
            {
                if (!DateTime.TryParse(valorFiltro, out DateTime fecha))
                {
                    lblMensaje.Text = "Fecha inválida. Use formato yyyy-MM-dd.";
                    return;
                }
                // Formato de fecha a string esperado por el servicio (por si acaso)
                valorFiltro = fecha.ToString("yyyy-MM-dd");
            }

            // Llamar al servicio SOAP
            var vuelos = client.ObtenerVuelosPorFiltro(tipoFiltro, valorFiltro);

            if (vuelos == null || vuelos.Length == 0)
            {
                lblMensaje.Text = "No se encontraron vuelos para el filtro especificado.";
                gridVuelos.DataSource = null;
            }
            else
            {
                gridVuelos.DataSource = vuelos;
                lblMensaje.Text = $"{vuelos.Length} vuelo(s) encontrados.";
            }
        }
    }
}
