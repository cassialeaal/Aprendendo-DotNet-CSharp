namespace ExemploPoo.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}.");
        }
    }
}