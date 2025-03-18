public class Main {
    public static void main(String[] args) {
        ContaCorrente minhaConta = new ContaCorrente(123456, "Caio", 5000, 1000);
        minhaConta.calculoSaldo();
        ContaPoupanca minhaSegundaConta = new ContaPoupanca(125486, "Felipe", 10000, 2);
        minhaSegundaConta.calculoSaldo();
    }
}