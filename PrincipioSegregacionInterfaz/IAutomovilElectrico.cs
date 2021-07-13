using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSegregacionInterfaz
{
    interface IAutomovilElectrico : IAutomovil
    {
        string TipoVehiculo();
    }
}
