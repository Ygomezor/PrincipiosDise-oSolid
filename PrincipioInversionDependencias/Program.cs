using System;

namespace PrincipioInversionDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D: Dependency inversion principle o Principio de inversión de dependencia");
            AccionVehiculo automovil = new AccionVehiculo(new Automovil());
            automovil.Avanzar();
            automovil.Frenar();
            Console.ReadKey();
        }
    }
}
