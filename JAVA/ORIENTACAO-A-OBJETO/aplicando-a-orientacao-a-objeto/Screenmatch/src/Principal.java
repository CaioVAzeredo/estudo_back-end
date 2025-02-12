import br.com.alura.calculos.CalculadoraDeTempo;
import br.com.alura.calculos.FiltroRecomendacao;
import br.com.alura.sreenmatch.modelos.Episodio;
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
        meuFilme.setDuracaoMinuto(5000);
        System.out.println("Duração do tempo em minutos: " + meuFilme.getDuracaoMinuto());

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

        Filme outroFilme = new Filme();
        outroFilme.setNome("Flash");
        outroFilme.setAnoLancamento(2018);
        outroFilme.setDuracaoMinuto(5000);

        /*----------------------------------------------------*/
        CalculadoraDeTempo calculadora = new CalculadoraDeTempo();
        calculadora.inclui(outroFilme);
        calculadora.inclui(lost);

        System.out.println("Tempo total: " + calculadora.getTempoTotal());

        /*-----------------------------------------------------*/

        FiltroRecomendacao filtro = new FiltroRecomendacao();

        Episodio episodio = new Episodio();
        episodio.setNumero(1);
        episodio.setSerie(lost);
        episodio.setTotalVisualizacoes(300);
        filtro.filtra(episodio);
    }
}