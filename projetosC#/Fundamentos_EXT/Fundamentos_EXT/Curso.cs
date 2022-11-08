using System;
using System.Collections.Generic;

namespace FundamentosEXT.Properties.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QtdAlunosMatriculados()
        {
            int qtd = Alunos.Count;
            return qtd;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");
            for (int i = 0; i < Alunos.Count; i++)
            {
                string j = $"Nº {i+1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(j);
            }
        }
    }
}