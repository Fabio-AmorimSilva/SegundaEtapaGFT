using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo circulo = new Circulo();
            Quadrado quadrado = new Quadrado();
            
            int opUsuario = Menu();
            double auxLado;
            int auxLados;
            double auxRaio;


            do {

                switch(opUsuario){
                    case 1:
                        Console.WriteLine("Digite o tamanho do lado do quadrado: ");
                        auxLado = double.Parse(Console.ReadLine());
                        Console.WriteLine("Área: " + quadrado.calculaAreaQ(auxLado));
                    break;
                    case 2:
                        Console.WriteLine("Digite o tamanho do lado do quadrado e a quantidade de lados: ");
                        auxLado = double.Parse(Console.ReadLine());
                        auxLados = int.Parse(Console.ReadLine());
                        Console.WriteLine("Perímetro: " + quadrado.calculaPerimetroQ(auxLado, auxLados));
                    break;
                    case 3:
                        Console.WriteLine("Digite o tamanho do raio do círculo: ");
                        auxRaio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Área: " + circulo.calculaAreaC(auxRaio));
                    break;
                    case 4:
                        Console.WriteLine("Digite o tamanho do raio do círculo: ");
                        auxRaio = double.Parse(Console.ReadLine());
                        Console.WriteLine("Perímetro: " + circulo.calculaPerimetroC(auxRaio));
                    break;
                    case 5:
                    continue;
                    default:
                        Console.WriteLine("Digite uma opção válida. Tente novamente.");
                    break;
                        
                    
                }

                opUsuario = Menu();


            }while(opUsuario != 5);

            

        }


        private static int Menu(){

            int op;

            Console.WriteLine("Menu de opções.");
            Console.WriteLine("1 - Calcula área do quadrado.");
            Console.WriteLine("2 - Calcula perímetro do quadrado");
            Console.WriteLine("3 - Calcula área do círculo.");
            Console.WriteLine("4 - Calcula perimetro do círculo.");
            Console.WriteLine("5 - Sair");
            op = int.Parse(Console.ReadLine());


            return op;

        }
    }
}
