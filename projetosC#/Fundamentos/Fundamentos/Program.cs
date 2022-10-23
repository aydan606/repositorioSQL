using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Management.Instrumentation;
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


/*
// Arrays com for e foreach
int[] array = new int[3];

array[0] = 72;
array[1] = 4;
array[2] = -21;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{i + 1}º número do array = {array[i]}");
}

Console.WriteLine("\n");

int aux = 0;
foreach (int x in array)
{
    Console.WriteLine($"{aux + 1}º número do array = {x}");
    aux++;
}

// Redimensionando arrays

Array.Resize(ref array, array.Length * 3);

// Copiando arrays

int[] arrayTriplicado = new int[array.Length * 3];
Array.Copy(array, arrayTriplicado, array.Length);
*/


/*
// Trabalhando com listas usando for e foreach:
List<string> listaStrings = new List<string>();

listaStrings.Add("BA");
listaStrings.Add("PE");
listaStrings.Add("RN");

for (int i = 0; i < listaStrings.Count; i++)
{
    Console.WriteLine($"{listaStrings[i]}");
}

int aux = 0;
foreach (string j in listaStrings)
{
    Console.WriteLine($"{j}");
    aux++;
}
*/


/*
void calculo(int x, int y, int z)
{
    Console.WriteLine($"Produto: {x} * {y} * {z} = {x*y*z}");
    Console.WriteLine($"Soma: {x} + {y} + {z} = {x+y+z}");
    Console.WriteLine($"Diferença do produto com a soma: {(x*y*z)-(x+y+z)}");
}

Console.WriteLine("Insira os 3 números para o cálculo: \n");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

calculo(a, b, c);
*/


/*
// Diferença entre o produto e a soma de todos os dígitos de um número inteiro:
string a = Console.ReadLine();
char[] array;

array = a.ToCharArray(0, a.Length);
int[] arrINT = array.Select(j => j - '0').ToArray();
int aux1 = 1;
int aux2 = 0;

for (int i = 0; i < array.Length; i++)
{
    aux1 *= arrINT[i];
    aux2 += arrINT[i];
}

Console.WriteLine($"O resultado esperado é de {aux1 - aux2}");
*/


/*
long a = Convert.ToInt64(Console.ReadLine());
long b = Convert.ToInt64(Console.ReadLine());

if (a % 10 == b % 10 && (a/10)%10 == (b/10)%10)
{
    Console.WriteLine("encaixa");
}
else
{
    Console.WriteLine("nao encaixa");
}
*/

/*
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
        
int c = a%10;
int d = b%10;
int e = Convert.ToInt32(Math.Floor((decimal)(a/10))%10);
int f = Convert.ToInt32(Math.Floor((decimal)(a/10))%10);

if (c == d && e == f) 
{
    Console.WriteLine("encaixa");
}
    else
    {
    Console.WriteLine("nao encaixa");
    }
*/


/*
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
 
for (int i = 1; i <= n; i++) {
    if (n % i == 0) {
        count++;
    }
    if (count > 3) {
        break;
    }
}
Console.WriteLine(count == 3);
*/