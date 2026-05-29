using System;
using MauiAppHotel.Models;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();

            pck_quarto.ItemsSource = App.lista_quartos;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_checkout.MinimumDate = dtpck_checkin.Date?.AddDays(1);
            dtpck_checkin.MaximumDate = dtpck_checkin.Date?.AddMonths(2);

        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {


            dtpck_checkin.MinimumDate = e.NewDate?.AddDays(1);
            dtpck_checkin.MaximumDate = e.NewDate?.AddMonths(4);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Hospedagem h = new()
                {
                    QntAdultos = Convert.ToInt32(stp_adultos.Value),
                    QntCriancas = Convert.ToInt32(stp_criancas.Value),
                    QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                    DataCheckIn = Convert.ToDateTime(dtpck_checkin.Date),
                    DataCheckOut = Convert.ToDateTime(dtpck_checkout.Date)

                };

                Navigation.PushAsync(new HospedagemContratada()
                {
                    BindingContext = h
                });

            }
            catch (Exception ex)
            {
                DisplayAlertAsync("Ops", ex.Message, "OK");

            }
        }

        private async void AbrirSobre(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Sobre));
        }

    }
}