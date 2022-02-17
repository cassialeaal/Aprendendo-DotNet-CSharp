using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main (string[] args)
        {
            //Operacao op = Calculadora.Somar;
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op.Invoke(20, 30);
            //op (20,30;)
            //Operacao op2 = Calculadora.Subtrair;
            //op2(20,30);

        //---------------------------------------------------

            // const double pi = 3.14;
            // System.Console.WriteLine(pi);            

        //---------------------------------------------------
            // Data data = new Data();
            // data.SetMes(2); // mes válido
            // data.SetMes(15); // mes inválido
            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();
        //---------------------------------------------------

            // Aluno a1 = new Aluno("Cassia", "Roberta", "Dev");
            // a1.Apresentar();
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