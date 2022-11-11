namespace Fundamentos_TESTE;

public class Diretor : Professor
{
    public Diretor(string nome) : base(nome)
    {
        
    }
    
    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
    }
    
}