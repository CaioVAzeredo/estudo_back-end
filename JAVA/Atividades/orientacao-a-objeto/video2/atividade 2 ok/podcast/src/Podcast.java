import java.util.ArrayList;
import java.util.List;

public class Podcast {
    private String Host;
    private String Nome;
    private List<Episodio> episodios;

    public Podcast(String host, String nome) {
        Host = host;
        Nome = nome;
        episodios = new ArrayList<>();
    }

    public String getHost() {
        return Host;
    }

    public void setHost(String host) {
        Host = host;
    }

    public String getNome() {
        return Nome;
    }

    public void setNome(String nome) {
        Nome = nome;
    }

    public float getTotalTempo() {
        return (float) episodios.stream().mapToDouble(Episodio::getDuracao).sum(); //
    }

    public int getTotalEpisodio() {
        return episodios.size();
    }


    public void adicionarEpisodio(Episodio NovoEp) {
        this.episodios.add(NovoEp);
    }

    public void exibirDetalhes() {
        System.out.println("Podcast: " + Nome + ", Apresentador: " + Host + "Total de episódios: " + getTotalEpisodio() + ". Duração: " + getTotalTempo());
        for (Episodio episodio : episodios) { //forEach diferente com JAVA
            System.out.println(
                    "Titulo: " + episodio.getTitulo() +
                            ". ( Entrevistado: " + String.join(", ", episodio.getConvidado()) +
                            ", Duração: " + episodio.getDuracao() + " min(s)) \n"
            );
        }

    }
}
