namespace Exercicio2
{
    public class Gerente : Pessoa
    {
        
        private string senha{ get; set;}

        private bool autentica{get;set;}

        private float salario{get; set;}

        public override double recebimento(){ 
            return this.salario * 1.5;
        }

    }
}