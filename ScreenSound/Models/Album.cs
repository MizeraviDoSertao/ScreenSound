namespace ScreenSound.Models;
class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Album(string nome)
    {
        Nome = nome;
        ContadorDeAlbum++;
    }

    public string Nome { get; }
    public static int ContadorDeAlbum = 0;
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public IEnumerable<Musica> Musicas => musicas;

    public double NotaMedia
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return Math.Round(notas.Average(n => n.Nota), 2);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

    public void AdicionarNota(Avaliacao nota1)
    {
        notas.Add(nota1);
    }
}