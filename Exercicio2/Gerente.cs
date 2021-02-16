using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class Gerente : Pessoa
    {
        
        private string senha{ get; set;}

        private bool autentica{get;set;}

        private double salario;

         public override void Salario(double valor){
            this.salario = valor * 1.5;
        }

         public static void consultaGerente(List<Gerente> gerentes, int auxId){

            for(int i = 0; i < gerentes.Count; i++){

                if(gerentes[i].Id == auxId){
                    Console.WriteLine("Nome: " + gerentes[i].Nome);
                    Console.WriteLine("Id: " + gerentes[i].Id);
                    Console.WriteLine("Salario: " + gerentes[i].salario);
                    Console.WriteLine("Tempo de empresa: " + gerentes[i].Tempo + " anos.");
                    Console.WriteLine();

                }else{
                    Console.WriteLine("O gerente não foi encontrado na nossa base de dados.");

                }
            }
        }

         public static void alteraGerente(List<Gerente> gerentes, int auxId){

            for(int i = 0; i < gerentes.Count; i++){

                if(gerentes[i].Id == auxId){
                    Console.WriteLine("Dados do gerente ->");
                    Console.WriteLine("Digite um novo nome: ");
                    gerentes[i].Nome = Console.ReadLine();
                    Console.WriteLine("Digite um novo Id: ");
                    gerentes[i].Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite um novo salario: ");
                    gerentes[i].Salario(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Digite o novo tempo de empresa: ");
                    gerentes[i].Tempo = float.Parse(Console.ReadLine());
                    Console.WriteLine("");

                }else{
                    Console.WriteLine("O gerente não foi encontrado na nossa base de dados.");

                }
            }
        }

    }
}