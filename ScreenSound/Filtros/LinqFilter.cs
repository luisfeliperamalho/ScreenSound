using ScreenSound.Models;
using System.Linq;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach ( var genero in todosOsGenerosMusicais )
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Cantor).Distinct().ToList();

        Console.WriteLine("Exibindo artistas por gênero musical.");

        foreach ( var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine(artista);
        }
    }

    public static void FiltrarMusicasDeUmCantor(List<Musica> musicas, string cantor)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Cantor!.Equals(cantor)).ToList();

        Console.WriteLine(cantor);

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();

Console.WriteLine("Musicas em C#");



    }
}
