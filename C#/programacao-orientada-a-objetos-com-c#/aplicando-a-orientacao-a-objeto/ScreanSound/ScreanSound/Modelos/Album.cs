class Album
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
        Nome = nome;
    }


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"musica: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este album inteiro você precisa de {DuracaoTotal} segundos");
    }
}