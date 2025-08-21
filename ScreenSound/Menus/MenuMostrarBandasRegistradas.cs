using ScreenSound.Models;
namespace ScreenSound.Menus;
internal class MenuMostrarBandasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação:\n");
        if (bandasRegistradas.Count == 0)
        {
            Console.WriteLine("Nenhuma banda registrada.");
        }
        else
        {
            foreach (var banda in bandasRegistradas.Values)
            {
                Console.WriteLine($"Banda: {banda.Nome}");
            }
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}