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
    public partial class ComprarVuelosForm : Form
    {
        private readonly string usuario;
        private readonly CondorServiceSoapClient client = new CondorServiceSoapClient();
        private Vuelo[] vuelosActuales;
        public ComprarVuelosForm(string usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var origen = txtOrigen.Text.ToUpper();
            var destino = txtDestino.Text.ToUpper();

            vuelosActuales = client.ObtenerVuelos(origen, destino);

            if (vuelosActuales == null || vuelosActuales.Length == 0)
            {
                lblMensaje.Text = "No se encontraron vuelos.";
                gridVuelos.DataSource = null;
            }
            else
            {
                gridVuelos.DataSource = vuelosActuales;
                lblMensaje.Text = $"{vuelosActuales.Length} vuelo(s) encontrados.";
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (gridVuelos.CurrentRow == null)
            {
                lblMensaje.Text = "Selecciona un vuelo.";
                return;
            }

            var vueloSeleccionado = (Vuelo)gridVuelos.CurrentRow.DataBoundItem;
            var respuesta = client.ComprarVuelo(vueloSeleccionado.Id, 1); // hardcoded 1 asiento

            lblMensaje.Text = respuesta;
        }
    }
}
