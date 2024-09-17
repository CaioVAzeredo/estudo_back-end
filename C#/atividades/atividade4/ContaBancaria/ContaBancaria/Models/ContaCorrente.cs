namespace ContaBancaria.Models;

internal class ContaCorrente:Conta
{
    public decimal LimiteChequeEspecial { get; set; }
    public ContaCorrente(int numeroConta, string nome, int saldo, decimal limiteChequeEspecial) : base(numeroConta, nome, saldo)
    {
        LimiteChequeEspecial = limiteChequeEspecial;
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

    public void UsarChequeEspecial(decimal valor)
    {
        if (Saldo == 0)
        {
            Console.WriteLine("Usar Cheque especial");
        }
        else
        {
            Console.WriteLine("Ainda há saldo");
        }
    }


}

