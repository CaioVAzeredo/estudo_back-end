public abstract class Conta implements ICalculosConta {
    private int Numero;
    private String Titular;
    private double Saldo;

    public Conta(int numero, String titular, double saldo) {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }

    public int getNumero() {
        return Numero;
    }

    public void setNumero(int numero) {
        Numero = numero;
    }

    public String getTitular() {
        return Titular;
    }

    public void setTitular(String titular) {
        Titular = titular;
    }

    public double getSaldo() {
        return Saldo;
    }

    public void setSaldo(double saldo) {
        Saldo = saldo;
    }

    @Override
    public void calculoSaldo() {
        System.out.println("Saldo atual da conta: " + this.getSaldo());
    }
}
