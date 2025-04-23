public class ContaCorrente extends Conta {
    private double LimiteChequeEspecial;

    public ContaCorrente(int numero, String titular, double saldo, double limiteChequeEspecial) {
        super(numero, titular, saldo);

        LimiteChequeEspecial = limiteChequeEspecial;
    }

    public double getLimiteChequeEspecial() {
        return LimiteChequeEspecial;
    }

    public void setLimiteChequeEspecial(double limiteChequeEspecial) {
        LimiteChequeEspecial = limiteChequeEspecial;
    }

    @Override
    public void calculoSaldo() {
        super.calculoSaldo();
    }
}
