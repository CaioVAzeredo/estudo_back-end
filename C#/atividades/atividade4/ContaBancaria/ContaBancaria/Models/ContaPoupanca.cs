namespace ContaBancaria.Models;

internal class ContaPoupanca : Conta
{
    public decimal TaxaDeJuros { get; set; }

    public ContaPoupanca(int numeroConta, string nome, int saldo, decimal taxaDeJuros) : base(numeroConta, nome, saldo)
    {
        TaxaDeJuros = taxaDeJuros;
    }

    public override void Depositar(decimal valor)
    {
        base.Depositar(valor);
    }

    public override void Sacar(decimal valor)
    {
        base.Sacar(valor);
    }
    public override void ExibirInfo()
    {
        base.ExibirInfo();
    }
    public void AplicarJuros()
    {
        TaxaDeJuros = TaxaDeJuros + 0.01m;
    }

}
