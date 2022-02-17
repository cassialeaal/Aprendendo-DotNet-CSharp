using System;
using System.IO;
using System.Collections.Generic;
using ExemploPoo.Helper;
using ExemploPoo.Interfaces;
using ExemploPoo.Models;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\Cassia Leal\\Documents\\BootcampDIO.NET\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
           
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinua = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! teste de escrita de arquivo. By Cassia Leal");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinua);
            helper.LerArquivoStream(caminhoArquivo);

        //---------------------------------------------------------------
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));
                   
        //---------------------------------------------------------------

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

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