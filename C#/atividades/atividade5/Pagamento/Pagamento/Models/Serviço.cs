namespace Pagamento.Models;

internal class Serviço : IPagavel
{
    public int Quantidade { get; set; }
    public double Valor{ get; set; }

    public Serviço(int quantidade, double valor)
    {
        Quantidade = quantidade;
        Valor = valor;
    }

    public void CalcularPagamento()
    {
        Console.WriteLine($"Valor a ser pago: R${Quantidade * Valor} ");
    }
}
