using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Cassia";
            p1.Idade = 24;

            p1.Apresentar();
        }
    }
}