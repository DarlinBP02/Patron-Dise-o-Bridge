using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Diseño_Bridge
{
    // Implementor
    public interface IMotor
    {
        void InyectarCombustible(double cantidad);
        void ConsumirCombustible();
    }
}
