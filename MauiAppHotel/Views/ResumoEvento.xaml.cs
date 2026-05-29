using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ResumoEvento : ContentPage
{
	public ResumoEvento(Evento e)
	{
		InitializeComponent();
        BindingContext = e;
    }
}