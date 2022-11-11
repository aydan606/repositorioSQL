using Fundamentos_TESTE.Interfaces;

namespace Fundamentos_TESTE;

public class Calculadora : ICalculadora
{

    public int Soma(int x, int y)
    {
        return x + y;
    }

    public int Subtracao(int x, int y)
    {
        return x - y;
    }

    public int Multiplicacao(int x, int y)
    {
        return x * y;
    }
}