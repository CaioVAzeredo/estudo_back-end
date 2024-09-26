using System.Text.Json;
using Livros.Filtros;
using Livros.Models;

using (HttpClient client = new HttpClient()){
    string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");

    var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
    LinqFiltros.FiltrarLivros(livros);

}