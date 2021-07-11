using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsabilidadUnica
{
    class Automovil
    {
        string marca;
        public Automovil(string marca)
        {
            this.marca = marca;   
        }

       public string ObtenerMarcaAutomovil() 
        {
            return this.marca;
        }
    }
}
