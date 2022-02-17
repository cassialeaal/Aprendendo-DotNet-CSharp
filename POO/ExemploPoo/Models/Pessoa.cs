using System;

namespace ExemploPoo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}