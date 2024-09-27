namespace ConsumindoAPI.Models;
using System.Text.Json;
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

    public void GerarArquivoJson()
    {
        //Objeto anônimo. Onde nao tem o tipo 
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas - {Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso!! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
