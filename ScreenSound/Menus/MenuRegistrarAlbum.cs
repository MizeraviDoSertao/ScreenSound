using ScreenSound.Models;
namespace ScreenSound.Menus;
internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registrar Álbum de uma Banda");
        if (bandasRegistradas.Count == 0)
        {
            Console.WriteLine("Nenhuma banda registrada. Por favor, registre uma banda primeiro.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        Console.WriteLine("Digite a banda cujo álbum deseja registrar:");
        string nomeBanda = Console.ReadLine()!;
        if (!bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.WriteLine($"Banda '{nomeBanda}' não encontrada. Por favor, registre a banda primeiro.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        Banda banda = bandasRegistradas[nomeBanda];
        Console.WriteLine("Digite o nome do álbum:");
        string nomeAlbum = Console.ReadLine()!;
        if (banda.Albuns.Any(a => a.Nome.Equals(nomeAlbum, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"Álbum '{nomeAlbum}' já registrado para a banda '{banda.Nome}'.\n Por favor adicione outro álbum");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        //if (banda.Albuns.Exists(album => album.Nome.Equals(nomeAlbum, StringComparison.OrdinalIgnoreCase)))
        //{
        //    Console.WriteLine($"Álbum '{nomeAlbum}' já registrado para a banda '{banda.Nome}'.");
        //    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        //    Console.ReadKey();
        //    Console.Clear();
        //    return;
        //}
        Album novoAlbum = new Album(nomeAlbum);
        banda.AdicionarAlbum(novoAlbum);
        Console.WriteLine($"Álbum '{nomeAlbum}' registrado com sucesso para a banda '{banda.Nome}'!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}
