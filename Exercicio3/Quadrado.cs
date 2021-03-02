namespace Exercicio3
{
    public class Quadrado : AreaCalculavel, PerimetroCalculavel
    {

        private double lado{get; set;}

        public double Lado {
            get => this.lado;
            set => this.lado = value;

        }

        public double calculaArea(double lado){
            return lado * lado;

        }

        public double calculaPerimetro(double lado){
            return lado * 4;

        }
        
    }
}