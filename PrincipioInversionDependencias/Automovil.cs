using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioInversionDependencias
{
    class Automovil : IAutomovil
    {
        public void Avanzar()
        {
            Console.WriteLine("esta avanzando");
        }

        public void Frenar()
        {
            Console.WriteLine("se ha detenico");
        }
    }
}
