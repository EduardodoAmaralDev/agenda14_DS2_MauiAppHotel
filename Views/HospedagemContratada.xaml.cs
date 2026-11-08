
using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada(Hospedagem hospedagem)
    {
        InitializeComponent();

        // Exibe os dados dos hóspedes
        lbl_adultos.Text = $"Adultos: {hospedagem.Adultos}";
        lbl_criancas.Text = $"Crianças: {hospedagem.Criancas}";

        // Exibe a acomodação selecionada
        lbl_suite.Text = hospedagem.QuartoSelecionado.Descricao;

        // Exibe as datas da hospedagem
        lbl_checkin.Text =
            $"Check-in: {hospedagem.CheckIn:dd/MM/yyyy}";

        lbl_checkout.Text =
            $"Check-out: {hospedagem.CheckOut:dd/MM/yyyy}";

        // Exibe a quantidade de diárias
        lbl_diarias.Text =
            $"Quantidade de diárias: {hospedagem.Diarias}";

        // Exibe o valor total
        lbl_valor_total.Text =
            hospedagem.ValorTotal.ToString("C2");
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
