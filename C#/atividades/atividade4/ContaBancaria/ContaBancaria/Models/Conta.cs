namespace ContaBancaria.Models;

internal class Conta
{
    public int NumeroConta { get; set; }
    public string Nome { get; set; }
    public decimal Saldo { get; set; }

    public Conta(int numeroConta, string nome, int saldo)
    {
        NumeroConta = numeroConta;
        Nome = nome;
        Saldo = saldo;
    }

    public virtual void Depositar(decimal valor)
    {
        Console.WriteLine("Depósito na conta corrente: ");
        Saldo += valor;
        Console.WriteLine($"Saldo atual: {Saldo}R$");
    }
    public virtual void Sacar(decimal valor)
    {
        Console.WriteLine("Saque na conta corrente: ");
        Saldo -= valor;
        Console.WriteLine($"Saldo atual: {Saldo}R$");
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, tem {Saldo}R$ na conta");
    }
}
