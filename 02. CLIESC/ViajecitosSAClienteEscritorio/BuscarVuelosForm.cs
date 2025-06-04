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
    public partial class BuscarVuelosForm : Form
    {
        private readonly string usuario;
        private readonly CondorServiceSoapClient client = new CondorServiceSoapClient();
        public BuscarVuelosForm(string usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var origen = txtOrigen.Text.ToUpper();
            var destino = txtDestino.Text.ToUpper();

            var vuelos = client.ObtenerVuelos(origen, destino);

            if (vuelos == null || vuelos.Length == 0)
            {
                lblMensaje.Text = "No se encontraron vuelos.";
                gridVuelos.DataSource = null;
            }
            else
            {
                gridVuelos.DataSource = vuelos;
                lblMensaje.Text = $"{vuelos.Length} vuelo(s) encontrados.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
