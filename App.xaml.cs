
using Microsoft.Maui.Controls;
using EventosApp.Views;

namespace EventosApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastroEventoPage());
        }
    }
}
