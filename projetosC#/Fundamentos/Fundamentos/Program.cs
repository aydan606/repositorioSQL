using System;
using System.ComponentModel.Design;
using System.Net.Mime;
using System.Net.NetworkInformation;
using Fundamentos.models;

/*
Pessoa pessoa = new Pessoa();
pessoa.Idade = 23;
pessoa.Nome = "Aydan";
pessoa.Apresentar();
*/


/*
string saudacao = "Olá, seja bem-vindo(a)!";
int quantidade = 3;
double altura = 1.70;
decimal conta = 23.70M;
bool condicao = true;
*/


/*
Console.WriteLine(saudacao);
Console.WriteLine("Quantidade:" + quantidade);
Console.WriteLine("Altura: " + altura);
Console.WriteLine("Valor da Conta: " + conta);
Console.WriteLine("É verdade? " + condicao);
*/


/*
quantidade = 5;
Console.WriteLine("Quantidade: " + quantidade);
quantidade = 10;
Console.WriteLine("Quantidade: " + quantidade);
*/


/*
DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);
*/


/*
const int a = 10;
const int b = 20;
int c = a + b;
c += 5; // Aglutinando
Console.WriteLine(c);
*/


/*
// Conversão - Casting:
int a = Convert.ToInt32("2"); // Conversão de string para int, aceita nulos
double b = Convert.ToDouble("1.80") // Conversão de string para double, aceita nulos
int a = int.Parse("1"); // Conversão de string para int, não aceita nulos, crasha programa.
double b = double.Parse("5.99") // Conversão de string para double, não aceita nulos, crasha programa.
Console.WriteLine(a);
Console.WriteLine(b);
*/


/*
// Casting - String
int a = 5;
string b = a.ToString();
*/


/*
// Casting implícito
int a = 1;
double b = a;
Console.WriteLine(b);
int c = int.MaxValue;
long d = c;
Console.WriteLine(d);
*/


/*
// Conversão com tratamento de erros
string a = "1x";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(b);
*/


/*
// Operadores Condicionais e Operadores condicionais aninhados
int qtdCompra = 5;

int qtdEstoque = 10;

if(qtdCompra == 0)
{
    Console.WriteLine("Quantidade inválida, por favor inserir um valor válido.")
}

else if (qtdCompra <= qtdEstoque)
{
    Console.WriteLine("Compra realizada. Obrigado pela preferência!");
    qtdEstoque = qtdEstoque - qtdCompra;
    Console.WriteLine($"Quantidade restante em estoque: {qtdEstoque}");
}
else
{
    Console.WriteLine("Ops, produto sem estoque suficiente.");
}
*/


/*
// Switch/Case
Console.WriteLine("Aperte um botão...");
string a = Console.ReadLine();

switch (a)
{
    case "a":
        Console.WriteLine($"\nVogal: {a}");
        break;
    case "e":
        Console.WriteLine($"\nVogal: {a}");
        break;
    case "i":
        Console.WriteLine($"\nVogal: {a}");
        break;
    case "o":
        Console.WriteLine($"\nVogal: {a}");
        break;
    case "u":
        Console.WriteLine($"\nVogal: {a}");
        break;
    default:
        Console.WriteLine($"\nConsoante: {a}");
        break;
}
*/

/*
// Operador OR (||)
Console.WriteLine("Qual é a sua idade?");
int idade = int.Parse(Console.ReadLine());
bool autorizado = false;

if (idade >= 18 || autorizado)
{
    Console.WriteLine("Entrada autorizada.");
}
else
{
    Console.WriteLine("Entrada não autorizada.");
}
*/


/*
// Operador AND (&&)

int presencaMin = 15;
int presencaAluno = 12;
double media = 7.5;

if (presencaAluno >= presencaMin && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
*/


/*
// Operador NOT (!)
bool estaChovendo = true;
bool estaTarde = true;

if(!estaChovendo && !estaTarde)
{
    Console.WriteLine("Deixa pra outro dia");
}
else
{
    Console.WriteLine("Vou correr");
}
*/


/*
// Calculadora:
Calculadora calc = new Calculadora();
calc.Soma(10, 2);
calc.Subtracao(10, 2);
calc.Multiplicacao(10, 2);
calc.Divisao(10, 2);
calc.Modulo(10, 2);
calc.Potenciacao(10, 2);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(100);
*/


/*
// Tabuada com for
int numero = 4;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");
}
*/


/*
// Tabuada com while
int numero = 4;
int i = 0;

while (i <= 10)
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");
    i++;
}
*/


/*
// Tabuada com do/while
int i = 0;
int numero = 4;
do
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");
    i++;
}
while(i <= 10);
*/


/*
// Menu Interativo:

string aux = "0";

do
{
    Console.WriteLine("Digite a opção: \n");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar Sessão\n");
    aux = Console.ReadLine();

    switch(aux)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente: \n");
            break;
        
        case "2":
            Console.WriteLine("Busca de Cliente: \n");
            break;
        
        case "3":
            Console.WriteLine("Remoção de Cliente: \n");
            break;
        
        case "4":
            Console.WriteLine("Encerrando sessão... \n");
            break;
        
        default:
            Console.WriteLine("Opção inválida, tente novamente. \n");
            break;
    }
    
}
while (aux != "4");
*/