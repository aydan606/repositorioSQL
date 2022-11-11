namespace Fundamentos_TESTE;

public class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    {
        
    }
    
    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
    }

    public decimal Salario { get; set; }
}