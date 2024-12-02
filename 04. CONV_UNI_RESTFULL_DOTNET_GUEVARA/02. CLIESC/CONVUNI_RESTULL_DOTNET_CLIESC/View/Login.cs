using CONVUNI_RESTULL_DOTNET_CLIESC.Controller;
using CONVUNI_RESTULL_DOTNET_CLIESC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVUNI_RESTULL_DOTNET_CLIESC.View
{
    public partial class Login : Form
    {
        private LoginController _loginController;

        public Login()
        {
            InitializeComponent();
            _loginController = new LoginController();

            // Asociar el evento del botón al método btnLogin_Click
            btnLogin.Click += BtnLogin_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return;
            }

            var loginModel = new LoginModel
            {
                username = username,
                password = password
            };

            bool isAuthenticated = await _loginController.Login(loginModel);
            if (isAuthenticated)
            {
                this.Hide();
                Conversion conversionView = new Conversion();
                conversionView.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
