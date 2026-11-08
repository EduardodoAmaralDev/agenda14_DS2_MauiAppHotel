
namespace MauiAppHotel.Models;

public class Hospedagem
{
    // Dados da hospedagem
    public int Adultos { get; set; }
    public int Criancas { get; set; }
    public Quarto QuartoSelecionado { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    // Calcula automaticamente a quantidade de diárias
    public int Diarias
    {
        get { return (CheckOut - CheckIn).Days; }
    }

    // Calcula automaticamente o valor total
    public decimal ValorTotal
    {
        get { return Diarias * QuartoSelecionado.ValorDiaria; }
    }

    // Construtor
    public Hospedagem(
        int adultos,
        int criancas,
        Quarto quartoSelecionado,
        DateTime checkIn,
        DateTime checkOut)
    {
        if (adultos < 1)
            throw new ArgumentException("É necessário informar pelo menos um adulto.");

        if (criancas < 0)
            throw new ArgumentException("A quantidade de crianças não pode ser negativa.");

        if (quartoSelecionado == null)
            throw new ArgumentException("É necessário selecionar um quarto.");

        if (checkOut <= checkIn)
            throw new ArgumentException("O check-out deve ser posterior ao check-in.");

        Adultos = adultos;
        Criancas = criancas;
        QuartoSelecionado = quartoSelecionado;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }
}
