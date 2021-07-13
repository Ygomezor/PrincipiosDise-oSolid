using System;

namespace ResponsabilidadUnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S: Single responsibility principle o Principio de responsabilidad única");
            Automovil automovil = new Automovil("BMW");
            Console.WriteLine(automovil.ObtenerMarcaAutomovil());
            AutomovilDB automovilDB = new AutomovilDB();
            automovilDB.GuardarAutomovilDB(automovil);
            Console.ReadKey();
        }
    }
}
