using System;
using ExemploFundamentos.Common;

namespace ExemploFundamentos.NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Thalia";
            pessoa1.Idade = 20;
            pessoa1.Apresentar();
        }
    }
}
