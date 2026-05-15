using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void AbrirSobre(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}
