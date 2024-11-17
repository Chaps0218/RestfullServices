using CONVUNI_RESTFULL_DOTNET_CLICON.Views;
namespace CONVUNI_RESTFULL_DOTNET_CLICON 
{
    class Program
    {
        private LoginView _loginView;
        static void Main(string[] args)
        {
            LoginView loginView = new LoginView();
            ConvView convView = new ConvView();
            loginView.Start().Wait();
            convView.Start().Wait();
        }
    }
}