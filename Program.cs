using System;

namespace poo_c_sharp
{
    class Program
    {
        const double SalarioMinimo = 1500.00;


        static void Main(string[] args)
        {
            Funcionario joao = new Funcionario();
            joao.Salario = SalarioMinimo;

            Funcionario pedro = new Gerente();
            pedro.Salario = SalarioMinimo;
            
            Funcionario fernando = new Supervisor();
            fernando.Salario = SalarioMinimo;

            Console.WriteLine("Informacao joao salario: {0}", joao.Salario);
            Console.WriteLine("Informacao pedro salario: {0}", joao.Salario);
            Console.WriteLine("Informacao fernando salario: {0}", joao.Salario);


            Console.WriteLine("Bonificacao joao salario: {0}", joao.ReceberBonificacao());
            Console.WriteLine("Bonificacao pedro salario: {0}", pedro.ReceberBonificacao());
            Console.WriteLine("Bonificacao fernando salario: {0}", fernando.ReceberBonificacao());
        }
    }
}
