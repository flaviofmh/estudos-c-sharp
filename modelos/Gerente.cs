using System;

namespace poo_c_sharp
{
    public class Gerente : Funcionario
    {
        public override double ReceberBonificacao()
        {
            return Salario * 5;
        }
    }
}