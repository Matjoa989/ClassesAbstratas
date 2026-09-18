using System;

namespace ClassesAbstratas
{
    internal class Espada : Arma
    {
        public override int CalcularAtaqueCritico()
        {
            return DanoBase * 2;
        }
    }
}