using System.Text.Json.Serialization;

namespace Filmes.Models;

internal class Musica{
    [JsonPropertyName("rank")]
    public string Ranque { get; set; }
    [JsonPropertyName("title")]
    public string Titulo { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }
    

    public void ExibirInfo(){
        Console.WriteLine($"Ranque: {Ranque} - Titulo: {Titulo}, Ano: {Ano}");
    }

}