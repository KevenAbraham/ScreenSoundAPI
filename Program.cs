using ScreenSoundAPI.Modelos;
using System.Text.Json;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try 
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; //Indica que musicas nao pode ser nulo.

        LinqFilter.FiltrarMusicasEmCsharp(musicas);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Ocorreu um erro inesperado: {e.Message}");
    }
}

