using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        //usando classe Array para ordenar
         static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] {6, 3, 8, 1, 9};
            int[] arrayCopia = new int[10];

            int valorProcurado = 6;

            int indice = op.ObterIndice(array, valorProcurado);

            if (indice > -1)
            {
                System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            }
            else
            {
                System.Console.WriteLine("Nao encontramos este elemento");
            }
        //------------------------------------------------------------------------------------

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }
            
        //------------------------------------------------------------------------------------
            //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os numeros são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existem valores menores ou iguais a {0}", valorProcurado);
            // }

        //------------------------------------------------------------------------------------
            // bool existe = op.Existe(array, valorProcurado);
            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }
        //------------------------------------------------------------------------------------
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] {6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];

            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array Antes da Copia");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a copia");
            // op.ImprimirArray(arrayCopia);


        //------------------------------------------------------------------------------------

            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);

            // op.Ordenar(ref array);
            // System.Console.WriteLine("Array Ordenado");
            // op.ImprimirArray(array);

        //------------------------------------------------------------------------------------
        // static void Main(string[] args)
        // {
        //     OperacoesArray op = new OperacoesArray();
        //     int[] array = new int[5] {6, 3, 8, 1, 9};

        //     System.Console.WriteLine("Array Original");
        //     op.ImprimirArray(array);

        //     op.OrdenarBubbleSort(ref array);
        //     System.Console.WriteLine("Array Ordenado");
        //     op.ImprimirArray(array);
        //------------------------------------------------------------------------------------
            // int[,] matriz = new int[4,2]    //declarando uma matriz
            // {                               //declarando os valores da matriz
            //   { 8, 8},
            //   { 10, 20},
            //   { 50, 100},
            //   { 90, 200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);   
            //     }
            // }

        //------------------------------------------------------------------------------------
            //int[] arrayInteiros = new int[3];
            
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30"); //converte o valor dado de string para inteiro
            
            // arrayInteiros[3] = 30; // acessando posição inexistente (3)


            // System.Console.WriteLine("Percorrendo o array pelo For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //      System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

        }
    }
}