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
                    Console.WriteLine("Nome: " + funcionarios[i].Nome);
                    Console.WriteLine("Id: " + funcionarios[i].Id);
                    Console.WriteLine("Salario: " + funcionarios[i].salario);
                    Console.WriteLine();

                }else{
                    Console.WriteLine("O usuário não foi encontrado na nossa base de dados.");

                }
            }
        }

        
    }
}