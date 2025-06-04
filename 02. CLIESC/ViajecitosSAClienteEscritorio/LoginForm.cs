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
    public partial class LoginForm : Form
    {
        public string UsuarioAutenticado { get; private set; }

        private CondorServiceSoapClient client = new CondorServiceSoapClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var pass = txtPassword.Text;

            var respuesta = client.Login(usuario, pass);

            if (respuesta.Contains("concedido"))
            {
                UsuarioAutenticado = usuario;
                DialogResult = DialogResult.OK;
                Close(); // cerrar Login y seguir al principal
            }
            else
            {
                lblMensaje.Text = "Credenciales incorrectas.";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
