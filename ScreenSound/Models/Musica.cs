using System.Text.Json.Serialization;

namespace ScreenSound.Models;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    public Banda? Artista { get; set; }
    [JsonPropertyName("artist")]
    public string? Cantor { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    [JsonPropertyName("genre")]
    public string Genero { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista!.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Cantor}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"**********************");
    }
}