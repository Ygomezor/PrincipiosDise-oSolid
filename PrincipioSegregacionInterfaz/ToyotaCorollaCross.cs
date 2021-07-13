using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioSegregacionInterfaz
{
    class ToyotaCorollaCross : Automovil, IAutomovilHibrido
    {
        public string TipoVehiculo()
        {
            return "vehículo híbrido";
        }
    }
}
