namespace Fundamentos_TESTE;

public abstract class Conta
{
    protected decimal Saldo;

    public void ExibirSaldo()
    {
        Console.WriteLine($"O seu saldo é de {Saldo}");
    }

    public abstract void Creditar(decimal valor);
}