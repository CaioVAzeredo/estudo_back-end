public class ContaCorrente
{
    public Int32 Agencia { get; set; }
    public string Conta { get; set; }
    public double Saldo { get; set; }


    public ContaCorrente(Int32 agencia, string conta, double saldo)
    {
        Agencia = agencia;
        Conta = conta;
        Saldo = saldo;
    }

}