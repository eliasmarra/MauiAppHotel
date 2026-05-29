using MauiAppHotel.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public static List<Quarto> lista_quartos = new()
        {
            new Quarto()
            { 
                Descricao = "Suite Simples", 
                ValorDiariaAdulto = 70.0, 
                ValorDiariaCrianca = 30.0 
            },

            new Quarto()
            {
                Descricao = "Suite Plus",
                ValorDiariaAdulto = 100,
                ValorDiariaCrianca = 50
            },

            new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 120,
                ValorDiariaCrianca = 70
            },

            new Quarto()
            {
                Descricao = "Suite VIP",
                ValorDiariaAdulto = 150,
                ValorDiariaCrianca = 85
            },
        };

        public App()
        {
            InitializeComponent();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var w = new Window(new AppShell());

            w.Height = 700;
            w.Width = 350;

            return w;
        }
        
    }
}//Fecha namespace