using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("PE", "Pernambuco");
            estados.Add("PB", "Paraíba");
            estados.Add("AL", "Alagoas");

            foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Chave: {item.Key} -- Valor: {item.Value}");
            }

            string valorProcurado = "PE";

            System.Console.WriteLine($"Removendo o valor: {valorProcurado}");
            estados.Remove(valorProcurado);

              foreach (KeyValuePair<string, string> item in estados)
            {
                System.Console.WriteLine($"Chave: {item.Key} -- Valor: {item.Value}");
            }

            // string valorProcurado = "PE";
            // System.Console.WriteLine("Valor original:");
            // System.Console.WriteLine(estados[valorProcurado]);
            // //System.Console.WriteLine($"O valor da chave procurada é: {estados[valorProcurado]}");
            // estados[valorProcurado] = "PE - Teste atualização";

            // System.Console.WriteLine("Valor atualizado:");
            // System.Console.WriteLine(estados[valorProcurado]);

        //------------------------------------------------------------------------------------

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Codigo limpo");

            // System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo Livro para leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso.");
            // }

            // System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

        //------------------------------------------------------------------------------------
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Pernambuco");
            // fila.Enqueue("Alagoas");
            // fila.Enqueue("Paraíba");
            // fila.Enqueue("Ceará");
            // System.Console.WriteLine($"Nomes na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} removido.");
            // }

            // System.Console.WriteLine($"Nomes na fila: {fila.Count}");

        //------------------------------------------------------------------------------------

            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string> {"RN", "PE", "BA"};
            // string[] estadosArray = new string[2] {"PB", "CE"};

            
            // System.Console.WriteLine($"Quantidade de elementos da lista: {estados.Count}");
            // opLista.ImprimirListaString(estados);

            // //estados.AddRange(estadosArray);
            // estados.Insert(1, "AL");
            // System.Console.WriteLine("Lista completa:");
            // opLista.ImprimirListaString(estados);

            
        //------------------------------------------------------------------------------------

            // estados.Add("SP");
            // estados.Add("PE");
            // estados.Add("RJ");

            // System.Console.WriteLine($"Quantidade de elementos da lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);
            
            // System.Console.WriteLine("Removendo um elemento da lista");
            // estados.Remove("SP");
            // opLista.ImprimirListaString(estados);
        //------------------------------------------------------------------------------------

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }
            // for (int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"Indice {i}, Valor: {estados[i]}");
            // }
        

        //------------------------------------------------------------------------------------

        //usando classe Array para ordenar
        //     OperacoesArray op = new OperacoesArray();

        //     int[] array = new int[5] {6, 3, 8, 1, 9};
        //     int[] arrayCopia = new int[10];
        //     string[] arrayString = op.ConverterParaArrayString(array);
            
        //------------------------------------------------------------------------------------

            // //int valorProcurado = 6;

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length*2);

            // System.Console.WriteLine($"Capacidade após redimensionar: {array.Length}");

        //------------------------------------------------------------------------------------

            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontramos este elemento");
            // }
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