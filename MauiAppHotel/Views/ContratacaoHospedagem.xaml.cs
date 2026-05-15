using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();

        }
        private async void AbrirSobre(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Sobre));
        }

    }
}