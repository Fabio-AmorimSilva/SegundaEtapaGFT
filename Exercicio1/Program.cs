using System;
using System.Collections.Generic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Comprador> compradores = new List<Comprador>();
            List<Carro> carros = new List<Carro>();

            int op = opcoes();
            string auxModelo;
            int auxAno;

            do{

                switch (op){
                    case 1:
                        Comprador.addComprador(compradores);
                    break;
                    case 2:
                        Carro.addCarro(carros);
                    break;
                    case 3:
                        Comprador.compraCarro(compradores, carros);
                    break;
                    case 4:
                        Console.WriteLine("Digite o modelo e o ano: ");
                        auxModelo = Console.ReadLine();
                        auxAno = int.Parse(Console.ReadLine());
                        Carro.mostraCarro(carros, auxModelo, auxAno);
                    break;
                    case 5:
                        Comprador.buscaComprador(compradores);
                    break;

                }

                op = opcoes();

            }while(op != 6);

        }

        private static int opcoes(){

            int opcao;

            Console.WriteLine("Menu de Opções");
            Console.WriteLine("1 - Adicione um comprador.");
            Console.WriteLine("2 - Adicione um carro.");
            Console.WriteLine("3 - Compre um carro.");
            Console.WriteLine("4 - Consulte um carro.");
            Console.WriteLine("5 - Consulte um comprador");
            Console.WriteLine("6 - Sair");

            opcao = int.Parse(Console.ReadLine());

            return opcao;

        }
    }
}
