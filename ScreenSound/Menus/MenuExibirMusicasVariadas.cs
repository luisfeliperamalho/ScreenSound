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
            //musicas[0].ExibirDetalhesDaMusica();

            LinqFilter.FiltrarMusicasEmCSharp(musicas);

            //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
            //LinqOrder.ExibirListaDeCantoresOrdenados(musicas);
            //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
            //LinqFilter.FiltrarMusicasDeUmCantor(musicas, "Eminem");

            var playlistDoFelipe = new Playlist("Playlist do Felipe");
            playlistDoFelipe.AdicionarMusica(musicas[1]);
            playlistDoFelipe.AdicionarMusica(musicas[132]);
            playlistDoFelipe.AdicionarMusica(musicas[143]);
            playlistDoFelipe.AdicionarMusica(musicas[451]);
            playlistDoFelipe.AdicionarMusica(musicas[1100]);
            playlistDoFelipe.AdicionarMusica(musicas[879]);


            //var playlistDoLuis = new Playlist("Playlist do Luis");
            //playlistDoLuis.AdicionarMusica(musicas[132]);
            //playlistDoLuis.AdicionarMusica(musicas[14546]);
            //playlistDoLuis.AdicionarMusica(musicas[786]);
            //playlistDoLuis.AdicionarMusica(musicas[1230]);
            //playlistDoLuis.AdicionarMusica(musicas[990]);


            playlistDoFelipe.ExibirMusicasPlaylist();
            //playlistDoLuis.ExibirMusicasPlaylist();


            playlistDoFelipe.GerarJson();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Temos um problema: {ex.Message}");
        }
    }
}