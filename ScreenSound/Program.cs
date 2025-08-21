using ScreenSound.Menus;
using ScreenSound.Models;

Banda mamonasAssassinas = new Banda("Mamonas Assassinas");
mamonasAssassinas.AdicionarNota(new Avaliacao(10));
mamonasAssassinas.AdicionarNota(new Avaliacao(9));
mamonasAssassinas.AdicionarNota(new Avaliacao(7));

Banda calcinhaPreta = new Banda("Calcinha Preta");
calcinhaPreta.AdicionarNota(new Avaliacao(10));
calcinhaPreta.AdicionarNota(new Avaliacao(10));
calcinhaPreta.AdicionarNota(new Avaliacao(8));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(mamonasAssassinas.Nome, mamonasAssassinas);
bandasRegistradas.Add(calcinhaPreta.Nome, calcinhaPreta);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
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
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
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
