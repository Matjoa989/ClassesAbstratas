using System;

namespace ClassesAbstratas
{
    internal abstract class Arma
    {
        public string Nome { get; set; }
        public int DanoBase { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} | Dano base: {DanoBase}");
        }

        public abstract int CalcularAtaqueCritico();
    }
}