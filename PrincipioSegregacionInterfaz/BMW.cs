using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSegregacionInterfaz
{
    class BMW : Automovil, IAutomovilCombustion
    {
        public string TipoVehiculo()
        {
            return "vehículo a gasolina";
        }
    }
}
