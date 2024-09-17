namespace Podcast.Modelos;

internal class Podcasts
{
    public string  Host { get; set; }
    public string Nome { get; set; }
    public float TotalDeEpisodios => episodios.Sum(a => a.Duracao);
    private  List<Episodios> episodios = new List<Episodios>();

    public Podcasts(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodios episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}, Apresentador: {Host}. Duração {TotalDeEpisodios}");
        foreach (var episodio in episodios)
        {
            Console.WriteLine($" - {episodio.Titulo} (Ordem: {episodio.Ordem}, Duração: {episodio.Duracao} minutos)");
        }
    }

   
}