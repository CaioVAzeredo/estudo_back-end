using ConsumindoAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        /*Objeto*/var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirInfo();
    }
    catch (Exception error)
    {
        Console.WriteLine($"Temos um problema: {error}");
    }
}