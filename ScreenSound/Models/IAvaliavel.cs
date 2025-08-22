namespace ScreenSound.Models;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao avaliacao);
    double NotaMedia { get; }
}
