using ConsumindoAPI.Filtros;
using ConsumindoAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{   
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        /*Objeto*/
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeArtistas(musicas, "Michel Teló");

        //MusicasPreferidas playlistFelipe = new("Felipe");
        //playlistFelipe.AdicionarMusica(musicas[2]);
        //playlistFelipe.AdicionarMusica(musicas[378]);
        //playlistFelipe.AdicionarMusica(musicas[5]);
        //playlistFelipe.AdicionarMusica(musicas[7]);
        //playlistFelipe.AdicionarMusica(musicas[1468]);

        //playlistFelipe.MostrarMusicasFavoritas();

        MusicasPreferidas playlisCaio = new("Caio");
        playlisCaio.AdicionarMusica(musicas[1]);
        playlisCaio.AdicionarMusica(musicas[377]);
        playlisCaio.AdicionarMusica(musicas[4]);
        playlisCaio.AdicionarMusica(musicas[6]);
        playlisCaio.AdicionarMusica(musicas[1467]);

        playlisCaio.MostrarMusicasFavoritas();

        playlisCaio.GerarArquivoJson();



    }
    catch (Exception error)
    {
        Console.WriteLine($"Temos um problema: {error}");
    }
}