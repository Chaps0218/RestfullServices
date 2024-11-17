using CONVUNI_RESTFULL_DOTNET_CLIMOV.Controllers;
using CONVUNI_RESTFULL_DOTNET_CLIMOV.Models;

namespace CONVUNI_RESTFULL_DOTNET_CLIMOV
{
    public partial class MainPage : ContentPage
    {
        private readonly ConvController _convController = new();
        private readonly LoginController _loginController = new();

        public MainPage()
        {
            InitializeComponent();
            var units = new List<string> { "PA", "ATM", "BAR", "mmHg", "PSI" };
            FromUnitPicker.ItemsSource = units;
            ToUnitPicker.ItemsSource = units;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            try
            {
                // Disable the login button to prevent double clicks
                var loginButton = sender as Button;
                if (loginButton != null)
                    loginButton.IsEnabled = false;

                var username = UsernameEntry.Text?.Trim();
                var password = PasswordEntry.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    await DisplayAlert("Error", "Please enter both username and password", "OK");
                    return;
                }

                LoginModel loginModel = new()
                {
                    username = username,
                    password = password
                };

                bool success = await _loginController.Login(loginModel);

                if (success)
                {
                    await DisplayAlert("Success", "Login successful", "OK");
                    ToggleVisibility(isLoggedIn: true);
                }
                else
                {
                    await DisplayAlert("Error", "Error en el login","OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                var loginButton = sender as Button;
                if (loginButton != null)
                    loginButton.IsEnabled = true;
            }
        }

        private async void OnConvertClicked(object sender, EventArgs e)
        {
            if (double.TryParse(ValueEntry.Text, out double value) &&
                FromUnitPicker.SelectedItem != null &&
                ToUnitPicker.SelectedItem != null)
            {
                string fromUnit = FromUnitPicker.SelectedItem.ToString();
                string toUnit = ToUnitPicker.SelectedItem.ToString();

                ConversionRequest requestModel = new()
                {
                    FromUnit = fromUnit,
                    ToUnit = toUnit,
                    Value = value
                };

                string result = await _convController.Convertir(requestModel);
                ResultLabel.Text = result;
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese valores válidos.", "OK");
            }
        }

        private void OnBackToLoginClicked(object sender, EventArgs e)
        {
            ToggleVisibility(isLoggedIn: false);
        }

        private void ToggleVisibility(bool isLoggedIn)
        {
            LoginStack.IsVisible = !isLoggedIn;
            ConversionStack.IsVisible = isLoggedIn;
        }
    }

}
