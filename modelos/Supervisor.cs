using System;

namespace poo_c_sharp
{
    public class Supervisor : Funcionario
    {
        public override double ReceberBonificacao()
        {
            return Salario * 3;
        }
    }
}