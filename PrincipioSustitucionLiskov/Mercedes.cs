using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSustitucionLiskov
{
    class Mercedes : Automovil
    {
        public override int NumeroAsientos() => 7;

        public override int PrecioAutomovil() => 876543767;
    }
}
