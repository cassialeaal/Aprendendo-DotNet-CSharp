using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores Validos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,30);

            System.Console.WriteLine($"Area: {r.ObterArea()} m²");
            
            //Valores Inválidos
            Retangulo r2 = new Retangulo();
            r.DefinirMedidas(0,0);

            System.Console.WriteLine($"Area: {r2.ObterArea()} m²");



            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Cassia";
            // p1.Idade = 24;

            // p1.Apresentar();
        }
    }
}