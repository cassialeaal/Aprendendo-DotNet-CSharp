﻿using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador comp = new Computador();
            System.Console.WriteLine(comp.ToString());
        //---------------------------------------------------------------

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

        //---------------------------------------------------------------

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine($"Resultado primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine($"Resultado segunda soma: " + calc.Somar(10, 10, 20));
        
        //---------------------------------------------------------------
            // Aluno p1 = new Aluno();
            // p1.Nota = 10;
            // p1.Nome = "Cassia";
            // p1.Idade = 24;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Salario = 3000;
            // p2.Nome = "Roberta";
            // p2.Idade = 26;
            // p2.Apresentar();


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