using System;

namespace ResponsabilidadUnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil automovil = new Automovil("BMW");
            Console.WriteLine(automovil.ObtenerMarcaAutomovil());
            AutomovilDB automovilDB = new AutomovilDB();
            automovilDB.GuardarAutomovilDB(automovil);
            Console.ReadKey();
        }
    }
}
