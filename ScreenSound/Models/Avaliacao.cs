namespace ScreenSound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }
    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is not Avaliacao other) return false;
        return Nota.Equals(other.Nota);
    }

    public override int GetHashCode()
    {
        return Nota.GetHashCode();
    }

    public override string ToString()
    {
        return Nota.ToString();
    }
}