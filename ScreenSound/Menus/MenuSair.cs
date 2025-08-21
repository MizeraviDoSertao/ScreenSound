using ScreenSound.Models;

namespace ScreenSound.Menus;
internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Obrigado por usar o ScreenSound! Até a próxima.");
        Environment.Exit(0);
    }
}
