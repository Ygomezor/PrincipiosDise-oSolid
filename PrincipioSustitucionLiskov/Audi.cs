using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSustitucionLiskov
{
    class Audi : Automovil
    {
        public override int NumeroAsientos() => 4;

        public override int PrecioAutomovil()=> 567898765;
    }
}
