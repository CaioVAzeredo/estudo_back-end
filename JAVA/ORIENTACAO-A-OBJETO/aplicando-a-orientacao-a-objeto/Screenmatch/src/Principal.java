import br.com.alura.sreenmatch.modelos.Filme;
import br.com.alura.sreenmatch.modelos.Serie;

public class Principal {
    public static void main(String[] args) {
        Filme meuFilme = new Filme();


        meuFilme.setNome("O poderoso chefão");
        meuFilme.avalia(5);
        meuFilme.avalia(3);
        meuFilme.avalia(4);
        meuFilme.exibeFichatecnica();

        System.out.println("Duração do filme: " + meuFilme.getDuracaoMinuto());
        System.out.println("Total de avaliações: " + meuFilme.getTotalAvaliacao());

        /*---------------------------------------------------*/
        Serie lost = new Serie();
        lost.setNome("Lost");
        lost.setAnoLancamento(2000);
        lost.exibeFichatecnica();
        lost.setTemporadas(10);
        lost.setEpisodiosPorTemporada(10);
        lost.setMinutosPorEpisodio(45);
        System.out.println("Duração para maratonar LOST: " + lost.getDuracaoMinuto());


    }
}