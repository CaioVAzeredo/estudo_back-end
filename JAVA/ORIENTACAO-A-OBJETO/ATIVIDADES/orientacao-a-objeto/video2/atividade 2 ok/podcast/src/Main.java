public class Main {
    public static void main(String[] args) {
        Podcast podcast1 = new Podcast("Igor", "FlowPodcast");
        Episodio Neymar = new Episodio(1500, 1, "O maior jogador dessa época", "Entrevista com neymar");
        Neymar.adicionarConvidados("Neymar");
        podcast1.adicionarEpisodio(Neymar);

        Episodio GordaoDosFoguetes = new Episodio(4100, 2, "O maior cientista do Brasil", "Entrevista com Sergio Sacani");
        GordaoDosFoguetes.adicionarConvidados("Sergio Sacani");
        podcast1.adicionarEpisodio(GordaoDosFoguetes);

        Episodio Mitico = new Episodio(2000, 3, "O maior Hoster do Brasil", "Entrevista com Mitico do podpah");
        Mitico.adicionarConvidados("Mitico");
        podcast1.adicionarEpisodio(Mitico);

        podcast1.exibirDetalhes();
    }
}