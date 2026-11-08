
namespace MauiAppHotel.Models;

public class Quarto
{
    // Campos privados
    private string _descricao = string.Empty;
    private decimal _valorDiaria;

    // Propriedade: descrição da acomodação
    public string Descricao
    {
        get { return _descricao; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A descrição do quarto é obrigatória.");

            _descricao = value;
        }
    }

    // Propriedade: valor da diária
    public decimal ValorDiaria
    {
        get { return _valorDiaria; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("O valor da diária deve ser maior que zero.");

            _valorDiaria = value;
        }
    }

    // Construtor
    public Quarto(string descricao, decimal valorDiaria)
    {
        Descricao = descricao;
        ValorDiaria = valorDiaria;
    }
}
