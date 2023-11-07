using ScreenSound.Menus;
using ScreenSound.Models;
using System.Text.Json;
using ScreenSound.Filtros;

internal class MenuExibirMusicasVariadas : Menu
{
   
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        HttpClient client = new();

        try
        {
            string resposta = client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json").GetAwaiter().GetResult();
            var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
            musicas[0].ExibirDetalhesDaMusica();

            //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
            LinqOrder.ExibirListaDeCantoresOrdenados(musicas);
            //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
            LinqFilter.FiltrarMusicasDeUmCantor(musicas, "Eminem");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Temos um problema: {ex.Message}");
        }
    }
}