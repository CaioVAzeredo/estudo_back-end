import java.util.Comparator;
import java.util.List;

public class Compra {
    private double limite;
    private List<Produto> produtos;

    public Compra(double limite, List<Produto> produtos) throws IllegalAccessException {
        if (limite < 0) {
            throw new IllegalAccessException("Limite nao pode ser negativo");
        } else if (produtos == null) {
            throw new IllegalAccessException("Lista de produtos nao pode ser nula");
        } else {
            this.limite = limite;
        }
        this.produtos = produtos;
    }

    public double getLimite() {
        return limite;
    }

    public void setLimite(double limite) {
        this.limite = limite;
    }

    public List<Produto> getProduto() {
        return produtos;
    }

    public void setProduto(List<Produto> produto) {
        this.produtos = produto;
    }

    public boolean verificaLimite() {
        double somaPreco = 0;
        for (Produto produto : produtos) {
            somaPreco += produto.getPreco();
        }
        if (limite < somaPreco) {
            return true;
        } else {
            return false;
        }
    }

    public void descricao() {
        boolean verifica = verificaLimite();

        if (verifica) {
            System.out.println("Limite indisponível");
        } else {
            System.out.println("COMPRAS REALIZADAS: \n");
            produtos.sort(Comparator.comparingDouble(Produto::getPreco));
            for (Produto produto : produtos) {
                System.out.println("Produto: " + produto.getNome() + "- preco: " + produto.getPreco());
            }
        }
    }

}
