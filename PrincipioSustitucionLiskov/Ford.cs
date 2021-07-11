using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSustitucionLiskov
{
    class Ford : Automovil
    {
        public override int NumeroAsientos() => 2;

        public override int PrecioAutomovil() => 124000000;
    }
}
