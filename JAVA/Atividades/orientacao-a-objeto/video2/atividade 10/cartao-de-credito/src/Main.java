import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IllegalAccessException {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Coloque um limite para o cartão: ");
        double limite = Double.parseDouble(scanner.nextLine());

        List<Produto> produtos = new ArrayList<>();

        while (true) {
            System.out.println("Insira o produto:");
            String produto = scanner.nextLine();

            System.out.println("Insira o preço:");
            double preco = Double.parseDouble(scanner.nextLine());
            produtos.add(new Produto(produto, preco));

            System.out.println("Deseja continuar? 1- Continuar. 0- Sair");
            int saida = Integer.parseInt(scanner.nextLine());
            if (saida == 1) {
                continue;
            } else if (saida == 0) {
                Compra compra = new Compra(limite, produtos);
                compra.descricao();
                break;
            } else {
                System.out.println("Insira um valor válido!!");
            }
        }

    }
}