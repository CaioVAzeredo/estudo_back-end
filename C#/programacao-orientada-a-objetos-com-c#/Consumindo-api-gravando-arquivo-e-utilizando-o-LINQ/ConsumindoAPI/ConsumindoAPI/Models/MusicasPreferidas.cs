namespace ConsumindoAPI.Models;
class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }


    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new();
    }

    public void AdicionarMusica(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void MostrarMusicasFavoritas()
    {
        Console.WriteLine($"Musicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- musica: {musica.Nome} do Artista: {musica.Artista}");
        }
    }
}
