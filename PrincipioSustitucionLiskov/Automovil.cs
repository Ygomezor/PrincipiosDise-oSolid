using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSustitucionLiskov
{
    abstract class Automovil
    {
        public Automovil()
        {
            
        }
        public abstract int PrecioAutomovil();
        public abstract int NumeroAsientos();
    }
}
