using Podcast.Modelos;

Podcasts podcast1 = new("Flow Podcast", "Igor3k");
podcast1.AdicionarEpisodio(new Episodios("Conversa com Neymar", 1, 600));
podcast1.AdicionarEpisodio(new Episodios("Conversa com Gordao dos foguetes", 2, 72));
podcast1.AdicionarEpisodio(new Episodios("Conversa com Mítico", 3, 72));

podcast1.ExibirDetalhes();