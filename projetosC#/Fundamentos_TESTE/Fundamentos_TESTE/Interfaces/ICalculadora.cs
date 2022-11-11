namespace Fundamentos_TESTE.Interfaces;

public interface ICalculadora
{
    public int Soma(int x, int y);
    public int Subtracao(int x, int y);
    public int Multiplicacao(int x, int y);

    public int Divisao(int x, int y)
    {
        return x / y;
    }
}