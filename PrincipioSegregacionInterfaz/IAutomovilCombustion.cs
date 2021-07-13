using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSegregacionInterfaz
{
    interface IAutomovilCombustion : IAutomovil
    {
        string TipoVehiculo();
    }
}
