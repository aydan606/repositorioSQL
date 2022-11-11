﻿namespace Fundamentos_TESTE;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
    }
}