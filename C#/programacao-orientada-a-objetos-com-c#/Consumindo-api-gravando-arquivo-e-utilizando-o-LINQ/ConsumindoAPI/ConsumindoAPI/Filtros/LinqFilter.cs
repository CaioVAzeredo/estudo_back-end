using ConsumindoAPI.Models;

namespace ConsumindoAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"Genero - {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {

        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        System.Console.WriteLine($"Exibir os artistas por genero >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            System.Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeArtistas(List<Musica> musicas, string nomeDoArtista)
    {
        var musicaDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicaDoArtista){
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}