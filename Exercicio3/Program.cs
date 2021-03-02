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
            double auxRaio;

            do {

                switch(opUsuario){
                    case 1:
                        Console.WriteLine("Digite o tamanho do lado do quadrado: ");
                        auxLado = double.Parse(Console.ReadLine());
                        while(auxLado <= 0){
                            Console.WriteLine("Digite um tamanho válido ( > 0) ou digite -1 para sair: ");
                            auxLado = double.Parse(Console.ReadLine());
                            if(auxLado == -1){
                                auxLado = 0;
                                break;
                            }
                        }
                        Console.WriteLine("Área: " + String.Format("{0:00.00}", quadrado.calculaArea(auxLado)));
                    break;
                    case 2:
                        Console.WriteLine("Digite o tamanho do lado do quadrado: ");
                        auxLado = double.Parse(Console.ReadLine());
                         while(auxLado <= 0){
                            Console.WriteLine("Digite um tamanho válido para o lado ( > 0) ou digite -1 para sair: ");
                            auxLado = double.Parse(Console.ReadLine());
                            if(auxLado == -1){
                                auxLado = 0;
                                break;
                            }
                        }
                        Console.WriteLine("Perímetro: " + String.Format("{0:00.00}", quadrado.calculaPerimetro(auxLado)));
                    break;
                    case 3:
                        Console.WriteLine("Digite o tamanho do raio do círculo: ");
                        auxRaio = double.Parse(Console.ReadLine());
                         while(auxRaio <= 0){
                            Console.WriteLine("Digite um tamanho válido para o lado ( > 0) ou digite -1 para sair:");
                            auxRaio = double.Parse(Console.ReadLine());
                            if(auxRaio == -1){
                                auxRaio = 0;
                                break;
                            }
                        }
                        Console.WriteLine("Área: " + String.Format("{0:00.00}", circulo.calculaArea(auxRaio)));
                    break;
                    case 4:
                        Console.WriteLine("Digite o tamanho do raio do círculo: ");
                        auxRaio = double.Parse(Console.ReadLine());
                         while(auxRaio <= 0){
                            Console.WriteLine("Digite um tamanho válido para o raio ( > 0) ou digite -1 para sair: ");
                            auxRaio = double.Parse(Console.ReadLine());
                            if(auxRaio == -1){
                                auxRaio = 0;
                                break;
                            }
                        }
                        Console.WriteLine("Perímetro: " + String.Format("{0:00.00}", circulo.calculaPerimetro(auxRaio)));
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
