using System;

namespace Fundamentos.models
{
    public class Calculadora
    {
        
        public void Soma(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        
        public void Subtracao(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        
        public void Multiplicacao(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        
        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        
        public void Modulo(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }
        
        public void Potenciacao(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(10, 2)}");
        }

        public void Seno(double a)
        {
            Console.WriteLine($"Seno de {a}° é {Math.Round(Math.Sin((a * Math.PI) / 180), 4)} .");
        }
        
        public void Cosseno(double a)
        {
            Console.WriteLine($"Cosseno de {a}° é {Math.Round(Math.Cos((a * Math.PI) / 180), 4)} .");
        }
        
        public void Tangente(double a)
        {
            Console.WriteLine($"Seno de {a}° é {Math.Round(Math.Tan((a * Math.PI) / 180), 4)} .");
        }

        public void RaizQuadrada(double x)
        {
            Console.WriteLine($"Raiz quadrada de {x} é {Math.Round(Math.Sqrt(x) , 2)} .");
        }
        
    }
    
}