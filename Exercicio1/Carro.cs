using System;
using System.Collections.Generic;

namespace Exercicio1
{
    public class Carro
    {
        private string modelo;
        private string marca;
        private int ano;
        private string estado;
        private string combustivel;
        private float preco;
        private int quantidade;

        public Carro()
        {

        }

        public Carro(string modelo, string marca, int ano, string estado, 
        string combustivel, float preco, int quantidade){

            modelo = this.modelo;
            marca = this.marca;
            ano = this.ano;
            estado = this.estado;
            combustivel = this.combustivel;
            preco = this.preco;
            quantidade = this.quantidade;

        }

        public int getPreco(){
            return (int)this.preco;

        }

        public int getEstoque(){
            return (int)this.quantidade;

        }

        public void setEstoque(int num){
            this.quantidade -= num;
            
        }

        public static void addCarro(List<Carro> carros){

            Carro carro = new Carro();

            Console.Write("Digite o Modelo: ");
            carro.modelo = Console.ReadLine();

            Console.Write("Digite a marca: ");
            carro.marca = Console.ReadLine();

            Console.Write("Digite o ano: ");
            carro.ano = int.Parse(Console.ReadLine());

            Console.Write("Digite o estado (Novo ou Usado): ");
            carro.estado = Console.ReadLine();

            Console.Write("Digite o Combustível: ");
            carro.combustivel = Console.ReadLine();

            Console.Write("Digite o preço: ");
            carro.preco = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade em estoque: ");
            carro.quantidade = int.Parse(Console.ReadLine());

            carros.Add(carro);

            Console.WriteLine("Carro adicionado ao estoque!");
            Console.WriteLine();

            
        }

        public static Carro mostraCarro(List<Carro> carros, string modelo, int ano){

            for(int i = 0; i < carros.Count; i++){
                if(carros[i].modelo == modelo && carros[i].ano == ano){
                    Console.WriteLine("Modelo: " + carros[i].modelo);
                    Console.WriteLine("Marca: " + carros[i].marca);
                    Console.WriteLine("Ano: " + carros[i].ano);
                    Console.WriteLine("Estado: " + carros[i].estado);
                    Console.WriteLine("Combustível: " + carros[i].combustivel);
                    Console.WriteLine("Preço: " + carros[i].preco);
                    Console.WriteLine();
                    return carros[i];

                }else {
                    Console.WriteLine("O carro não se encontra na base de dados!");

                }
            }

            return null;

        }

    }
}