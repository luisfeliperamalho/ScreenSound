using ScreenSound.Models;
using System.Linq;

namespace ScreenSound.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeCantoresOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Cantor).Select(musica => musica.Cantor).Distinct().ToList();

        Console.WriteLine("Lista de Cantores");
        foreach (var artist in artistasOrdenados)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
