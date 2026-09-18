using System;

namespace ClassesAbstratas
{
    internal class Arco : Arma
    {
        public override int CalcularAtaqueCritico()
        {
            return DanoBase * 3;
        }
    }
}