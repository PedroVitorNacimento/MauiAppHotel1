using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Navega de volta para a p�gina anterior
            await Navigation.PopAsync();
        }
    }
}
