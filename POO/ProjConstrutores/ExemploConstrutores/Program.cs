using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main (string[] args)
        {
            Aluno a1 = new Aluno("Cassia", "Roberta", "Dev");
            a1.Apresentar();
        //---------------------------------------------------
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste Instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

        //---------------------------------------------------
            // Pessoa p1 = new Pessoa();
            // Pessoa p2 = new Pessoa("Cassia", "Leal");
            // p1.Apresentar();
            // p2.Apresentar();


        }
    }
}