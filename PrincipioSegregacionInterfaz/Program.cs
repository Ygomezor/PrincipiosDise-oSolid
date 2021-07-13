using System;
using System.Collections.Generic;

namespace PrincipioSegregacionInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I: Interface segregation principle o Principio de segregación de la interfaz");
            ToyotaCorollaCross toyotaCorollaCross = new ToyotaCorollaCross();
            Console.WriteLine($"El vehículo {toyotaCorollaCross.GetType().Name} es un {toyotaCorollaCross.TipoVehiculo()} y {toyotaCorollaCross.Avanzar()}, {toyotaCorollaCross.Frenar()} y {toyotaCorollaCross.Retroceder()} como los demás vehículos");
            RenaultZoe renaultZoe = new RenaultZoe();
            Console.WriteLine($"El vehículo {renaultZoe.GetType().Name} es un {renaultZoe.TipoVehiculo()} y {renaultZoe.Avanzar()}, {renaultZoe.Frenar()} y {renaultZoe.Retroceder()} como los demás vehículos");
            BMW BMW = new BMW();
            Console.WriteLine($"El vehículo {BMW.GetType().Name} es un {BMW.TipoVehiculo()} y {BMW.Avanzar()}, {BMW.Frenar()} y {BMW.Retroceder()} como los demás vehículos");
            Console.ReadKey();
        }
    }
}
