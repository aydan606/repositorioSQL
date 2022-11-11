using Fundamentos_TESTE;
using Fundamentos_TESTE.Interfaces;

/*
Corrente conta1 = new Corrente();
conta1.Creditar(500);
conta1.ExibirSaldo();
*/


/*
Pessoa p1 = new Pessoa("Aydan");
Aluno a1 = new Aluno("Carlos");
a1.Apresentar();
Professor pr1 = new Professor("Paulo");
*/

ICalculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Soma(10, 5));