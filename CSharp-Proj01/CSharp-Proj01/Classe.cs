﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{

    //Caso o using System não seja declarado no inicio do código
    //e queremos usar o Console, podemos declarar o System no namespace em questão.
    //Abaixo temos comentando o exemplo de como declará-lo neste caso.

    //System.Console

    //Se o System já foi declarado no início do código, apenas adicionar o comando abaixo

    //Console

    //O namespace serve para separar as classes, e não é possível ter duas classes iguais
    //dentro de um único namespace
    //A estrutura abaixo não é válida e dará um erro pois a Classe já existe anteriormente:
    //namespace Primeiro
    //{
    //  class Classe
    //  {
    //
    //  }
    //
    //  class Classe
    //  {
    //
    //  }
    //}

    class Pessoa
    {
        public string Nome { get; set; }
        public string Estado { get; set; }
        public int Idade { get; set; }
    }

}



namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.Dono (string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
        void IAnimal.Especie (string especie)
        {
            this.Especie = especie;
        }
    }
} 