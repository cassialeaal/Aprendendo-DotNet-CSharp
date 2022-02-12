// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Pratica01
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno

                        break;
                    case "2":
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: calcula media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine("\nInforme a opção desejada:");
            Console.WriteLine("\n1- Inserir novo aluno");
            Console.WriteLine("\n2- Listar alunos");
            Console.WriteLine("\n3- Calcular média geral\n");
            Console.WriteLine("\nX- Sair\n");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}