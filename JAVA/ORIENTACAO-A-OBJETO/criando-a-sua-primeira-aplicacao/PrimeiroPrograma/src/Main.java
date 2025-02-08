import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws InterruptedException {
        String nome = "Caio Viana";
        String tipoConta = "Corrente";
        double saldo = 5200;

        Scanner leitura = new Scanner(System.in);

        while (true) {
            System.out.println("######################\n" +
                    "Informações da conta:" + "\n" +
                    "Nome: " + nome + "\n" +
                    "Tipo da conta: " + tipoConta + "\n" +
                    "Saldo da conta: " + saldo + "\n" +
                    "\n######################\n");
            System.out.println(
                    "1 - Consultar saldo\n" +
                            "2 - Receber valor\n" +
                            "3 - Transferir valor\n" +
                            "4 - Sair\n");

            int resposta = leitura.nextInt();

            switch (resposta) {
                case 1:
                    System.out.println("Valor do saldo: " + saldo);
                    System.out.println("Se desejar sair, aperte 1");
                    int saida = leitura.nextInt();
                    if (saida != 1) {
                        System.out.println("Valor inválido");
                        break;
                    } else {
                        break;
                    }

                case 2:
                    System.out.println("Informe o valor para adicionar à conta: ");
                    double leituraSaldo = leitura.nextDouble();
                    saldo += leituraSaldo;
                    System.out.println("Novo valor atualizado, seu saldo é de: " + saldo);
                    System.out.println("Se desejar sair, aperte 1");
                    int saidaReceber = leitura.nextInt();
                    if (saidaReceber != 1) {
                        System.out.println("Valor inválido");
                        break;
                    } else {
                        break;
                    }
                case 3:
                    System.out.println("Informe o valor para transferir da conta: ");
                    double leituraTranferencia = leitura.nextDouble();
                    if (leituraTranferencia > saldo) {
                        System.out.println("Saldo insuficiente!!");
                        Thread.sleep(2000);
                        break;
                    }
                    saldo -= leituraTranferencia;
                    System.out.println("Novo valor atualizado, seu saldo é de: " + saldo);
                    System.out.println("Se desejar sair, aperte 1");
                    int saidaTranferencia = leitura.nextInt();
                    if (saidaTranferencia != 1) {
                        System.out.println("Valor inválido");
                        break;
                    } else {
                        break;
                    }
                default:
                    System.out.println("Valor inválido");

            }

            if (resposta == 4) {
                System.out.println("Finalizado o sistema!!");
                break;
            }
        }
    }
}