using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSegregacionInterfaz
{
    interface IAutomovilHibrido : IAutomovil
    {
        string TipoVehiculo();
    }
}
