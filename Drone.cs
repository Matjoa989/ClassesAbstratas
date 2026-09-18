using System;

namespace ClassesAbstratas
{
    internal class Drone : ICamera, IVoavel
    {
        public void TirarFoto()
        {
            Console.WriteLine("TIRANDO FOTO PANORÂMICA...");
        }

        public void Decolar()
        {
            Console.WriteLine("DRONE DECOLANDO VERTICALMENTE...");
        }

        public void Pousar()
        {
            Console.WriteLine("DRONE POUSANDO SUAVEMENTE...");
        }
    }
}