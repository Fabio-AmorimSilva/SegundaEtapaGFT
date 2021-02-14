namespace Exercicio2
{
    public class Funcionario : Pessoa
    {

        private double salario;

        public override double recebimento()
        {
            return this.salario*1.2;
        }
    }
}