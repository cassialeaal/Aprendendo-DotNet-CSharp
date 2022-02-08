using System;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Cassia;
            Pessoas pessoa3 = (Pessoas)3; */

            Animal? animal = new();

            animal.Nome = "Duque";
            animal.NomeDono = "Cassia";
            animal.Especie = "Canino";

            Pessoa person = new();

            person.Nome = "Cassia";
            person.Idade = 24;
            person.Estado = "PE";

            Pessoa? person2 = new();

            person2.Nome = "Gustavo";
            person2.Idade = 26;
            person2.Estado = "PE";

            

            
        }
    }
}