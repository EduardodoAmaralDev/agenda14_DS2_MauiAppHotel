
using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    // Lista de acomodações
    private List<Quarto> _quartos;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        // Cria a lista de objetos Quarto
        _quartos = new List<Quarto>
        {
            new Quarto("Suíte Simples", 200m),
            new Quarto("Suíte Master", 300m),
            new Quarto("Suíte Família", 450m)
        };

        // Vincula a lista ao Picker
        pck_quarto.ItemsSource = _quartos;

        // Define a propriedade que será exibida no Picker
        pck_quarto.ItemDisplayBinding =
            new Binding(nameof(Quarto.Descricao));

        // Configura as datas iniciais
        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.Date = DateTime.Today;

        dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
        dtpck_checkout.Date = DateTime.Today.AddDays(1);

        // Atualiza o check-out quando o check-in mudar
        dtpck_checkin.DateSelected += OnCheckInDateSelected;
    }

    // Abre a página Sobre
    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }

    // Atualiza a data mínima do check-out
    private void OnCheckInDateSelected(object? sender, DateChangedEventArgs e)
    {
        DateTime novoCheckin = e.NewDate ?? DateTime.Today;

        dtpck_checkout.MinimumDate = novoCheckin.AddDays(1);

        if (dtpck_checkout.Date <= novoCheckin)
        {
            dtpck_checkout.Date = novoCheckin.AddDays(1);
        }
    }

    // Valida os dados e realiza a contratação
    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        // Obtém a quantidade de hóspedes
        int adultos = (int)stp_adultos.Value;
        int criancas = (int)stp_criancas.Value;

        // Valida a quantidade de adultos
        if (adultos < 1)
        {
            await DisplayAlertAsync(
                "Atenção",
                "É necessário informar pelo menos um adulto.",
                "OK");
            return;
        }

        // Valida a seleção da acomodação
        if (pck_quarto.SelectedItem is not Quarto quartoSelecionado)
        {
            await DisplayAlertAsync(
                "Atenção",
                "Selecione uma acomodação.",
                "OK");
            return;
        }

        // Obtém as datas da hospedagem
        DateTime checkin = dtpck_checkin.Date ?? DateTime.Today;
        DateTime checkout = dtpck_checkout.Date ?? checkin.AddDays(1);

        // Valida o período da hospedagem
        if (checkout <= checkin)
        {
            await DisplayAlertAsync(
                "Atenção",
                "A data de check-out deve ser posterior ao check-in.",
                "OK");
            return;
        }

        // Cria o objeto Hospedagem
        Hospedagem hospedagem = new Hospedagem(
            adultos,
            criancas,
            quartoSelecionado,
            checkin,
            checkout
        );

        // Envia o objeto para a tela de confirmação
        await Navigation.PushAsync(
            new HospedagemContratada(hospedagem)
        );
    }
}
