using System.Text.Json;
using Pais.Pais;

using (HttpClient client = new HttpClient()){
    string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
    var pais = JsonSerializer.Deserialize<List<Pais>>(resposta)!;
    pais[0].ExibirInfo();
}