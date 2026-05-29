using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class CadastroEvento : ContentPage
{
    Evento e = new Evento();

    public CadastroEvento()
    {
        InitializeComponent();

        e.DataInicio = DateTime.Now;
        e.DataTermino = DateTime.Now;

        dtpck_inicio.MinimumDate = DateTime.Today;
        dtpck_termino.MinimumDate = DateTime.Today;

        BindingContext = e;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoEvento(this.e));
    }
}