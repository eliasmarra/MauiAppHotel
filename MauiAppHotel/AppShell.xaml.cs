using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Sobre), typeof(Sobre));

        }
    }
}
