using System;

namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var espada = new Espada { Nome = "Excalibur", DanoBase = 10 };
            var arco = new Arco { Nome = "Arco Longo", DanoBase = 7 };

            Console.WriteLine();
            espada.ExibirInfo();
            Console.WriteLine($"Ataque crítico da espada: {espada.CalcularAtaqueCritico()}");

            arco.ExibirInfo();
            Console.WriteLine($"Ataque crítico do arco: {arco.CalcularAtaqueCritico()}");
        }
    }
}