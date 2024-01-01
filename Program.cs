using ScreenSoundAPI.Modelos;
using System.Text.Json;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try 
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; //Indica que musicas nao pode ser nulo.
        // musicas[10].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
    }
    catch(Exception e)
    {
        Console.WriteLine($"Ocorreu um erro inesperado: {e.Message}");
    }
}

