using System.Text.Json;
using Filmes.Models;

using(HttpClient client = new HttpClient()){
    string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

    var filmes = JsonSerializer.Deserialize<List<Filmes>>(resposta)!;
}