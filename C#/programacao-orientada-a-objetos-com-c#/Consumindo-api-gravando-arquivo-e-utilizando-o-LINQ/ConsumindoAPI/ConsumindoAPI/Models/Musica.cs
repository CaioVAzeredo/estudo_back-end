using System.Text.Json.Serialization;

namespace ConsumindoAPI.Models;
internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"Artista: {Artista}\n");
        Console.WriteLine($"Musica: {Nome}\n");
        Console.WriteLine($"Duracao em segundos: {Duracao / 1000}\n");
        Console.WriteLine($"Genero: {Genero}\n");
    }
}
