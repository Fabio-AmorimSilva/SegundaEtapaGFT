using System;
using System.Collections.Generic;

namespace Exercicio1
{
    public class Comprador
    {
        private string primeiroNome;
        private string sobreNome;
        private int cpf;
        private int tel;
        private float saldo;
        private List<Carro> garagem = new List<Carro>();

        public Comprador(){

        }

        public Comprador(string primeiroNome, string sobreNome, int cpf, int tel, float saldo){

            primeiroNome = this.primeiroNome;
            sobreNome = this.sobreNome;
            cpf = this.cpf;
            tel = this.tel;
            saldo = this.saldo;

        }

        public static void addComprador(List<Comprador> compradores){

            Comprador comprador = new Comprador();
            Carro auxCarro = new Carro();

            Console.WriteLine("Digite o primeiro nome: ");
            comprador.primeiroNome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome: ");
            comprador.sobreNome = Console.ReadLine();

            Console.WriteLine("Digite o cpf: ");
            comprador.cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o telefone: ");
            comprador.tel = int.Parse(Console.ReadLine());

            do {

                Console.WriteLine("Digite o saldo: ");
                comprador.saldo = float.Parse(Console.ReadLine());

                if(comprador.saldo < 0){
                    Console.WriteLine("Insira um saldo válido.");

                }

            }while(comprador.saldo < 0);

            compradores.Add(comprador);

            Console.WriteLine("Comprador adicionado com sucesso!");

        }

        public static void compraCarro(List<Comprador> compradores, List<Carro> carros){

            string auxModelo;
            string opcao;
            int auxAno;

            Comprador auxComprador = buscaComprador(compradores);

            Console.WriteLine("Digite o modelo do carro: ");
            auxModelo = Console.ReadLine();
            Console.WriteLine("Digite o ano: ");
            auxAno = int.Parse(Console.ReadLine());

            Carro carro = Carro.mostraCarro(carros, auxModelo, auxAno);

            Console.WriteLine("Deseja comprar o carro? ");
            opcao = Console.ReadLine();

            if(opcao == "Sim" && auxComprador.saldo >= carro.getPreco()){
                auxComprador.saldo -= carro.getPreco();
                auxComprador.garagem.Add(carro);
                compradores.Add(auxComprador);
                Console.WriteLine("Carro adquirido!");

            }else if(opcao == "Nao"){
                Console.WriteLine("Carro não adquirido. Volte sempre!");

            }else if(auxComprador.saldo < carro.getPreco()){
                Console.WriteLine("Saldo insuficiente!");
                
            }

        }

        public static Comprador buscaComprador(List<Comprador> compradores){

            int auxCpf;

            Console.WriteLine("Digite o cpf do comprador: ");
            auxCpf = int.Parse(Console.ReadLine());

            for(int i = 0; i < compradores.Count; i++){
                if(compradores[i].cpf == auxCpf){
                    Console.WriteLine("Comprador encontrado!");
                    Console.WriteLine("Apresentando informações...");
                    Console.WriteLine("Nome completo: " + compradores[i].primeiroNome + " " 
                    + compradores[i].sobreNome);
                    Console.WriteLine("CPF: " + compradores[i].cpf);
                    Console.WriteLine("Telefone: " + compradores[i].tel);
                    Console.WriteLine("Saldo: " + compradores[i].saldo);
                    return compradores[i];

                }else {
                    Console.WriteLine("O comprador não se encontra na base de dados!");

                }

            }

            return null;
        }

        public static List<Comprador> atualizaComprador(List<Comprador> compradores, 
            Comprador comprador){

            int auxCpf = comprador.cpf;
            
            for(int i = 0; i < compradores.Count; i++){
                if(compradores[i].cpf == auxCpf){
                    compradores[i] = comprador;
                    Console.WriteLine("Dados atualizados com sucesso!");
                    Console.WriteLine("Apresentando novas informações...");
                    Console.WriteLine("Nome completo: " + compradores[i].primeiroNome + " " 
                    + compradores[i].sobreNome);
                    Console.WriteLine("CPF: " + compradores[i].cpf);
                    Console.WriteLine("Telefone: " + compradores[i].tel);
                    Console.WriteLine("Saldo: " + compradores[i].saldo);


                }else {
                    Console.WriteLine("O comprador não se encontra na base de dados!");

                }

            }
            
            return compradores;

        }
        
    }
}