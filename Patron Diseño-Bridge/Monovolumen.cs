using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Diseño_Bridge
{
    public class Monovolumen : Vehiculo
    {
        // Atributo propio
        private bool puertaCorrediza;
        private int v;

        // La implementacion de los vehículos se desarrolla de forma independiente
        public Monovolumen(IMotor motor, bool puertaCorrediza)
            : base(motor)
        {
            this.puertaCorrediza = puertaCorrediza;
        }

        public Monovolumen(IMotor motor, int v) : base(motor)
        {
            this.v = v;
        }

        // Implementación del método abstracto
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Monovolumen " + (puertaCorrediza ? "con" : "sin") +
                " puerta corrediza.");
        }
    }
}
