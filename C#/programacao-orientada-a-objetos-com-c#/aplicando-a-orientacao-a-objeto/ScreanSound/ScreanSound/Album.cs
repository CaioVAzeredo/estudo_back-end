﻿class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

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