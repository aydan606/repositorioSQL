namespace Fundamentos_TESTE;

public class Aluno: Pessoa
{
    public double Nota { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
    }

    public Aluno(string nome) : base(nome)
    {
        
    }
}