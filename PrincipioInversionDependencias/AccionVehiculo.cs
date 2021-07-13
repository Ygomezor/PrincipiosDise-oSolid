using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioInversionDependencias
{
    class AccionVehiculo
    {
        private readonly IAutomovil _automovil;
        public AccionVehiculo(Automovil automovil)
        {
            this._automovil = automovil;
        }
        public void Avanzar()
        {
            this._automovil.Avanzar();
        }
        public void Frenar()
        {
            this._automovil.Frenar();
        }
    }
}
