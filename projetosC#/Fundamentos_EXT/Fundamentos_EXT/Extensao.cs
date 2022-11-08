namespace Fundamentos_EXT;

public static class Extensao
{
    public static bool IsEven(this int numero)
    {
        return numero % 2 == 0;
    }
}