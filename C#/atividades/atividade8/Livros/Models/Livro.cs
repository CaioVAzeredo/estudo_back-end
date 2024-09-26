using System.Text.Json.Serialization;

namespace Livros.Models;

internal class Livro{
[JsonPropertyName("titulo")]
public string? Titulo { get; set; }
[JsonPropertyName("ano_publicacao")]
public int? Ano_publicacao { get; set; }


}