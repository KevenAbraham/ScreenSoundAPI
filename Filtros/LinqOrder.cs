using System.Linq;
using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artsitaOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList(); //ordenando pela propriedade artista
        Console.WriteLine("Lista de Artistas Ordenados:");
        foreach(var artista in artsitaOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}