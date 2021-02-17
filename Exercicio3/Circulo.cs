namespace Exercicio3
{
    public class Circulo : ICirculo
    {
        
        private double raio{get; set;}

        public double Raio {
            get => this.raio;
            set => this.raio = value;

        }

         public double calculaAreaC(double raio){
            return 3.14 * (raio * raio);

        }

        public double calculaPerimetroC(double raio){
            return (2 * 3.14) * raio;

        }

    }
}