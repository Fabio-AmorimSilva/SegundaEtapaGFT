using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opUsuario = Menu();
            int auxId;
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Gerente> gerentes = new List<Gerente>(); 

            do {

                switch(opUsuario){
                    case 1:
                        Funcionario funcionario = new Funcionario();
                        Console.WriteLine("Digite o nome do funcionário: ");
                        funcionario.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o número de identificação: ");
                        funcionario.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o salário do funcionário: ");
                        funcionario.Salario(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Digite o tempo de empresa do funcionário em anos: ");
                        funcionario.Tempo = float.Parse(Console.ReadLine());
                        funcionarios.Add(funcionario);
                    break;
                    case 2:
                        Gerente gerente = new Gerente();
                        Console.WriteLine("Digite o nome do gerente: ");
                        gerente.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o número de identificação: ");
                        gerente.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o salário do gerente: ");
                        gerente.Salario(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Digite o tempo de empresa do gerente em anos: ");
                        gerente.Tempo = float.Parse(Console.ReadLine());
                        gerentes.Add(gerente);
                    break;
                    case 3:
                        Console.WriteLine("Digite o id: ");
                        auxId = int.Parse(Console.ReadLine());
                        Gerente.consultaGerente(gerentes, auxId);
                        Funcionario.consultaFuncionario(funcionarios, auxId);
                    break;
                    case 4:
                        Console.WriteLine("Digite o Id do funcionário: ");
                        auxId = int.Parse(Console.ReadLine());
                        Funcionario.alteraFuncionario(funcionarios, auxId);
                        Funcionario.consultaFuncionario(funcionarios, auxId);
                    break;
                    case 5:
                        Console.WriteLine("Digite o Id do gerente: ");
                        auxId = int.Parse(Console.ReadLine());
                        Gerente.alteraGerente(gerentes, auxId);
                        Gerente.consultaGerente(gerentes, auxId);
                    break;
                    case 6:
                    continue;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                    break;
                }

                opUsuario = Menu();

            }while(opUsuario != 6);

            Console.WriteLine("Obrigado pela perferência. Volte sempre!");

        }


        public static int Menu(){

            int op;

            Console.WriteLine("Menu de opções");
            Console.WriteLine("1 - Adiciona funcionário.");
            Console.WriteLine("2 - Adiciona gerente.");
            Console.WriteLine("3 - Consulta identificação (Id).");
            Console.WriteLine("4 - Para alterar dados de funcionário.");
            Console.WriteLine("5 - Para alterar dados de gerente.");
            Console.WriteLine("6 - Sair.");
            op = int.Parse(Console.ReadLine());

            return op;

        }
    }
}
