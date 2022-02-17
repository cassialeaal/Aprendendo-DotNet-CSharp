using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            Professor p2 = new Professor();

            p1.Nota = 10;
            p1.Nome = "Cassia";
            p1.Idade = 24;
            p1.Apresentar();

            p2.Salario = 3000;
            p2.Nome = "Gustavo";
            p2.Idade = 26;
            p2.Apresentar();


        //---------------------------------------------------------------

            // //Valores Validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);

            // System.Console.WriteLine($"Area: {r.ObterArea()} m²");
            
            // //Valores Inválidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0,0);

            // System.Console.WriteLine($"Area: {r2.ObterArea()} m²");

        //---------------------------------------------------------------

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Cassia";
            // p1.Idade = 24;

            // p1.Apresentar();
        }
    }
}