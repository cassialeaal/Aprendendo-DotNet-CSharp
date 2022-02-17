namespace ExemploPoo.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                if (valido)
                {
                    System.Console.WriteLine("Valores Inválidos.");
                }
                else
                {
                    System.Console.WriteLine("Preencha Valores Válidos");
                    return;
                }
                
            }
        }

        public double ObterArea()
        {
            return comprimento*largura;
        }
    }
}