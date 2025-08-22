using ScreenSound.Models;
using System.Linq;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        if (bandasRegistradas.Count == 0)
        {
            Console.WriteLine("Nenhuma banda registrada. Por favor, registre uma banda primeiro.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        ExibirTituloDaOpcao("Avaliar Álbum");
        Console.Write("Digite o nome da banda que deseja avaliar o álbum: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            if (!banda.Albuns.Any())
            {
                Console.WriteLine("Nenhum álbum foi registrado para essa banda! \n Por favor, registre esse álbum primeiro!!!");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.Write($"Digite o nome do álbum que deseja avaliar: ");
            string nomeAlbum = Console.ReadLine()!;

          
            //if (!banda.Albuns.Exists(album => album.Nome.Equals(nomeAlbum, StringComparison.OrdinalIgnoreCase)))
            if (!banda.Albuns.Any(a => a.Nome.Equals(nomeAlbum, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Álbum '{nomeAlbum}' não encontrado na discografia da banda '{banda.Nome}'.");
                Console.WriteLine("Por favor, registre o álbum primeiro.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else
            {
                Album album = banda.Albuns.First(album => album.Nome.Equals(nomeAlbum, StringComparison.OrdinalIgnoreCase));
                Console.Write($"Qual a nota que o álbum {nomeAlbum} merece: \n Avalie de 0 a 10!!! ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!); 
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {nomeAlbum}");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
