using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioAbiertoCerrado
{
    abstract class Automovil
    {
        string marca;
        public Automovil()
        {
            
        }

        public string ObtenerMarcaAutomovil()
        {
            return this.marca;
        }

        public abstract int PrecioAutomovil();
    }
}
