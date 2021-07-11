using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSustitucionLiskov
{
    class Renault : Automovil
    {
        public override int NumeroAsientos() => 5;

        public override int PrecioAutomovil()=> 76238465;
    }
}
