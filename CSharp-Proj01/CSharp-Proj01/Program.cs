using System;
using CSharp;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Cassia";
            person.Idade = 24;
            person.Estado = "PE";

            var person2 = new Pessoa();

            person2.Nome = "Gustavo";
            person2.Idade = 26;
            person2.Estado = "PE";

            Console.WriteLine("Hello World!");
        }
    }
}