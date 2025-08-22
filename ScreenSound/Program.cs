using ScreenSound. Menus;
using ScreenSound.Models;
using System.Diagnostics;

Banda mamonasAssassinas = new Banda("Mamonas Assassinas");

Banda calcinhaPreta = new Banda("Calcinha Preta");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(mamonasAssassinas.Nome, mamonasAssassinas);
bandasRegistradas.Add(calcinhaPreta.Nome, calcinhaPreta);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 1.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum de uma banda");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuDeExibicao = opcoes[opcaoEscolhidaNumerica];
        menuDeExibicao.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica != -1)
        {
            ExibirOpcoesDoMenu();
        }
    }
    else
    {
        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
        ExibirOpcoesDoMenu();
        return;
    }
    //    switch (opcaoEscolhidaNumerica)
    //{
    //    case 1:
    //        MenuRegistrarBanda menuRegistrarBanda = new MenuRegistrarBanda();
    //        menuRegistrarBanda.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 2:
    //        MenuRegistrarAlbum menuRegistrarAlbum = new MenuRegistrarAlbum();
    //        menuRegistrarAlbum.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 3:
    //        MenuMostrarBandasRegistradas menuMostrarBandasRegistradas = new MenuMostrarBandasRegistradas();
    //        menuMostrarBandasRegistradas.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 4:
    //        MenuAvaliarBanda menuAvaliarBanda = new MenuAvaliarBanda();
    //        menuAvaliarBanda.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case 5:
    //        MenuExibirDetalhes menuExibirDetalhes = new MenuExibirDetalhes();
    //        menuExibirDetalhes.Executar(bandasRegistradas);
    //        ExibirOpcoesDoMenu();
    //        break;
    //    case -1:
    //        MenuSair menuSair = new MenuSair();
    //        menuSair.Executar(bandasRegistradas);
    //        break;
    //    default:
    //        Console.WriteLine("Opção inválida");
    //        break;
    //}
}
ExibirOpcoesDoMenu();
