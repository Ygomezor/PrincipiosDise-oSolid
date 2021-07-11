using System;
using System.Collections.Generic;

namespace PrincipioSustitucionLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Automovil> automoviles = new List<Automovil>() { new Renault(), new Audi(), new Mercedes() , new Ford()};
            ImprimirPrecioAutomovil(automoviles);
            Console.ReadKey();
        }
        private static void ImprimirPrecioAutomovil(List<Automovil> automoviles)
        {
            foreach (var automovil in automoviles)
            {
                Console.WriteLine($"El precio del {automovil.GetType().Name} es {automovil.PrecioAutomovil()} y tiene {automovil.NumeroAsientos()} asientos");
            }
        }
    }
}
