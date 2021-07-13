using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSegregacionInterfaz
{
    class Automovil : IAutomovil
    {
        public string Avanzar()
        {
            return "Avanzo";
        }

        public string Frenar()
        {
            return "Freno";
        }

        public string Retroceder()
        {
            return "Retrocedo";
        }
    }
}
