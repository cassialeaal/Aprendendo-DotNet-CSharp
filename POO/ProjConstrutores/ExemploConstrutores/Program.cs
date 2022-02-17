using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main (string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa("Cassia", "Leal");
            p1.Apresentar();
            p2.Apresentar();
        }
    }
}