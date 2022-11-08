using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Principal;
using Fundamentos_EXT;
using FundamentosEXT;
using FundamentosEXT.Properties;
using FundamentosEXT.Properties.models;
using Newtonsoft.Json;

/*
Pessoa p1 = new Pessoa("Aydan", "Barreto", 23);
Pessoa p2 = new Pessoa("Maria", "Júlia", 21);

Curso CursoIngles = new Curso();
CursoIngles.Nome = "Inglês";
CursoIngles.Alunos = new List<Pessoa>();
        
CursoIngles.AdicionarAluno(p1);
CursoIngles.AdicionarAluno(p2);
CursoIngles.ListarAlunos();
*/


/*
// Definição de moedas específicas:
decimal valor = 1582.40M;
Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
*/


/*
// Porcentagem de números:
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));
*/


/*
//Definição específica de números:
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/


/*
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd.MM.yyyy HH:mm"));
*/


/*
// Validação e tratamento de erros de horário
string aux = "2022/10/28 23:00";
DateTime data = DateTime.Parse(aux);
bool ok = DateTime.TryParseExact(aux, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
Console.WriteLine(data);

if (ok)
    Console.WriteLine($"Conversão com sucesso! Em: {data}");
else
    Console.WriteLine($"{aux} não é uma data válida!");
*/


/*
// Lendo arquivos externos e tratando erros com try/catch:
try
{
    string[] linhas = File.ReadAllLines("arquivoLeitura.txt");
    foreach (string linha in linhas)
        Console.WriteLine(linha);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Exceção genérica ocorrida: {ex.Message}");
}
finally
{
    Console.WriteLine("Fim do código.");
}
*/


// new Excecao().Metodo1();


/*
// Adicionando e removendo elementos em uma fila:
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);
foreach (int i in fila)
{
    Console.WriteLine($"Adicionando {i}...");
}
Console.WriteLine("\n");
while (fila.Count != 0)
{
    Console.WriteLine($"Removendo o elemento {fila.Dequeue()}...");
}
Console.WriteLine("\nFila vazia!");
*/


/*
// Adicionando e removendo elementos em um fila:
Stack<int> pilha = new Stack<int>();
pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);
foreach (int i in pilha)
{
    Console.WriteLine($"Adicionando {i}...");
}
Console.WriteLine("\n");
while (pilha.Count != 0)
{
    Console.WriteLine($"Removendo o elemento {pilha.Pop()}...");
}
Console.WriteLine("\nPilha vazia!");
*/


/*
// Manipulando dicionário:
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("BA", "Bahia");
estados.Add("SP", "São Paulo");
estados.Add("PE", "Pernambuco");

foreach (KeyValuePair<string, string> i in estados)
{
    Console.WriteLine($"Chave: {i.Key} // Valor: {i.Value}");
}

Console.WriteLine("********************************");
estados.Remove("SP");
estados["BA"] = "Bahia - Bahia";

foreach (KeyValuePair<string, string> i in estados)
{
    Console.WriteLine($"Chave: {i.Key} // Valor: {i.Value}");
}
string chave = "BA";
Console.WriteLine("Verificando {chave}...");

if (estados.ContainsKey(chave))
    Console.WriteLine($"Valor existe: {chave}");
else
    Console.WriteLine("Chave não existente, é possível adicioná-la.");
*/


/*
// Tuplas:
(int idade1, string nome1, string sobrenome1, decimal altura1) tupla1 = (23, "Aydan", "Barreto", 1.80M);
ValueTuple<int, string, string, decimal> tupla2 = Tuple.Create(21, "Maria", "Júlia", 1.65M);


Console.WriteLine($"Idade: {tupla1.idade}");
Console.WriteLine($"Nome: {tupla1.nome}");
Console.WriteLine($"Sobrenome: {tupla1.sobrenome}");
Console.WriteLine($"Altura: {tupla1.altura}");
*/


/*
// Aplicabilidade de tuplas:
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhasArquivo, qtdLinhas) = arquivo.LerArquivo(("arquivoLeitura.txt"));
if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas: {qtdLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
    Console.WriteLine("Não foi possível ler o arquivo.");
*/


/*
// Descarte de informação de tuplas:
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo(("arquivoLeitura.txt"));
if (sucesso)
{
//    Console.WriteLine($"Quantidade de linhas: {qtdLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
    Console.WriteLine("Não foi possível ler o arquivo.");
*/


/*
// Desconstrutor:
Pessoa p1 = new Pessoa("Aydan", "Barreto", 23);
(string nome, string sobrenome) p1;
Console.WriteLine()$"{nome} + {sobrenome}");
*/


/*
// If ternário:
int numero = 15;
bool paridade = false;
paridade = (numero % 2 == 0);
Console.WriteLine($"O número {numero} é "+ (paridade ? "par" : "ímpar"));
*/


/*
// Serializando objetos em arquivos com formato JSON:
DateTime dataAtual = DateTime.Now;
List<Venda> listaVendas = new List<Venda>();
Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);
listaVendas.Add(v1);
listaVendas.Add(v2);
string teste = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("venda.json", teste);
Console.WriteLine(teste);
*/


/*
// Desserializando arquivos JSON para nosso projeto:
string conteudoArquivo = File.ReadAllText("venda.json");
List<VendaJson>? listaVendas = JsonConvert.DeserializeObject<List<VendaJson>>(conteudoArquivo);
foreach (VendaJson venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
}
*/


/*
// Testando valores nulos:
bool? recebeEmail = null;
if(recebeEmail.HasValue && recebeEmail.Value)
    Console.WriteLine("O usuário recebe email.");
else
    Console.WriteLine("O usuário não recebe email ou não respondeu.");
*/


/*
// Trabalhando com valores anônimos:
var tipoAnonimo = new {Nome = "Aydan", Sobrenome = "Barreto", Idade = 23};
Console.WriteLine($"Nome: {tipoAnonimo.Nome}\nSobrenome: {tipoAnonimo.Sobrenome}\nAltura: {tipoAnonimo.Idade}\n");

string conteudoArquivo = File.ReadAllText("venda.json");
List<VendaJson>? listaVendas = JsonConvert.DeserializeObject<List<VendaJson>>(conteudoArquivo);
var listaAnonimo = listaVendas.Select(x => new {x.Produto, x.Preco});
foreach (VendaJson venda in listaVendas)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}
*/


/*
// Trabalhando com variáveis dinâmicas:
dynamic variavel1 = 4;
Console.WriteLine($"Tipo da variável: {variavel1.GetType()}\nValor: {variavel1}");
dynamic variavel2 = "Texto";
Console.WriteLine($"Tipo da variável: {variavel2.GetType()}\nValor: {variavel2}");
dynamic variavel3 = true;
Console.WriteLine($"Tipo da variável: {variavel3.GetType()}\nValor: {variavel3}");
dynamic variavel4 = (18, 5.00M, "Teste", true);
Console.WriteLine($"Tipo da variável: {variavel4.GetType()}\nValor: {variavel4}");
*/


/*
// Testando classes genéricas:
Array<int> arrayInt = new Array<int>();
arrayInt.AddElementoArray(30);
Console.WriteLine(arrayInt[0]);

Array<string> arrayStr = new Array<string>();
arrayStr.AddElementoArray("Teste");
Console.WriteLine(arrayStr[0]);
*/


/*
// Testando extensão de métodos:
int numero = 20;
bool paridade = false;
paridade = numero.IsEven();
Console.WriteLine($"O número {numero} é "+ (paridade ? "par" : "ímpar"));
*/


/*
// Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, 
// o elemento que aparece o maior número de vezes no seu array.

// A primeira linha da entrada deverá ser o número referente ao tamanho do seu array.
// As demais linhas nums serão os valores da sua array.

// A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (major != nums[i])
            {
                major = nums[i];
                count = 1;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return major;
    }
}
*/

/*
// A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
// 
// Salário                -       Percentual de ajuste
// 0 - 400.00             -              15%
// 400.01 - 800.00        -              12%
// 800.01 - 1200.00       -              10%
// 1200.01 - 2000.00      -              7%
// Acima de 2000.00       -              4%
//
// Leia o salário do funcionário e calcule e mostre o novo salário, 
// bem como o valor de reajuste ganho e o índice reajustado, em percentual.

// A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.
// Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho.

class minhaClasse { 

    static void Main(string[] args) {  

        double salario = 0.00; 
        double reajuste = 0.00; 
        double novoSalario = 0.00; 
        double percentual = 0.00; 
  
        salario = Convert.ToDouble(Console.ReadLine());

        if(salario < 0) { 
            return; 

        } else if (salario >= 0 && salario <= 400) {
            
            percentual = 0.15;
            reajuste =  salario * percentual;
            novoSalario = salario + reajuste;
            Console.WriteLine($"Novo salario: {novoSalario}");
            Console.WriteLine($"Reajuste ganho: {reajuste}");
            Console.WriteLine($"Em percentual: {percentual.ToString("P")}");

        } else if (salario > 400 && salario <= 800) { 
            percentual = 0.12;
            reajuste =  salario * percentual;
            novoSalario = salario + reajuste;
            Console.WriteLine($"Novo salario: {novoSalario}");
            Console.WriteLine($"Reajuste ganho: {reajuste}");
            Console.WriteLine($"Em percentual: {percentual.ToString("P")}");

        } else if (salario > 800 && salario <= 1200) { 
            percentual = 0.10;
            reajuste =  salario * percentual;
            novoSalario = salario + reajuste;
            Console.WriteLine($"Novo salario: {novoSalario}");
            Console.WriteLine($"Reajuste ganho: {reajuste}");
            Console.WriteLine($"Em percentual: {percentual.ToString("P")}"); 

        } else if (salario > 1200 && salario <= 2000) { 
            percentual = 0.07;
            reajuste =  salario * percentual;
            novoSalario = salario + reajuste;
            Console.WriteLine($"Novo salario: {novoSalario}");
            Console.WriteLine($"Reajuste ganho: {reajuste}");
            Console.WriteLine($"Em percentual: {percentual.ToString("P")}");

        } else { 
            percentual = 0.4;
            reajuste =  salario * percentual;
            novoSalario = salario + reajuste;
            Console.WriteLine($"Novo salario: {novoSalario}");
            Console.WriteLine($"Reajuste ganho: {reajuste}");
            Console.WriteLine($"Em percentual: {percentual.ToString("P")}"); 

        }
    } 
}
*/


/*
// A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se
// dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de
// capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é
// classificada em um nível dependendo de sua velocidade:

// Nível 1: Se a velocidade é menor que 10 cm/h .
// Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
// Nível 3: Se a velocidade é maior ou igual a 20 cm/h .

// Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.
// A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro
// L (1 ≤ L ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50)
// representando as velocidades de cada tartaruga do grupo.

// Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.
class Desafio {
    public static void Main() {
        int quantidadeEntradas = 3;
      
        while (quantidadeEntradas > 0) {
            var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
            if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
                string[] tartarugas = Console.ReadLine().Split(" ");
                var maiorVelocidade = Int32.Parse(tartarugas[0]);
                
                for (int i = 1; i < numeroQuantidade; i++) {
                    var tartaruga = Int32.Parse(tartarugas[i]);
            
                    if (tartaruga > maiorVelocidade) {
                        maiorVelocidade = tartaruga;
                    }
                }


                if(maiorVelocidade < 10) {
                    Console.WriteLine(1);
                } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
                    Console.WriteLine(2);
                } else if (maiorVelocidade  >= 20) {
                    Console.WriteLine(3);
                }
                quantidadeEntradas--;
            } else {
                Console.WriteLine("Insira um número entre 1 e 500");
            }
        }
    }
}
*/