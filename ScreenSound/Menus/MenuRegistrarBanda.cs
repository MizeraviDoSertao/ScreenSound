using ScreenSound.Models;

namespace ScreenSound.Menus;
internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registrar Banda");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.WriteLine($"A banda '{nomeBanda}' já está registrada.");
        }
        else
        {
            Banda novaBanda = new Banda(nomeBanda);
            bandasRegistradas.Add(nomeBanda, novaBanda);
            Console.WriteLine($"Banda '{nomeBanda}' registrada com sucesso!");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}
