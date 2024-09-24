namespace Pagamento.Models;

internal class Produto : IPagavel
{
    public int Quantidade { get; set; }
    public double Valor { get; set; }

    public Produto(int quantidade, double valor)
    {
        Quantidade = quantidade;
        Valor = valor;
    }
    public void CalcularPagamento()
    {
        Console.WriteLine($"Valor a ser pago: R${Quantidade * Valor} ");
    }
}