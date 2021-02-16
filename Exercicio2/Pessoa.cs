namespace Exercicio2
{
    public abstract class Pessoa
    {
        
        private string nome { get; set;}

        public string Nome {
            get => this.nome;
            set => this.nome = value;
        }

        private int id {get; set;}

        public int Id {
            get => this.id;
            set => this.id = value;
        }

        public abstract void Salario(double valor);

        private float tempo {get; set;}

        public float Tempo {
            get => this.tempo;
            set => this.tempo = value;
        }







    }
}