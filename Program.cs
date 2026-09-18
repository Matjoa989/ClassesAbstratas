using System;

namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var drone = new Drone();


            ICamera camera = drone;
            camera.TirarFoto();


            IVoavel voavel = drone;
            voavel.Decolar();
            voavel.Pousar();
        }
    }
}