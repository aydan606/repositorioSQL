using System;
using System.IO;
using System.Net;
using System.Security.Policy;

namespace FundamentosEXT
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] linhas, int qtd) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception e)
            {
                return (false, Array.Empty<string>(), 0);
            }
        }
        
    }
}