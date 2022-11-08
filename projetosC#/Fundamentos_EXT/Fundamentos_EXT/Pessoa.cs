using System;

namespace FundamentosEXT.Properties
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        
        private string _nome;
        private int _idade;

        public String Nome
        {
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero!");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} / Idade: {Idade}");
        }

        public void Desconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
    }
}