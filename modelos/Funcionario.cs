using System;

namespace poo_c_sharp
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double ReceberBonificacao()
        {
            return Salario * 1.5;
        }
    }
}