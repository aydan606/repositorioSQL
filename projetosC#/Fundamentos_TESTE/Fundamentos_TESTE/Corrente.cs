namespace Fundamentos_TESTE;

public class Corrente: Conta
{
    public override void Creditar(decimal valor)
    {
        Saldo += valor;
    }
}