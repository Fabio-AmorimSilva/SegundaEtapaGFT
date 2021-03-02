namespace Exercicio3
{
    public class Circulo : AreaCalculavel, PerimetroCalculavel
    {
        
        private double raio{get; set;}

        public double Raio {
            get => this.raio;
            set => this.raio = value;

        }

         public double calculaArea(double raio){
            return 3.14 * (raio * raio);

        }

        public double calculaPerimetro(double raio){
            return 2 * System.Math.PI * raio;

        }

    }
}