using ConsumindoAPI.Models;

namespace ConsumindoAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistaOrdenados = musicas
        .OrderBy(musica => musica.Artista)
        .Select(musica => musica.Artista)
        .Distinct()
        .ToList();
        
        Console.WriteLine("Lista de artistas ordenados");
        foreach(var artista in artistaOrdenados){
            System.Console.WriteLine($"- {artista}");
        }
    }
}