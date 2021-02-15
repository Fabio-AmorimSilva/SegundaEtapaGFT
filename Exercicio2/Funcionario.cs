using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class Funcionario : Pessoa
    {

        private double salario;
       
        public override void Salario(double valor){
            this.salario = valor * 1.2;

        }

        public static void consultaFuncionario(List<Funcionario> funcionarios, int auxId){

            for(int i = 0; i < funcionarios.Count; i++){

                if(funcionarios[i].Id == auxId){
                    Console.WriteLine("Dados do funcionário ->");
                    Console.WriteLine("Nome: " + funcionarios[i].Nome);
                    Console.WriteLine("Id: " + funcionarios[i].Id);
                    Console.WriteLine("Salario: " + funcionarios[i].salario);
                    Console.WriteLine();

                }else{
                    Console.WriteLine("O usuário não foi encontrado na nossa base de dados.");

                }
            }
        }

        public static void alteraFuncionario(List<Funcionario> funcionarios, int auxId){

            for(int i = 0; i < funcionarios.Count; i++){

                if(funcionarios[i].Id == auxId){
                    Console.WriteLine("Digite um novo nome: ");
                    funcionarios[i].Nome = Console.ReadLine();
                    Console.WriteLine("Digite um novo Id: ");
                    funcionarios[i].Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite um novo salario: ");
                    funcionarios[i].Salario(double.Parse(Console.ReadLine()));
                    Console.WriteLine("");

                }else{
                    Console.WriteLine("O funcionário não foi encontrado na nossa base de dados.");

                }
            }
        }

        
    }
}