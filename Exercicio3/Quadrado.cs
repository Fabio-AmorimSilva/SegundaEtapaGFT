namespace Exercicio3
{
    public class Quadrado : IQuadrado
    {

        private double lado{get; set;}

        public double Lado {
            get => this.lado;
            set => this.lado = value;

        }

        public double calculaAreaQ(double lado){
            return lado * lado;

        }

        public double calculaPerimetroQ(double lado, int quantidade){
            return lado * quantidade;

        }
        
    }
}