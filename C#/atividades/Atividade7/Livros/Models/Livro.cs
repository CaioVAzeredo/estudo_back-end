using System.Text.Json.Serialization;

namespace Livros.livro;

class Livro
{

    [JsonPropertyName("titulo")]
    public required string Titulo { get; set; }
    [JsonPropertyName("autor")]
    public required string Autor { get; set; }
    [JsonPropertyName("genero")]
    public required string Genero { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"Livro: {Titulo} - Autor: {Autor} - Genero: {Genero}");
    }

}
