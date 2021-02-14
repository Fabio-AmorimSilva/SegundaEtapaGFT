using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opUsuario = Menu();
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Gerente> gerentes = new List<Gerente>(); 

            do {

                switch(opUsuario){
                    case 1:
                    break;
                    case 2:
                    break;
                    case 3:
                    break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                    break;
                }

                opUsuario = Menu();

            }while(opUsuario != 4);

        }


        public static int Menu(){

            int op;

            Console.WriteLine("Menu de opções");
            Console.WriteLine("1 - Adiciona funcionário.");
            Console.WriteLine("2 - Adiciona gerente.");
            Console.WriteLine("3 - Consulta nome.");
            Console.WriteLine("4 - Sair");
            op = int.Parse(Console.ReadLine());

            return op;

        }
    }
}
