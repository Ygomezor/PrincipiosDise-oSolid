using System;
using System.Collections.Generic;

namespace PrincipioAbiertoCerrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O: Open/closed principle o Principio de abierto/cerrado");
            List<Automovil> automoviles = new List<Automovil>() { new Renault(), new Audi(), new Mercedes() };
            ImprimirPrecioAutomovil(automoviles);
            Console.ReadKey();
        }

        private static void ImprimirPrecioAutomovil(List<Automovil> automoviles)
        {
            foreach (var automovil in automoviles)
            {
                Console.WriteLine($"El precio del {automovil.GetType().Name} es {automovil.PrecioAutomovil()}");
            }
        }
    }
}
