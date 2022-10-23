using System;

namespace Fundamentos.models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }

}