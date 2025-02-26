public class ContaPoupanca extends Conta{
    private double TaxaRendimento;

    public ContaPoupanca(int numero, String titular, double saldo, double taxaRendimento) {
        super(numero, titular, saldo);
        TaxaRendimento = taxaRendimento;
    }

    public double getTaxaRendimento() {
        return TaxaRendimento;
    }

    public void setTaxaRendimento(double taxaRendimento) {
        TaxaRendimento = taxaRendimento;
    }

    @Override
    public void calculoSaldo() {
        super.calculoSaldo();
    }
}
