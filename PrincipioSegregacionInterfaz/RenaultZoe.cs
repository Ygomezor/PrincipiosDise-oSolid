using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSegregacionInterfaz
{
    class RenaultZoe : Automovil, IAutomovilElectrico
    {
        public string TipoVehiculo()
        {
            return "vehículo eléctrico";
        }
    }
}
