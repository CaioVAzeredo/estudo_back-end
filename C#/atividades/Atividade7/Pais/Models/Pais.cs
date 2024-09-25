using System.Text.Json.Serialization;

namespace Pais.Pais;

public class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("populacao")]
    public double Populacao { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"Pais: {Nome}, Capital: {Capital},  População: {Populacao}");

    }
}