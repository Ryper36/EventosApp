
using Microsoft.Maui.Controls;
using EventosApp.Models;

namespace EventosApp.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}
