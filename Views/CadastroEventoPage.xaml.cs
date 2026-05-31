
using Microsoft.Maui.Controls;
using EventosApp.Models;

namespace EventosApp.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            var evento = (Evento)BindingContext;
            await Navigation.PushAsync(new ResumoEventoPage(evento));
        }
    }
}
