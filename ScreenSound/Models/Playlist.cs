using System.Reflection.Metadata;
using System.Text.Json;

namespace ScreenSound.Models;

internal class Playlist
{
    public string Nome { get; set; }
    public List<Musica> Musicas;

    public Playlist(string nome)
    {
        Nome = nome;
        Musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicasPlaylist()
    {
        Console.WriteLine($"Essas são as músicas da playlist {Nome}.");

        foreach(var musica in Musicas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Cantor}");
        }
    }

    public void GerarJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = Musicas
        });
        string nomeDoArquivo = $"playlist-do-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");   
    }
}
