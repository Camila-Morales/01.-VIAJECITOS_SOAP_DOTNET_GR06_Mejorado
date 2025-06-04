using System;
using System.Windows.Forms;

namespace ViajecitosSAClienteEscritorio
{
    public partial class MainForm : Form
    {
        private readonly string usuario;

        public MainForm(string usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
            lblBienvenida.Text = $"Bienvenido, {usuario}";
        }

        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            var buscarForm = new BuscarVuelosForm(usuario);
            buscarForm.ShowDialog();
        }

        private void btnComprarVuelos_Click(object sender, EventArgs e)
        {
            var comprarForm = new ComprarVuelosForm(usuario);
            comprarForm.ShowDialog();
        }

        private void btnBuscarVuelos_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
            var formFiltro = new BuscarVuelosPorFiltroForm();
            formFiltro.ShowDialog();
        }

        private void btn_Factura_Click(object sender, EventArgs e)
        {
            var form = new FacturaForm();
            form.ShowDialog();
        }
    }
}
