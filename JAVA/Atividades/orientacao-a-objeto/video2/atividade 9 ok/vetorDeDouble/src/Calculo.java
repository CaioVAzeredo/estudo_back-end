
public class Calculo {

    public void mediaSimples(int[] valores) {
        float soma = 0;
        for (int valor : valores) {
            soma += valor;
        }
        System.out.println("A média é de: " + soma / valores.length);

    }
}
